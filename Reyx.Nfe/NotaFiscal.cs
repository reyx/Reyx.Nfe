using Reyx.Nfe.Assinatura;
using Reyx.Nfe.Danfe;
using Reyx.Nfe.WebService.Cancelamento;
using Reyx.Nfe.WebService.Consulta;
using Reyx.Nfe.WebService.Inutilizacao;
using Reyx.Nfe.WebService.Recepcao;
using Reyx.Nfe.WebService.RecepcaoEvento;
using Reyx.Nfe.WebService.RetRecepcao;
using Reyx.Nfe.XmlParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Linq;

namespace Reyx.Nfe
{
    /// <summary>
    ///
    /// </summary>
    [ComVisible(true), GuidAttribute("07C42292-D86B-46DD-87CC-83F485368507")]
    [ProgId("Rcky.Nfe.NotaFiscal")]
    [ClassInterface(ClassInterfaceType.None)]
    [RunInstaller(true)]
    public class NotaFiscal : Installer, INotaFiscal
    {
        private Reyx.Nfe.PL_006u.TNfeProc procNFe { get; set; }

        private Reyx.Nfe.PL_006u.TNFe NFe { get; set; }

        private Reyx.Nfe.PL_006u.TNFeInfNFeDet det { get; set; }

        private const string schemaEnvio = "2.00";
        private const string schemaConsulta = "2.01";
        private const string schemaRecibo = "2.00";
        private const string schemaCancelamento = "2.00";
        private const string schemaCancelamentoEvento = "2.00";
        private const string schemaInutilização = "2.00";
        private const string schemaCorrecao = "2.00";
        private const string schemaNFe = "2.00";
        private const string schemaWebService = "2.00";

        private string pasta { get; set; }

        private string chaveNFe { get; set; }

        private string idLote { get; set; }

        private string webService { get; set; }

        private List<string> erros { get; set; }

        private List<string> mensagens { get; set; }

        private X509Certificate2 certificado { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="stateSaver"></param>
        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);
            RegistrationServices regsrv = new RegistrationServices();
            if (!regsrv.RegisterAssembly(this.GetType().Assembly, AssemblyRegistrationFlags.SetCodeBase))
            {
                throw new InstallException("Failed To Register for COM Interop");
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="savedState"></param>
        public override void Uninstall(System.Collections.IDictionary savedState)
        {
            Trace.WriteLine("Uninstall custom action - unregistering from COM Interop");
            try
            {
                base.Uninstall(savedState);
                RegistrationServices regsrv = new RegistrationServices();
                if (!regsrv.UnregisterAssembly(this.GetType().Assembly))
                {
                    Trace.WriteLine("COM Interop deregistration failed");
                    throw new InstallException("Failed To Unregister from COM Interop");
                }
            }
            finally
            {
                Trace.WriteLine("Completed uninstall custom action");
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="xml"></param>
        public void IntervencaoManual(XmlDocument xml)
        {
            this.NFe = xml.OuterXml.ToXmlClass<Reyx.Nfe.PL_006u.TNFe>();
            this.chaveNFe = this.NFe.infNFe.Id.Substring(3);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pasta"></param>
        /// <param name="chave"></param>
        public void Nova(string pasta, string chave)
        {
            this.mensagens = new List<string>();
            this.erros = new List<string>();

            try
            {
                this.chaveNFe = chave;

                if (string.IsNullOrWhiteSpace(pasta))
                {
                    erros.Add("Pasta não informada.");
                }
                else
                {
                    this.pasta = pasta;

                    this.NFe = new Reyx.Nfe.PL_006u.TNFe();
                    this.NFe.infNFe = new Reyx.Nfe.PL_006u.TNFeInfNFe();
                    this.NFe.infNFe.versao = schemaNFe;
                    this.NFe.infNFe.det = new List<Reyx.Nfe.PL_006u.TNFeInfNFeDet>();
                    this.NFe.infNFe.ide = new Reyx.Nfe.PL_006u.TNFeInfNFeIde();
                    this.NFe.infNFe.total = new Reyx.Nfe.PL_006u.TNFeInfNFeTotal();
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao criar nova nota fiscal --");
                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="refNFe"></param>
        /// <param name="tipo"></param>
        /// <param name="cUF"></param>
        /// <param name="AAMM"></param>
        /// <param name="CNPJ"></param>
        /// <param name="mod"></param>
        /// <param name="serie"></param>
        /// <param name="nNF"></param>
        /// <param name="nECF"></param>
        /// <param name="nCOO"></param>
        public void AdicionarNotaReferenciada(string refNFe, string tipo, string cUF, string AAMM, string CNPJ, string mod, string serie, string nNF, string nECF, string nCOO)
        {
            try
            {
                if (this.NFe.infNFe == null)
                {
                    this.NFe.infNFe = new Reyx.Nfe.PL_006u.TNFeInfNFe();
                }
                if (this.NFe.infNFe.ide == null)
                {
                    this.NFe.infNFe.ide = new Reyx.Nfe.PL_006u.TNFeInfNFeIde();
                }
                if (this.NFe.infNFe.ide.NFref == null)
                {
                    this.NFe.infNFe.ide.NFref = new List<Reyx.Nfe.PL_006u.TNFeInfNFeIdeNFref>();
                }

                Reyx.Nfe.PL_006u.TNFeInfNFeIdeNFref nfeRef = new Reyx.Nfe.PL_006u.TNFeInfNFeIdeNFref();

                if (!string.IsNullOrWhiteSpace(refNFe))
                {
                    nfeRef.Item = refNFe;
                }
                else
                {
                    switch (tipo)
                    {
                        case "refNF":
                            nfeRef.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeIdeNFrefRefNF()
                            {
                                AAMM = AAMM,
                                CNPJ = CNPJ,
                                cUF = cUF.ToEnum<PL_006u.TCodUfIBGE>(),
                                mod = mod.ToEnum<PL_006u.TNFeInfNFeIdeNFrefRefNFMod>(),
                                nNF = nNF,
                                serie = serie
                            };
                            break;

                        case "refECF":
                            nfeRef.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeIdeNFrefRefECF()
                            {
                                mod = mod.ToEnum<PL_006u.TNFeInfNFeIdeNFrefRefECFMod>(),
                                nCOO = nCOO,
                                nECF = nECF
                            };
                            break;
                    }
                }

                this.NFe.infNFe.ide.NFref.Add(nfeRef);
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar nota referenciada --");
                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="idLote"></param>
        /// <param name="versao"></param>
        /// <param name="cUF"></param>
        /// <param name="natOp"></param>
        /// <param name="indPag"></param>
        /// <param name="mod"></param>
        /// <param name="serie"></param>
        /// <param name="nNF"></param>
        /// <param name="dEmi"></param>
        /// <param name="dSaiEnt"></param>
        /// <param name="hSaiEnt"></param>
        /// <param name="tpNF"></param>
        /// <param name="cMunFG"></param>
        /// <param name="tpImp"></param>
        /// <param name="tpEmis"></param>
        /// <param name="cDV"></param>
        /// <param name="tpAmb"></param>
        /// <param name="finNFe"></param>
        /// <param name="procEmi"></param>
        /// <param name="verProc"></param>
        /// <param name="infAdFisco"></param>
        /// <param name="infCpl"></param>
        public void AdicionarCabecalho(
            string idLote, string versao, string cUF, string natOp, string indPag, string mod, string serie, string nNF, string dEmi,
            string dSaiEnt, string hSaiEnt, string tpNF, string cMunFG, string tpImp, string tpEmis, string cDV, string tpAmb, string finNFe,
            string procEmi, string verProc, string infAdFisco, string infCpl)
        {
            try
            {
                this.idLote = idLote;
                this.NFe.infNFe.versao = versao;
                this.NFe.infNFe.ide.cUF = cUF.ToEnum<PL_006u.TCodUfIBGE>();
                this.NFe.infNFe.ide.natOp = natOp;
                this.NFe.infNFe.ide.indPag = indPag.ToEnum<PL_006u.TNFeInfNFeIdeIndPag>();
                this.NFe.infNFe.ide.mod = mod.ToEnum<PL_006u.TMod>();
                this.NFe.infNFe.ide.serie = serie;
                this.NFe.infNFe.ide.nNF = nNF;
                this.NFe.infNFe.ide.dEmi = dEmi;
                this.NFe.infNFe.ide.dSaiEnt = dSaiEnt;
                this.NFe.infNFe.ide.hSaiEnt = hSaiEnt;
                this.NFe.infNFe.ide.tpNF = tpNF.ToEnum<PL_006u.TNFeInfNFeIdeTpNF>();
                this.NFe.infNFe.ide.cMunFG = cMunFG;
                this.NFe.infNFe.ide.tpImp = tpImp.ToEnum<PL_006u.TNFeInfNFeIdeTpImp>();
                this.NFe.infNFe.ide.tpEmis = tpEmis.ToEnum<PL_006u.TNFeInfNFeIdeTpEmis>();
                this.NFe.infNFe.ide.cDV = cDV;
                this.NFe.infNFe.ide.tpAmb = tpAmb.ToEnum<PL_006u.TAmb>();
                this.NFe.infNFe.ide.finNFe = finNFe.ToEnum<PL_006u.TFinNFe>();
                this.NFe.infNFe.ide.procEmi = procEmi.ToEnum<PL_006u.TProcEmi>();
                this.NFe.infNFe.ide.verProc = verProc;

                if (!string.IsNullOrWhiteSpace(infAdFisco) || !string.IsNullOrWhiteSpace(infCpl))
                {
                    this.NFe.infNFe.infAdic = new Reyx.Nfe.PL_006u.TNFeInfNFeInfAdic()
                    {
                        infAdFisco = infAdFisco,
                        infCpl = infCpl
                    };
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar propriedade --");

                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="CPF"></param>
        /// <param name="CNPJ"></param>
        /// <param name="IE"></param>
        /// <param name="IEST"></param>
        /// <param name="IM"></param>
        /// <param name="CNAE"></param>
        /// <param name="CRT"></param>
        /// <param name="xNome"></param>
        /// <param name="xFant"></param>
        /// <param name="xLgr"></param>
        /// <param name="nro"></param>
        /// <param name="xCpl"></param>
        /// <param name="xBairro"></param>
        /// <param name="cMun"></param>
        /// <param name="xMun"></param>
        /// <param name="UF"></param>
        /// <param name="CEP"></param>
        /// <param name="cPais"></param>
        /// <param name="xPais"></param>
        /// <param name="fone"></param>
        public void AdicionarDadosEmitente(
            string CPF, string CNPJ, string IE, string IEST, string IM, string CNAE, string CRT, string xNome, string xFant,
            string xLgr, string nro, string xCpl, string xBairro, string cMun, string xMun, string UF, string CEP, string cPais, string xPais, string fone)
        {
            try
            {
                this.NFe.infNFe.emit = new Reyx.Nfe.PL_006u.TNFeInfNFeEmit()
                {
                    IE = IE,
                    IEST = IEST,
                    IM = IM,
                    CNAE = CNAE,
                    CRT = (PL_006u.TNFeInfNFeEmitCRT)Enum.Parse(typeof(PL_006u.TNFeInfNFeEmitCRT), CRT),
                    xNome = xNome,
                    xFant = xFant,
                    enderEmit = new Reyx.Nfe.PL_006u.TEnderEmi()
                    {
                        xLgr = xLgr,
                        nro = nro,
                        xCpl = xCpl,
                        xBairro = xBairro,
                        cMun = cMun,
                        xMun = xMun,
                        UF = (PL_006u.TUfEmi)Enum.Parse(typeof(PL_006u.TUfEmi), UF),
                        CEP = CEP,
                        cPais = (PL_006u.TEnderEmiCPais)Enum.Parse(typeof(PL_006u.TEnderEmiCPais), cPais),
                        xPais = (PL_006u.TEnderEmiXPais)Enum.Parse(typeof(PL_006u.TEnderEmiXPais), xPais),
                        fone = fone
                    }
                };
                if (!String.IsNullOrWhiteSpace(CPF))
                {
                    this.NFe.infNFe.emit.ItemElementName = PL_006u.ItemChoiceType2.CPF;
                    this.NFe.infNFe.emit.Item = CPF;
                }
                else if (!String.IsNullOrWhiteSpace(CNPJ))
                {
                    this.NFe.infNFe.emit.ItemElementName = PL_006u.ItemChoiceType2.CNPJ;
                    this.NFe.infNFe.emit.Item = CNPJ;
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar propriedade --");

                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="CPF"></param>
        /// <param name="CNPJ"></param>
        /// <param name="IE"></param>
        /// <param name="ISUF"></param>
        /// <param name="xNome"></param>
        /// <param name="email"></param>
        /// <param name="xLgr"></param>
        /// <param name="nro"></param>
        /// <param name="xCpl"></param>
        /// <param name="xBairro"></param>
        /// <param name="cMun"></param>
        /// <param name="xMun"></param>
        /// <param name="UF"></param>
        /// <param name="CEP"></param>
        /// <param name="cPais"></param>
        /// <param name="xPais"></param>
        /// <param name="fone"></param>
        public void AdicionarDadosDestinatario(
            string CPF, string CNPJ, string IE, string ISUF, string xNome, string email,
            string xLgr, string nro, string xCpl, string xBairro, string cMun, string xMun,
            string UF, string CEP, string cPais, string xPais, string fone)
        {
            try
            {
                this.NFe.infNFe.dest = new Reyx.Nfe.PL_006u.TNFeInfNFeDest()
                {
                    IE = IE,
                    xNome = xNome,
                    email = email,
                    ISUF = ISUF,
                    enderDest = new PL_006u.TEndereco()
                    {
                        xLgr = xLgr,
                        nro = nro,
                        xCpl = xCpl,
                        xBairro = xBairro,
                        cMun = cMun,
                        xMun = xMun,
                        UF = (PL_006u.TUf)Enum.Parse(typeof(PL_006u.TUfEmi), UF),
                        CEP = CEP,
                        cPais = (PL_006u.Tpais)Enum.Parse(typeof(PL_006u.TEnderEmiCPais), cPais),
                        xPais = xPais,
                        fone = fone
                    }
                };

                if (!String.IsNullOrWhiteSpace(CPF))
                {
                    this.NFe.infNFe.dest.ItemElementName = PL_006u.ItemChoiceType3.CPF;
                    this.NFe.infNFe.dest.Item = CPF;
                }
                else if (!String.IsNullOrWhiteSpace(CNPJ))
                {
                    this.NFe.infNFe.dest.ItemElementName = PL_006u.ItemChoiceType3.CNPJ;
                    this.NFe.infNFe.dest.Item = CNPJ;
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar propriedade --");

                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="CPF"></param>
        /// <param name="CNPJ"></param>
        /// <param name="xLgr"></param>
        /// <param name="nro"></param>
        /// <param name="xCpl"></param>
        /// <param name="xBairro"></param>
        /// <param name="cMun"></param>
        /// <param name="xMun"></param>
        /// <param name="UF"></param>
        public void AdicionarDadosEntrega(string CPF, string CNPJ, string xLgr, string nro, string xCpl, string xBairro, string cMun, string xMun, string UF)
        {
            try
            {
                this.NFe.infNFe.entrega = new PL_006u.TLocal()
                {
                    xLgr = xLgr,
                    nro = nro,
                    xCpl = xCpl,
                    xBairro = xBairro,
                    cMun = cMun,
                    xMun = xMun,
                    UF = UF.ToEnum<PL_006u.TUf>()
                };

                if (!String.IsNullOrWhiteSpace(CPF))
                {
                    this.NFe.infNFe.entrega.ItemElementName = PL_006u.ItemChoiceType4.CPF;
                    this.NFe.infNFe.entrega.Item = CPF;
                }
                else if (!String.IsNullOrWhiteSpace(CNPJ))
                {
                    this.NFe.infNFe.entrega.ItemElementName = PL_006u.ItemChoiceType4.CNPJ;
                    this.NFe.infNFe.entrega.Item = CNPJ;
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar propriedade --");

                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="CPF"></param>
        /// <param name="CNPJ"></param>
        /// <param name="xLgr"></param>
        /// <param name="nro"></param>
        /// <param name="xCpl"></param>
        /// <param name="xBairro"></param>
        /// <param name="cMun"></param>
        /// <param name="xMun"></param>
        /// <param name="UF"></param>
        public void AdicionarDadosRetirada(string CPF, string CNPJ, string xLgr, string nro, string xCpl, string xBairro, string cMun, string xMun, string UF)
        {
            try
            {
                this.NFe.infNFe.retirada = new PL_006u.TLocal()
                {
                    xLgr = xLgr,
                    nro = nro,
                    xCpl = xCpl,
                    xBairro = xBairro,
                    cMun = cMun,
                    xMun = xMun,
                    UF = UF.ToEnum<PL_006u.TUf>()
                };

                if (!String.IsNullOrWhiteSpace(CPF))
                {
                    this.NFe.infNFe.entrega.ItemElementName = PL_006u.ItemChoiceType4.CPF;
                    this.NFe.infNFe.entrega.Item = CPF;
                }
                else if (!String.IsNullOrWhiteSpace(CNPJ))
                {
                    this.NFe.infNFe.entrega.ItemElementName = PL_006u.ItemChoiceType4.CNPJ;
                    this.NFe.infNFe.entrega.Item = CNPJ;
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar propriedade --");

                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="CPF"></param>
        /// <param name="CNPJ"></param>
        /// <param name="IE"></param>
        /// <param name="xNome"></param>
        /// <param name="xEnder"></param>
        /// <param name="xMun"></param>
        /// <param name="UF"></param>
        /// <param name="vServ"></param>
        /// <param name="vBCRet"></param>
        /// <param name="pICMSRet"></param>
        /// <param name="vICMSRet"></param>
        /// <param name="CFOP"></param>
        /// <param name="cMunFG"></param>
        public void AdicionarDadosTransportador(
            string CPF, string CNPJ, string IE, string xNome, string xEnder, string xMun, string UF,
            string vServ, string vBCRet, string pICMSRet, string vICMSRet, string CFOP, string cMunFG)
        {
            try
            {
                this.NFe.infNFe.transp = new Reyx.Nfe.PL_006u.TNFeInfNFeTransp()
                {
                    transporta = new Reyx.Nfe.PL_006u.TNFeInfNFeTranspTransporta()
                    {
                        IE = IE,
                        xNome = xNome,
                        xEnder = xEnder,
                        xMun = xMun,
                        UF = UF.ToEnum<PL_006u.TUf>()
                    },
                    retTransp = new PL_006u.TNFeInfNFeTranspRetTransp()
                    {
                        vServ = vServ,
                        vBCRet = vBCRet,
                        pICMSRet = pICMSRet,
                        vICMSRet = vICMSRet,
                        CFOP = CFOP.ToEnum<PL_006u.TCfopTransp>(),
                        cMunFG = cMunFG
                    }
                };

                if (!String.IsNullOrWhiteSpace(CPF))
                {
                    this.NFe.infNFe.transp.transporta.ItemElementName = PL_006u.ItemChoiceType5.CPF;
                    this.NFe.infNFe.transp.transporta.Item = CPF;
                }
                else if (!String.IsNullOrWhiteSpace(CNPJ))
                {
                    this.NFe.infNFe.transp.transporta.ItemElementName = PL_006u.ItemChoiceType5.CNPJ;
                    this.NFe.infNFe.transp.transporta.Item = CNPJ;
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar propriedade --");

                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="RNTC"></param>
        /// <param name="UF"></param>
        public void AdicionarVeiculoTransporte(string placa, string RNTC, string UF)
        {
            try
            {
                if (this.NFe.infNFe.transp.Items == null)
                    this.NFe.infNFe.transp.Items = new PL_006u.TVeiculo[] { };

                var list = this.NFe.infNFe.transp.Items.ToList();

                list.Add(new PL_006u.TVeiculo()
                {
                    placa = placa,
                    RNTC = RNTC,
                    UF = UF.ToEnum<PL_006u.TUf>()
                });

                this.NFe.infNFe.transp.Items = list.ToArray();
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar propriedade --");

                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="vBC"></param>
        /// <param name="vBCST"></param>
        /// <param name="vCOFINS"></param>
        /// <param name="vDesc"></param>
        /// <param name="vFrete"></param>
        /// <param name="vICMS"></param>
        /// <param name="vII"></param>
        /// <param name="vIPI"></param>
        /// <param name="vNF"></param>
        /// <param name="vOutro"></param>
        /// <param name="vPIS"></param>
        /// <param name="vProd"></param>
        /// <param name="vSeg"></param>
        /// <param name="vST"></param>
        public void AdicionarTotalIcms(
            string vBC, string vBCST, string vCOFINS, string vDesc, string vFrete, string vICMS, string vII,
            string vIPI, string vNF, string vOutro, string vPIS, string vProd, string vSeg, string vST)
        {
            try
            {
                this.NFe.infNFe.total.ICMSTot = new PL_006u.TNFeInfNFeTotalICMSTot()
                {
                    vBC = vBC,
                    vBCST = vBCST,
                    vCOFINS = vCOFINS,
                    vDesc = vDesc,
                    vFrete = vFrete,
                    vICMS = vICMS,
                    vII = vII,
                    vIPI = vIPI,
                    vNF = vNF,
                    vOutro = vOutro,
                    vPIS = vPIS,
                    vProd = vProd,
                    vSeg = vSeg,
                    vST = vST,
                };
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar propriedade --");

                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="vBC"></param>
        /// <param name="vCOFINS"></param>
        /// <param name="vISS"></param>
        /// <param name="vPIS"></param>
        /// <param name="vServ"></param>
        public void AdicionarTotalIssqn(string vBC, string vCOFINS, string vISS, string vPIS, string vServ)
        {
            try
            {
                this.NFe.infNFe.total.ISSQNtot = new PL_006u.TNFeInfNFeTotalISSQNtot()
                {
                    vBC = vBC,
                    vCOFINS = vCOFINS,
                    vISS = vISS,
                    vPIS = vPIS,
                    vServ = vServ
                };
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar propriedade --");

                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="vBCIRRF"></param>
        /// <param name="vBCRetPrev"></param>
        /// <param name="vIRRF"></param>
        /// <param name="vRetCOFINS"></param>
        /// <param name="vRetCSLL"></param>
        /// <param name="vRetPIS"></param>
        /// <param name="vRetPrev"></param>
        public void AdicionarTotalRetencaoTributaria(string vBCIRRF, string vBCRetPrev, string vIRRF, string vRetCOFINS, string vRetCSLL, string vRetPIS, string vRetPrev)
        {
            try
            {
                this.NFe.infNFe.total.retTrib = new PL_006u.TNFeInfNFeTotalRetTrib()
                {
                    vBCIRRF = vBCIRRF,
                    vBCRetPrev = vBCRetPrev,
                    vIRRF = vIRRF,
                    vRetCOFINS = vRetCOFINS,
                    vRetCSLL = vRetCSLL,
                    vRetPIS = vRetPIS,
                    vRetPrev = vRetPrev
                };
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar propriedade --");

                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void AdicionarItem(
            string nItem, string infAdProd, string cProd, string cEAN, string xProd, string NCM, string EXTIPI, string CFOP,
            string uCom, string qCom, string vUnCom, string vProd, string cEANTrib, string uTrib, string qTrib, string vUnTrib,
            string indTot, string vFrete, string vSeg, string vDesc, string vOutro, string xPed, string nItemPed)
        {
            try
            {
                this.det = new Reyx.Nfe.PL_006u.TNFeInfNFeDet()
                {
                    nItem = nItem,
                    infAdProd = infAdProd,
                    prod = new PL_006u.TNFeInfNFeDetProd()
                    {
                        cProd = cProd,
                        cEAN = cEAN,
                        xProd = xProd,
                        NCM = NCM,
                        EXTIPI = EXTIPI,
                        CFOP = CFOP.ToEnum<PL_006u.TCfop>(),
                        uCom = uCom,
                        qCom = qCom,
                        vUnCom = vUnCom,
                        vProd = vProd,
                        cEANTrib = cEANTrib,
                        uTrib = uTrib,
                        qTrib = qTrib,
                        vUnTrib = vUnTrib,
                        indTot = indTot.ToEnum<PL_006u.TNFeInfNFeDetProdIndTot>(),
                        vFrete = vFrete,
                        vSeg = vSeg,
                        vDesc = vDesc,
                        vOutro = vOutro,
                        xPed = xPed,
                        nItemPed = nItemPed
                    }
                };

                this.det.imposto = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImposto();

                this.NFe.infNFe.det.Add(this.det);
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar item --");
                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="CST"></param>
        /// <param name="orig"></param>
        /// <param name="modBC"></param>
        /// <param name="vBC"></param>
        /// <param name="pRedBC"></param>
        /// <param name="pICMS"></param>
        /// <param name="vICMS"></param>
        /// <param name="modBCST"></param>
        /// <param name="pMVAST"></param>
        /// <param name="pRedBCST"></param>
        /// <param name="vBCST"></param>
        /// <param name="pICMSST"></param>
        /// <param name="vICMSST"></param>
        /// <param name="pCredSN"></param>
        /// <param name="vCredICMSSN"></param>
        /// <param name="motDesICMS"></param>
        /// <param name="pBCOp"></param>
        /// <param name="UFST"></param>
        /// <param name="vICMSSTRet"></param>
        /// <param name="vBCSTRet"></param>
        public void AdicionarIcmsItem(
            string CST, string orig, string modBC, string vBC, string pRedBC, string pICMS, string vICMS, string modBCST, string pMVAST,
            string pRedBCST, string vBCST, string pICMSST, string vICMSST, string pCredSN, string vCredICMSSN, string motDesICMS,
            string pBCOp, string UFST, string vICMSSTRet, string vBCSTRet)
        {
            try
            {
                if (det.imposto == null)
                    det.imposto = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImposto();

                Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMS icms = new PL_006u.TNFeInfNFeDetImpostoICMS();

                switch (CST)
                {
                    case "00":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS00()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS00CST>(),
                            modBC = modBC.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS00ModBC>(),
                            vBC = vBC,
                            pICMS = pICMS,
                            vICMS = vICMS
                        };
                        break;

                    case "10":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS10()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS10CST>(),
                            modBC = modBC.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS10ModBC>(),
                            vBC = vBC,
                            pICMS = pICMS,
                            vICMS = vICMS,
                            modBCST = modBCST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS10ModBCST>(),
                            vBCST = vBCST,
                            pICMSST = pICMSST,
                            vICMSST = vICMSST,
                            pMVAST = pMVAST,
                            pRedBCST = pRedBCST
                        };
                        break;

                    case "20":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS20()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS20CST>(),
                            modBC = modBC.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS20ModBC>(),
                            vBC = vBC,
                            pRedBC = pRedBC,
                            pICMS = pICMS,
                            vICMS = vICMS
                        };
                        break;

                    case "30":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS30()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS30CST>(),
                            modBCST = modBCST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS30ModBCST>(),
                            vBCST = vBCST,
                            pICMSST = pICMSST,
                            vICMSST = vICMSST,
                            pMVAST = pMVAST,
                            pRedBCST = pRedBCST
                        };
                        break;

                    case "40":
                    case "41":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS40()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS40CST>(),
                            vICMS = vICMS,
                            motDesICMS = motDesICMS.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS40MotDesICMS>()
                        };
                        break;

                    case "ST":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMSST()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CST = PL_006u.TNFeInfNFeDetImpostoICMSICMSSTCST.Item41,
                            vBCSTRet = vBCSTRet,
                            vICMSSTRet = vICMSSTRet
                        };

                        // if (!string.IsNullOrWhiteSpace(vBCSTDest)) icms.Item.ICMSST.vBCSTDest = vBCSTDest;
                        // if (!string.IsNullOrWhiteSpace(vICMSSTDest)) icms.Item.ICMSST.vICMSSTDest = vICMSSTDest;

                        break;

                    case "50":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS40()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS40CST>(),
                            motDesICMS = motDesICMS.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS40MotDesICMS>(),
                            vICMS = vICMS
                        };
                        break;

                    case "51":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS51()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS51CST>(),
                            modBC = modBC.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS51ModBC>(),
                            pRedBC = pRedBC,
                            vBC = vBC,
                            pICMS = pICMS,
                            vICMS = vICMS
                        };
                        break;

                    case "60":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS60()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS60CST>(),
                            vICMSSTRet = vICMSSTRet,
                            vBCSTRet = vBCSTRet
                        };
                        break;

                    case "70":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS70()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS70CST>(),
                            modBC = modBC.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS70ModBC>(),
                            vBC = vBC,
                            pRedBC = pRedBC,
                            pICMS = pICMS,
                            vICMS = vICMS,
                            modBCST = modBCST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS70ModBCST>(),
                            pRedBCST = pRedBCST,
                            vBCST = vBCST,
                            pICMSST = pICMSST,
                            vICMSST = vICMSST,
                            pMVAST = string.IsNullOrWhiteSpace(pMVAST) ? null : pMVAST
                        };
                        break;

                    case "90":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS90()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS90CST>(),
                            modBC = modBC.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS90ModBC>(),
                            vBC = vBC,
                            pRedBC = pRedBC,
                            pRedBCST = pRedBCST,
                            pICMS = pICMS,
                            vICMS = vICMS,
                            modBCST = modBCST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMS90ModBCST>(),
                            pMVAST = pMVAST,
                            vBCST = vBCST,
                            pICMSST = pICMSST,
                            vICMSST = vICMSST
                        };
                        break;

                    case "P10":
                    case "P90":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMSPart()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CST = CST.Substring(1).ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSPartCST>(),
                            modBC = modBC.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSPartModBC>(),
                            vBC = vBC,
                            pRedBC = pRedBC,
                            pRedBCST = pRedBCST,
                            pICMS = pICMS,
                            vICMS = vICMS,
                            modBCST = modBCST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSPartModBCST>(),
                            pMVAST = pMVAST,
                            vBCST = vBCST,
                            pICMSST = pICMSST,
                            vICMSST = vICMSST,
                            pBCOp = pBCOp,
                            UFST = UFST.ToEnum<PL_006u.TUf>()
                        };
                        break;

                    case "101":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMSSN101()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CSOSN = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSSN101CSOSN>(),
                            pCredSN = pCredSN,
                            vCredICMSSN = vCredICMSSN
                        };
                        break;

                    case "102":
                    case "103":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMSSN102()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CSOSN = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSSN102CSOSN>()
                        };
                        break;

                    case "201":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMSSN201()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CSOSN = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSSN201CSOSN>(),
                            modBCST = modBCST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSSN201ModBCST>(),
                            vBCST = vBCST,
                            pICMSST = pICMSST,
                            vICMSST = vICMSST,
                            pCredSN = pCredSN,
                            vCredICMSSN = vCredICMSSN,
                            pMVAST = pMVAST,
                            pRedBCST = pRedBCST
                        };
                        break;

                    case "202":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMSSN202()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CSOSN = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSSN202CSOSN>(),
                            modBCST = modBCST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSSN202ModBCST>(),
                            pMVAST = pMVAST,
                            pRedBCST = pRedBCST,
                            vBCST = vBCST,
                            pICMSST = pICMSST,
                            vICMSST = vICMSST
                        };
                        break;

                    case "203":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMSSN202()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CSOSN = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSSN202CSOSN>(),
                            modBCST = modBCST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSSN202ModBCST>(),
                            pMVAST = pMVAST,
                            pRedBCST = pRedBCST,
                            vBCST = vBCST,
                            pICMSST = pICMSST,
                            vICMSST = vICMSST
                        };
                        break;

                    case "300":
                    case "400":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMSSN102()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CSOSN = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSSN102CSOSN>()
                        };
                        break;

                    case "500":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMSSN500()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CSOSN = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSSN500CSOSN>()
                        };
                        break;

                    case "900":
                        icms.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMSSN900()
                        {
                            orig = orig.ToEnum<PL_006u.Torig>(),
                            CSOSN = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSSN900CSOSN>(),
                            modBC = modBC.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSSN900ModBC>(),
                            vBC = vBC,
                            pRedBC = pRedBC,
                            pICMS = pICMS,
                            vICMS = vICMS,
                            modBCST = modBCST.ToEnum<PL_006u.TNFeInfNFeDetImpostoICMSICMSSN900ModBCST>(),
                            pMVAST = pMVAST,
                            vBCST = vBCST,
                            pICMSST = pICMSST,
                            vICMSST = vICMSST,
                            pCredSN = pCredSN,
                            vCredICMSSN = vCredICMSSN,
                            pRedBCST = pRedBCST
                        };
                        break;
                }

                det.imposto.Items.Add(icms);
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar icms do item --");
                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="cEnq"></param>
        /// <param name="CST"></param>
        /// <param name="vBC"></param>
        /// <param name="pIPI"></param>
        /// <param name="qUnid"></param>
        /// <param name="vUnid"></param>
        /// <param name="vIPI"></param>
        public void AdicionarIpiItem(string cEnq, string CST, string vBC, string pIPI, string qUnid, string vUnid, string vIPI)
        {
            try
            {
                Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoIPI ipi = new PL_006u.TNFeInfNFeDetImpostoIPI();
                ipi.cEnq = cEnq;
                // ipi.cSelo = cSelo;
                // ipi.qSelo = qSelo;
                // ipi.CNPJProd = CNPJProd;

                switch (CST)
                {
                    case "00":
                    case "49":
                    case "50":
                    case "99":
                        ipi.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoIPIIPITrib()
                        {
                            CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoIPIIPITribCST>(),
                            vIPI = vIPI,
                            // vBC = vBC,
                            // pIPI = pIPI,
                            // qUnid = qUnid,
                            // vUnid = vUnid
                        };
                        break;

                    default:
                        ipi.Item = new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoIPIIPINT()
                        {
                            CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoIPIIPINTCST>()
                        };
                        break;
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar ipi do item --");
                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="CST"></param>
        /// <param name="vBC"></param>
        /// <param name="pPIS"></param>
        /// <param name="vPIS"></param>
        /// <param name="qBCProd"></param>
        /// <param name="vAliqProd"></param>
        public void AdicionarPisItem(string CST, string vBC, string pPIS, string vPIS, string qBCProd, string vAliqProd)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CST))
                {
                    det.imposto.PISST = new PL_006u.TNFeInfNFeDetImpostoPISST()
                    {
                        vPIS = vPIS,
                        // vBC = vBC,
                        // pPIS = pPIS,
                        // qBCProd = qBCProd,
                        // vAliqProd = vAliqProd
                    };
                }
                else
                {
                    det.imposto.PIS = new PL_006u.TNFeInfNFeDetImpostoPIS();
                    switch (CST)
                    {
                        case "01":
                        case "02":
                            det.imposto.PIS.Item = new PL_006u.TNFeInfNFeDetImpostoPISPISAliq()
                            {
                                CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoPISPISAliqCST>(),
                                vBC = vBC,
                                pPIS = pPIS,
                                vPIS = vPIS
                            };
                            break;

                        case "03":
                            det.imposto.PIS.Item = new PL_006u.TNFeInfNFeDetImpostoPISPISQtde()
                            {
                                CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoPISPISQtdeCST>(),
                                qBCProd = qBCProd,
                                vAliqProd = vAliqProd,
                                vPIS = vPIS
                            };
                            break;

                        case "04":
                        case "06":
                        case "07":
                        case "08":
                        case "09":
                            det.imposto.PIS.Item = new PL_006u.TNFeInfNFeDetImpostoPISPISNT()
                            {
                                CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoPISPISNTCST>()
                            };
                            break;

                        case "99":
                            det.imposto.PIS.Item = new PL_006u.TNFeInfNFeDetImpostoPISPISOutr()
                            {
                                CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoPISPISOutrCST>(),
                                vPIS = vPIS,
                                // vBC = vBC,
                                // pPIS = pPIS,
                                // vAliqProd = vAliqProd,
                                // vPIS = vPIS
                            };
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar pis item --");
                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="CST"></param>
        /// <param name="vBC"></param>
        /// <param name="pCOFINS"></param>
        /// <param name="vCOFINS"></param>
        /// <param name="qBCProd"></param>
        /// <param name="vAliqProd"></param>
        public void AdicionarCofinsItem(string CST, string vBC, string pCOFINS, string vCOFINS, string qBCProd, string vAliqProd)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CST))
                {
                    det.imposto.COFINSST = new PL_006u.TNFeInfNFeDetImpostoCOFINSST()
                    {
                        vCOFINS = vCOFINS,
                        // vBC = vBC,
                        // pCOFINS = pCOFINS,
                        // qBCProd = qBCProd,
                        // vAliqProd = vAliqProd
                    };
                }
                else
                {
                    det.imposto.COFINS = new PL_006u.TNFeInfNFeDetImpostoCOFINS();
                    switch (CST)
                    {
                        case "01":
                        case "02":
                            det.imposto.COFINS.Item = new PL_006u.TNFeInfNFeDetImpostoCOFINSCOFINSAliq()
                            {
                                CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST>(),
                                vBC = vBC,
                                pCOFINS = pCOFINS,
                                vCOFINS = vCOFINS
                            };
                            break;

                        case "03":
                            det.imposto.COFINS.Item = new PL_006u.TNFeInfNFeDetImpostoCOFINSCOFINSQtde()
                            {
                                CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST>(),
                                qBCProd = qBCProd,
                                vAliqProd = vAliqProd,
                                vCOFINS = vCOFINS
                            };
                            break;

                        case "04":
                        case "06":
                        case "07":
                        case "08":
                        case "09":
                            det.imposto.COFINS.Item = new PL_006u.TNFeInfNFeDetImpostoCOFINSCOFINSNT()
                            {
                                CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoCOFINSCOFINSNTCST>()
                            };
                            break;

                        case "99":
                            det.imposto.COFINS.Item = new PL_006u.TNFeInfNFeDetImpostoCOFINSCOFINSOutr()
                            {
                                CST = CST.ToEnum<PL_006u.TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST>(),
                                // qBCProd = qBCProd,
                                // vBC = vBC,
                                // pCOFINS = pCOFINS,
                                // vAliqProd = vAliqProd,
                                vCOFINS = vCOFINS
                            };
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar cofins do item --");
                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="vBC"></param>
        /// <param name="vDespAdu"></param>
        /// <param name="vII"></param>
        /// <param name="vIOF"></param>
        public void AdicionarIiItem(string vBC, string vDespAdu, string vII, string vIOF)
        {
            try
            {
                det.imposto.Items.Add(new Reyx.Nfe.PL_006u.TNFeInfNFeDetImpostoII()
                {
                    vBC = vBC,
                    vDespAdu = vDespAdu,
                    vII = vII,
                    vIOF = vIOF
                });
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar importação --");
                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="data"></param>
        /// <param name="valor"></param>
        public void AdicionarDuplicata(string numero, string data, string valor)
        {
            try
            {
                if (this.NFe.infNFe.cobr == null)
                    this.NFe.infNFe.cobr = new PL_006u.TNFeInfNFeCobr();

                if (this.NFe.infNFe.cobr.dup == null)
                    this.NFe.infNFe.cobr.dup = new List<PL_006u.TNFeInfNFeCobrDup>();

                this.NFe.infNFe.cobr.dup.Add(new PL_006u.TNFeInfNFeCobrDup()
                {
                    dVenc = data,
                    nDup = numero,
                    vDup = valor
                });
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao adicionar duplicata --");
                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="qVol"></param>
        /// <param name="esp"></param>
        /// <param name="marca"></param>
        /// <param name="nVol"></param>
        /// <param name="pesoL"></param>
        /// <param name="pesoB"></param>
        public void AdicionarVolume(string qVol, string esp, string marca, string nVol, string pesoL, string pesoB)
        {
            try
            {
                if (this.NFe.infNFe.transp == null)
                    this.NFe.infNFe.transp = new PL_006u.TNFeInfNFeTransp();

                if (this.NFe.infNFe.transp.vol == null)
                    this.NFe.infNFe.transp.vol = new List<PL_006u.TNFeInfNFeTranspVol>();

                this.NFe.infNFe.transp.vol.Add(new Reyx.Nfe.PL_006u.TNFeInfNFeTranspVol()
                {
                    qVol = qVol,
                    esp = esp,
                    marca = marca,
                    nVol = nVol,
                    pesoB = pesoB,
                    pesoL = pesoL
                });
            }
            catch (Exception ex)
            {
                erros.Add("-- Erro ao adicionar volume -- ");
                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public string Enviar()
        {
            try
            {
                GerarChave();
                ObterWebService("NfeRecepcao", this.NFe.infNFe.emit.enderEmit.UF.Name(), this.NFe.infNFe.ide.tpAmb.Name());

                if (SemErros())
                {
                    using (NfeRecepcao2 ws = new NfeRecepcao2(webService))
                    {
                        ws.nfeCabecMsgValue = new WebService.Recepcao.nfeCabecMsg()
                        {
                            cUF = this.NFe.infNFe.ide.cUF.Name(),
                            versaoDados = schemaEnvio
                        };
                        ws.SoapVersion = SoapProtocolVersion.Soap12;
                        ws.ClientCertificates.Add(certificado);

                        Reyx.Nfe.PL_006u.EnviNFe.TEnviNFe enviNFe = new PL_006u.EnviNFe.TEnviNFe();
                        enviNFe.versao = schemaEnvio;
                        enviNFe.idLote = this.idLote ?? this.NFe.infNFe.ide.nNF;

                        XmlDocument lote = enviNFe.ToXmlDocument();
                        XmlDocument xmlNFe = this.Assinar("infNFe", this.NFe.ToXmlString(), certificado);

                        XmlNode node = lote.ImportNode(xmlNFe.DocumentElement, true);
                        lote.DocumentElement.AppendChild(node);

                        lote.PreserveWhitespace = true;

                        lote.Save(GetFile(idLote + "-env-lot.xml"));
                        xmlNFe.Save(GetFile(this.NFe.infNFe.Id.Substring(3) + "-NFe.xml"));

                        XmlNode n = ws.nfeRecepcaoLote2(lote);
                        if (n == null)
                        {
                            throw new Exception("Falha na obtenção do arquivo de retorno.");
                        }
                        else
                        {
                            Reyx.Nfe.PL_006u.RetEnviNFe.TRetEnviNFe retEnviNFe = n.OuterXml.ToXmlClass<Reyx.Nfe.PL_006u.RetEnviNFe.TRetEnviNFe>();

                            if (retEnviNFe.cStat == "103")
                            {
                                retEnviNFe.Save(GetFile(retEnviNFe.infRec.nRec + "-pro-rec.xml"));
                                mensagens.Add(retEnviNFe.cStat + "," + retEnviNFe.xMotivo);
                                return retEnviNFe.infRec.nRec;
                            }
                            else
                            {
                                retEnviNFe.Save(GetFile(this.chaveNFe + "-pro-rec.xml"));
                                erros.Add(retEnviNFe.cStat + "," + retEnviNFe.xMotivo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                erros.Add("-- Erro ao enviar a nota fiscal --");
                AddException(ex, true);
            }

            return "";
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="arquivo"></param>
        /// <param name="xJust"></param>
        /// <returns></returns>
        public string Cancelar(string arquivo, string xJust)
        {
            try
            {
                this.erros = new List<string>();
                this.mensagens = new List<string>();

                if (certificado == null) erros.Add("Certificado não localizado.");

                this.procNFe = Reyx.Nfe.XmlParser.Xml.Load<Reyx.Nfe.PL_006u.TNfeProc>(arquivo);
                if (this.procNFe == null) erros.Add("Arquivo informado inválido.");

                if (SemErros())
                {
                    ObterWebService("NfeCancelamento", this.procNFe.NFe.infNFe.emit.enderEmit.UF.Name(), this.procNFe.NFe.infNFe.ide.tpAmb.Name());

                    if (SemErros())
                    {
                        using (NfeCancelamento2 ws = new NfeCancelamento2(webService))
                        {
                            ws.nfeCabecMsgValue = new WebService.Cancelamento.nfeCabecMsg()
                            {
                                cUF = this.procNFe.NFe.infNFe.ide.cUF.Name(),
                                versaoDados = schemaCancelamento
                            };
                            ws.SoapVersion = SoapProtocolVersion.Soap12;

                            ws.ClientCertificates.Add(certificado);
                            Reyx.Nfe.PL_006u.CancNFe.TCancNFe cancNFe = new Reyx.Nfe.PL_006u.CancNFe.TCancNFe()
                            {
                                versao = schemaCancelamento,
                                infCanc = new PL_006u.CancNFe.TCancNFeInfCanc()
                                {
                                    Id = "ID" + this.procNFe.NFe.infNFe.Id.Substring(3),
                                    tpAmb = (PL_006u.CancNFe.TAmb)this.procNFe.NFe.infNFe.ide.tpAmb,
                                    xServ = PL_006u.CancNFe.TCancNFeInfCancXServ.CANCELAR,
                                    chNFe = this.procNFe.NFe.infNFe.Id.Substring(3),
                                    nProt = this.procNFe.protNFe.infProt.nProt,
                                    xJust = xJust
                                }
                            };

                            XmlDocument xml = Assinar("infCanc", cancNFe.ToXmlString(), certificado);
                            xml.Save(GetFile(cancNFe.infCanc.chNFe + "-ped-can.xml"));

                            XmlNode n = ws.nfeCancelamentoNF2(xml);
                            if (n == null)
                            {
                                throw new Exception("Falha na obtenção do arquivo de retorno.");
                            }
                            else
                            {
                                Reyx.Nfe.PL_006u.RetCancNFe.TRetCancNFe retCancNFe = n.OuterXml.ToXmlClass<Reyx.Nfe.PL_006u.RetCancNFe.TRetCancNFe>();

                                retCancNFe.Save(GetFile(cancNFe.infCanc.chNFe + "-can.xml"));

                                if (retCancNFe.infCanc != null)
                                {
                                    if (retCancNFe.infCanc.cStat == "101")
                                    {
                                        mensagens.Add(retCancNFe.infCanc.cStat + "," + retCancNFe.infCanc.xMotivo);
                                        return "0";
                                    }
                                    else
                                    {
                                        erros.Add(retCancNFe.infCanc.cStat + "," + retCancNFe.infCanc.xMotivo);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao cancelar a nota --");
                AddException(ex);
            }

            return "1";
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="arquivo"></param>
        /// <param name="idLote"></param>
        /// <param name="xJust"></param>
        /// <param name="dhEvento"></param>
        /// <returns></returns>
        public string CancelarEvento(string arquivo, string idLote, string xJust, string dhEvento)
        {
            try
            {
                this.erros = new List<string>();
                this.mensagens = new List<string>();

                if (certificado == null) erros.Add("Certificado não localizado.");

                this.procNFe = Reyx.Nfe.XmlParser.Xml.Load<Reyx.Nfe.PL_006u.TNfeProc>(arquivo);
                if (this.procNFe == null) erros.Add("Arquivo informado inválido.");

                if (SemErros())
                {
                    ObterWebService("RecepcaoEvento", this.procNFe.NFe.infNFe.emit.enderEmit.UF.Name(), this.procNFe.NFe.infNFe.ide.tpAmb.Name());

                    if (SemErros())
                    {
                        using (RecepcaoEvento ws = new RecepcaoEvento(webService))
                        {
                            ws.nfeCabecMsgValue = new Reyx.Nfe.WebService.RecepcaoEvento.nfeCabecMsg()
                            {
                                cUF = this.procNFe.NFe.infNFe.ide.cUF.Name(),
                                versaoDados = schemaCancelamentoEvento
                            };
                            ws.SoapVersion = SoapProtocolVersion.Soap12;

                            ws.ClientCertificates.Add(certificado);
                            Reyx.Nfe.Evento_Canc_PL.EnvEventoCancNFe.TEnvEvento evtCancNFe = new Evento_Canc_PL.EnvEventoCancNFe.TEnvEvento()
                            {
                                versao = schemaCancelamentoEvento,
                                idLote = idLote,
                                evento = new List<Evento_Canc_PL.EnvEventoCancNFe.TEvento>()
                            };

                            evtCancNFe.evento.Add(new Evento_Canc_PL.EnvEventoCancNFe.TEvento()
                            {
                                versao = schemaCancelamentoEvento,
                                infEvento = new Evento_Canc_PL.EnvEventoCancNFe.TEventoInfEvento()
                                {
                                    chNFe = procNFe.protNFe.infProt.chNFe,
                                    Item = procNFe.NFe.infNFe.emit.Item,
                                    ItemElementName = (Evento_Canc_PL.EnvEventoCancNFe.ItemChoiceType)procNFe.NFe.infNFe.emit.ItemElementName,
                                    cOrgao = (Evento_Canc_PL.EnvEventoCancNFe.TCOrgaoIBGE)procNFe.NFe.infNFe.ide.cUF,
                                    dhEvento = DateTime.Now.ToString("yyyy-MM-ddThh:mm:sszzz"),
                                    Id = "ID110111" + procNFe.protNFe.infProt.chNFe + "1",
                                    nSeqEvento = "1",
                                    tpAmb = (Evento_Canc_PL.EnvEventoCancNFe.TAmb)procNFe.protNFe.infProt.tpAmb,
                                    tpEvento = Evento_Canc_PL.EnvEventoCancNFe.TEventoInfEventoTpEvento.Item110111,
                                    verEvento = Evento_Canc_PL.EnvEventoCancNFe.TEventoInfEventoVerEvento.Item100,
                                    detEvento = new Evento_Canc_PL.EnvEventoCancNFe.TEventoInfEventoDetEvento()
                                    {
                                        versao = Evento_Canc_PL.EnvEventoCancNFe.TEventoInfEventoDetEventoVersao.Item100,
                                        descEvento = Evento_Canc_PL.EnvEventoCancNFe.TEventoInfEventoDetEventoDescEvento.Cancelamento,
                                        nProt = procNFe.protNFe.infProt.nProt,
                                        xJust = xJust
                                    }
                                }
                            });

                            XmlDocument xml = Assinar("infEvento", evtCancNFe.ToXmlString(), certificado);
                            xml.Save(GetFile(procNFe.protNFe.infProt.chNFe + "-ped-correcao.xml"));

                            XmlNode n = ws.nfeRecepcaoEvento(xml);
                            if (n == null)
                            {
                                throw new Exception("Falha na obtenção do arquivo de retorno.");
                            }
                            else
                            {
                                Reyx.Nfe.Evento_Canc_PL.RetEnvEventoCancNFe.TRetEnvEvento retEnvEvento = n.OuterXml.ToXmlClass<Reyx.Nfe.Evento_Canc_PL.RetEnvEventoCancNFe.TRetEnvEvento>();

                                retEnvEvento.Save(GetFile(procNFe.protNFe.infProt.chNFe + "-canc-evento.xml"));

                                if (retEnvEvento.cStat == "135")
                                {
                                    mensagens.Add(retEnvEvento.cStat + "," + retEnvEvento.xMotivo);
                                    return "0";
                                }
                                else
                                {
                                    erros.Add(retEnvEvento.cStat + "," + retEnvEvento.xMotivo);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao cancelar a nota por evento --");
                AddException(ex);
            }

            return "1";
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pasta"></param>
        /// <param name="tpAmb"></param>
        /// <param name="inicial"></param>
        /// <param name="final"></param>
        /// <param name="serie"></param>
        /// <param name="xJust"></param>
        /// <param name="UF"></param>
        /// <param name="cUF"></param>
        /// <param name="ano"></param>
        /// <param name="cnpj"></param>
        /// <returns></returns>
        public string Inutilizar(string pasta, string tpAmb, string inicial, string final, string serie, string xJust, string UF, string cUF, string ano, string cnpj)
        {
            try
            {
                this.pasta = pasta;

                this.erros = new List<string>();
                this.mensagens = new List<string>();

                if (certificado == null)
                {
                    erros.Add("Certificado não localziado.");
                }

                ObterWebService("NfeInutilizacao", UF, tpAmb);

                if (SemErros())
                {
                    using (NfeInutilizacao2 ws = new NfeInutilizacao2(webService))
                    {
                        ws.nfeCabecMsgValue = new WebService.Inutilizacao.nfeCabecMsg()
                        {
                            cUF = cUF,
                            versaoDados = schemaInutilização
                        };
                        ws.SoapVersion = SoapProtocolVersion.Soap12;

                        ws.ClientCertificates.Add(certificado);

                        string id = string.Concat(cUF, ano, cnpj, "55", serie.PadLeft(3, '0'), inicial.PadLeft(9, '0'), final.PadLeft(9, '0'));

                        Reyx.Nfe.PL_006u.InutNFe.TInutNFe inutNFe = new Reyx.Nfe.PL_006u.InutNFe.TInutNFe()
                        {
                            versao = schemaInutilização,
                            infInut = new PL_006u.InutNFe.TInutNFeInfInut()
                            {
                                Id = "ID" + id,
                                tpAmb = tpAmb.ToEnum<PL_006u.InutNFe.TAmb>(),
                                xServ = PL_006u.InutNFe.TInutNFeInfInutXServ.INUTILIZAR,
                                cUF = cUF.ToEnum<PL_006u.InutNFe.TCodUfIBGE>(),
                                ano = ano,
                                CNPJ = cnpj,
                                mod = PL_006u.InutNFe.TMod.Item55,
                                serie = serie,
                                nNFIni = inicial,
                                nNFFin = final,
                                xJust = xJust
                            }
                        };

                        XmlDocument xml = Assinar("infInut", inutNFe.ToXmlDocument().ToXmlString(), certificado);
                        xml.PreserveWhitespace = false;
                        xml.Save(GetFile(id + "-ped-inu.xml"));

                        XmlNode n = ws.nfeInutilizacaoNF2(xml);
                        if (n == null)
                        {
                            throw new Exception("Falha na obtenção do arquivo de retorno.");
                        }
                        else
                        {
                            Reyx.Nfe.PL_006u.RetInutNFe.TRetInutNFe retInutNFe = n.OuterXml.ToXmlClass<Reyx.Nfe.PL_006u.RetInutNFe.TRetInutNFe>();

                            retInutNFe.Save(GetFile(id + "-inu.xml"));

                            if (retInutNFe.infInut.cStat == "102")
                            {
                                mensagens.Add(String.Format("{0}, {1}", retInutNFe.infInut.cStat, retInutNFe.infInut.xMotivo));
                                return "0";
                            }
                            else
                            {
                                erros.Add(String.Format("{0}, {1}", retInutNFe.infInut.cStat, retInutNFe.infInut.xMotivo));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao inutilizar a(s) nota(s) --");
                AddException(ex);
            }

            return "1";
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="arquivo"></param>
        /// <param name="idLote"></param>
        /// <param name="xCorrecao"></param>
        /// <param name="dhEvento"></param>
        /// <param name="xCondUso"></param>
        /// <returns></returns>
        public string Corrigir(string arquivo, string idLote, string xCorrecao, string dhEvento, string xCondUso)
        {
            try
            {
                this.erros = new List<string>();
                this.mensagens = new List<string>();

                if (certificado == null) erros.Add("Certificado não localizado.");

                this.procNFe = Reyx.Nfe.XmlParser.Xml.Load<Reyx.Nfe.PL_006u.TNfeProc>(arquivo);
                if (this.procNFe == null) erros.Add("Arquivo informado inválido.");

                if (SemErros())
                {
                    ObterWebService("RecepcaoEvento", this.procNFe.NFe.infNFe.emit.enderEmit.UF.Name(), this.procNFe.NFe.infNFe.ide.tpAmb.Name());

                    if (SemErros())
                    {
                        using (RecepcaoEvento ws = new RecepcaoEvento(webService))
                        {
                            ws.nfeCabecMsgValue = new Reyx.Nfe.WebService.RecepcaoEvento.nfeCabecMsg()
                            {
                                cUF = this.procNFe.NFe.infNFe.ide.cUF.Name(),
                                versaoDados = schemaCorrecao
                            };
                            ws.SoapVersion = SoapProtocolVersion.Soap12;

                            ws.ClientCertificates.Add(certificado);
                            Reyx.Nfe.CCe_v100a.EnvCCe.TEnvEvento envCCe = new CCe_v100a.EnvCCe.TEnvEvento()
                            {
                                versao = schemaCorrecao,
                                idLote = idLote,
                                evento = new List<CCe_v100a.EnvCCe.TEvento>()
                            };

                            envCCe.evento.Add(new CCe_v100a.EnvCCe.TEvento()
                            {
                                versao = schemaCorrecao,
                                infEvento = new CCe_v100a.EnvCCe.TEventoInfEvento()
                                {
                                    chNFe = procNFe.protNFe.infProt.chNFe,
                                    ItemElementName = (CCe_v100a.EnvCCe.ItemChoiceType)procNFe.NFe.infNFe.emit.ItemElementName,
                                    Item = procNFe.NFe.infNFe.emit.Item,
                                    cOrgao = (CCe_v100a.EnvCCe.TCOrgaoIBGE)procNFe.NFe.infNFe.ide.cUF,
                                    detEvento = new CCe_v100a.EnvCCe.TEventoInfEventoDetEvento()
                                    {
                                        descEvento = CCe_v100a.EnvCCe.TEventoInfEventoDetEventoDescEvento.CartadeCorrecao,
                                        versao = CCe_v100a.EnvCCe.TEventoInfEventoDetEventoVersao.Item100,
                                        xCorrecao = xCorrecao,
                                        xCondUso = CCe_v100a.EnvCCe.TEventoInfEventoDetEventoXCondUso.ACartadeCorrecaoedisciplinadapeloparagrafo1oAdoart7odoConvenioSNde15dedezembrode1970epodeserutilizadapararegularizacaodeerroocorridonaemissaodedocumentofiscaldesdequeoerronaoestejarelacionadocomIasvariaveisquedeterminamovalordoimpostotaiscomobasedecalculoaliquotadiferencadeprecoquantidadevalordaoperacaooudaprestacaoIIacorrecaodedadoscadastraisqueimpliquemudancadoremetenteoudodestinatarioIIIadatadeemissaooudesaida
                                    },
                                    dhEvento = DateTime.Now.ToString("yyyy-MM-ddThh:mm:sszzz"),
                                    Id = "ID110110" + procNFe.protNFe.infProt.chNFe + "1",
                                    nSeqEvento = "1",
                                    tpAmb = (CCe_v100a.EnvCCe.TAmb)procNFe.protNFe.infProt.tpAmb,
                                    tpEvento = CCe_v100a.EnvCCe.TEventoInfEventoTpEvento.Item110110,
                                    verEvento = CCe_v100a.EnvCCe.TEventoInfEventoVerEvento.Item100
                                }
                            });

                            XmlDocument xml = Assinar("infEvento", envCCe.ToXmlString(), certificado);
                            xml.Save(GetFile(procNFe.protNFe.infProt.chNFe + "-ped-correcao.xml"));

                            XmlNode n = ws.nfeRecepcaoEvento(xml);
                            if (n == null)
                            {
                                throw new Exception("Falha na obtenção do arquivo de retorno.");
                            }
                            else
                            {
                                Reyx.Nfe.CCe_v100a.RetEnvCCe.TRetEnvEvento retEnvCCe = n.OuterXml.ToXmlClass<Reyx.Nfe.CCe_v100a.RetEnvCCe.TRetEnvEvento>();

                                retEnvCCe.Save(GetFile(procNFe.protNFe.infProt.chNFe + "-correcao.xml"));

                                if (retEnvCCe.cStat == "135")
                                {
                                    mensagens.Add(retEnvCCe.cStat + "," + retEnvCCe.xMotivo);
                                    return "0";
                                }
                                else
                                {
                                    erros.Add(retEnvCCe.cStat + "," + retEnvCCe.xMotivo);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao cancelar a nota --");
                AddException(ex);
            }

            return "1";
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="serial"></param>
        /// <param name="arquivo"></param>
        /// <param name="nRec"></param>
        /// <returns></returns>
        public string ConsultarSituacaoAtual(string serial, string arquivo, string nRec)
        {
            try
            {
                this.erros = new List<string>();
                this.mensagens = new List<string>();

                if (certificado == null)
                    InstanciarCertificado(serial);

                this.NFe = Reyx.Nfe.XmlParser.Xml.Load<Reyx.Nfe.PL_006u.TNFe>(arquivo);

                ObterWebService("NfeRetRecepcao", this.NFe.infNFe.emit.enderEmit.UF.Name(), this.NFe.infNFe.ide.tpAmb.Name());

                if (SemErros())
                {
                    using (NfeRetRecepcao2 ws = new NfeRetRecepcao2(webService))
                    {
                        ws.nfeCabecMsgValue = new WebService.RetRecepcao.nfeCabecMsg()
                        {
                            cUF = this.NFe.infNFe.ide.cUF.Name(),
                            versaoDados = schemaRecibo
                        };
                        ws.SoapVersion = SoapProtocolVersion.Soap12;
                        ws.ClientCertificates.Add(certificado);

                        Reyx.Nfe.PL_006u.ConsReciNFe.TConsReciNFe consReciNFe = new Reyx.Nfe.PL_006u.ConsReciNFe.TConsReciNFe()
                        {
                            versao = schemaRecibo,
                            nRec = nRec,
                            tpAmb = (PL_006u.ConsReciNFe.TAmb)this.NFe.infNFe.ide.tpAmb
                        };

                        consReciNFe.Save(GetFile(this.NFe.infNFe.Id.Substring(3) + "-ped-rec.xml"));

                        XmlDocument xml = consReciNFe.ToXmlDocument();

                        XmlNode n = ws.nfeRetRecepcao2(xml);
                        if (n == null)
                        {
                            throw new Exception("Falha na obtenção do arquivo de retorno.");
                        }
                        else
                        {
                            Reyx.Nfe.PL_006u.RetConsReciNFe.TRetConsReciNFe retConsReciNFe = n.OuterXml.ToXmlClass<Reyx.Nfe.PL_006u.RetConsReciNFe.TRetConsReciNFe>();

                            if (retConsReciNFe == null)
                            {
                                erros.Add("Retorno Inválido");
                            }
                            else
                            {
                                retConsReciNFe.Save(GetFile(nRec + "-pro-rec.xml"));

                                if (retConsReciNFe.cStat == "104")
                                {
                                    if (retConsReciNFe.protNFe != null && retConsReciNFe.protNFe.Any())
                                    {
                                        var protNFe = retConsReciNFe.protNFe.FirstOrDefault();

                                        if (protNFe.infProt.cStat == "100")
                                        {
                                            this.procNFe = new Reyx.Nfe.PL_006u.TNfeProc();
                                            this.procNFe.versao = schemaRecibo;
                                            this.procNFe.protNFe = new PL_006u.TProtNFe()
                                            {
                                                infProt = new PL_006u.TProtNFeInfProt()
                                                {
                                                    chNFe = protNFe.infProt.chNFe,
                                                    cStat = protNFe.infProt.cStat,
                                                    dhRecbto = protNFe.infProt.dhRecbto,
                                                    digVal = protNFe.infProt.digVal,
                                                    Id = protNFe.infProt.Id,
                                                    nProt = protNFe.infProt.nProt,
                                                    tpAmb = (PL_006u.TAmb)protNFe.infProt.tpAmb,
                                                    verAplic = protNFe.infProt.verAplic,
                                                    xMotivo = protNFe.infProt.xMotivo
                                                },
                                                Signature = new PL_006u.SignatureType()
                                                {
                                                    Id = protNFe.Signature.Id,
                                                    KeyInfo = new PL_006u.KeyInfoType()
                                                    {
                                                        Id = protNFe.Signature.KeyInfo.Id,
                                                        X509Data = new PL_006u.X509DataType()
                                                        {
                                                            X509Certificate = protNFe.Signature.KeyInfo.X509Data.X509Certificate
                                                        }
                                                    },
                                                    SignatureValue = new PL_006u.SignatureValueType()
                                                    {
                                                        Id = protNFe.Signature.SignatureValue.Id,
                                                        Value = protNFe.Signature.SignatureValue.Value
                                                    },
                                                    SignedInfo = new PL_006u.SignedInfoType()
                                                    {
                                                        CanonicalizationMethod = new PL_006u.SignedInfoTypeCanonicalizationMethod()
                                                        {
                                                            Algorithm = protNFe.Signature.SignedInfo.CanonicalizationMethod.Algorithm
                                                        },
                                                        Id = protNFe.Signature.SignedInfo.Id,
                                                        Reference = new PL_006u.ReferenceType()
                                                        {
                                                            DigestMethod = new PL_006u.ReferenceTypeDigestMethod()
                                                            {
                                                                Algorithm = protNFe.Signature.SignedInfo.Reference.DigestMethod.Algorithm
                                                            },
                                                            DigestValue = protNFe.Signature.SignedInfo.Reference.DigestValue,
                                                            Id = protNFe.Signature.SignedInfo.Reference.Id,
                                                            Type = protNFe.Signature.SignedInfo.Reference.Type,
                                                            URI = protNFe.Signature.SignedInfo.Reference.URI
                                                        },
                                                        SignatureMethod = new PL_006u.SignedInfoTypeSignatureMethod()
                                                        {
                                                            Algorithm = protNFe.Signature.SignedInfo.SignatureMethod.Algorithm
                                                        }
                                                    }
                                                },
                                                versao = protNFe.versao
                                            };

                                            foreach (var transform in protNFe.Signature.SignedInfo.Reference.Transforms)
                                            {
                                                this.procNFe.protNFe.Signature.SignedInfo.Reference.Transforms.Add(new PL_006u.TransformType()
                                                {
                                                    Algorithm = (PL_006u.TTransformURI)transform.Algorithm,
                                                    XPath = transform.XPath
                                                });
                                            }

                                            XmlDocument xmlNFe = new XmlDocument();
                                            xmlNFe.Load(arquivo);
                                            XmlDocument xmlProc = this.procNFe.ToXmlDocument();

                                            XmlNode node = xmlProc.ImportNode(xmlNFe.DocumentElement, true);
                                            xmlProc.DocumentElement.PrependChild(node);
                                            xmlProc.PreserveWhitespace = true;

                                            xmlProc.Save(GetFile(this.NFe.infNFe.Id.Substring(3) + "-procNFe.xml"));

                                            mensagens.Add(retConsReciNFe.cStat + "," + protNFe.infProt.xMotivo);
                                            return "0";
                                        }
                                        else
                                        {
                                            erros.Add(retConsReciNFe.cStat + "," + protNFe.infProt.xMotivo);
                                        }
                                    }
                                    else
                                    {
                                        erros.Add(retConsReciNFe.cStat + "," + retConsReciNFe.xMotivo);
                                    }
                                }
                                else
                                {
                                    erros.Add(retConsReciNFe.cStat + "," + retConsReciNFe.xMotivo);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                erros.Add("-- Erro ao validar situação da nota fiscal na receita federal --");
                AddException(ex);
            }

            return "1";
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="serial"></param>
        /// <param name="arquivo"></param>
        /// <returns></returns>
        public string Consultar(string serial, string arquivo)
        {
            try
            {
                this.erros = new List<string>();
                this.mensagens = new List<string>();

                if (certificado == null)
                    InstanciarCertificado(serial);

                this.NFe = Reyx.Nfe.XmlParser.Xml.Load<Reyx.Nfe.PL_006u.TNFe>(arquivo);

                ObterWebService("NfeConsultaProtocolo", this.NFe.infNFe.emit.enderEmit.UF.Name(), this.NFe.infNFe.ide.tpAmb.Name());

                if (SemErros())
                {
                    using (NfeConsulta2 ws = new NfeConsulta2(webService))
                    {
                        ws.nfeCabecMsgValue = new WebService.Consulta.nfeCabecMsg()
                        {
                            cUF = this.NFe.infNFe.ide.cUF.Name(),
                            versaoDados = schemaConsulta
                        };
                        ws.SoapVersion = SoapProtocolVersion.Soap12;
                        ws.ClientCertificates.Add(certificado);

                        Reyx.Nfe.PL_006u.ConsSitNFe.TConsSitNFe consSitNFe = new Reyx.Nfe.PL_006u.ConsSitNFe.TConsSitNFe()
                        {
                            versao = PL_006u.ConsSitNFe.TVerConsSitNFe.Item201,
                            chNFe = this.NFe.infNFe.Id.Substring(3),
                            tpAmb = (PL_006u.ConsSitNFe.TAmb)this.NFe.infNFe.ide.tpAmb,
                            xServ = PL_006u.ConsSitNFe.TConsSitNFeXServ.CONSULTAR
                        };

                        consSitNFe.Save(this.NFe.infNFe.Id.Substring(3) + "-ped-sit.xml");

                        XmlNode n = ws.nfeConsultaNF2(consSitNFe.ToXmlDocument());
                        if (n == null)
                        {
                            throw new Exception("Falha na obtenção do arquivo de retorno.");
                        }
                        else
                        {
                            Reyx.Nfe.PL_006u.RetConsSitNFe.TRetConsSitNFe retConsSitNFe = n.OuterXml.ToXmlClass<Reyx.Nfe.PL_006u.RetConsSitNFe.TRetConsSitNFe>();

                            retConsSitNFe.Save(GetFile(this.NFe.infNFe.Id.Substring(3) + "-sit.xml"));

                            if (retConsSitNFe.cStat == "100")
                            {
                                var protNFe = retConsSitNFe.protNFe;

                                this.procNFe = new Reyx.Nfe.PL_006u.TNfeProc();
                                this.procNFe.versao = schemaConsulta;
                                this.procNFe.protNFe = new PL_006u.TProtNFe()
                                {
                                    infProt = new PL_006u.TProtNFeInfProt()
                                    {
                                        chNFe = protNFe.infProt.chNFe,
                                        cStat = protNFe.infProt.cStat,
                                        dhRecbto = protNFe.infProt.dhRecbto,
                                        digVal = protNFe.infProt.digVal,
                                        Id = protNFe.infProt.Id,
                                        nProt = protNFe.infProt.nProt,
                                        tpAmb = (PL_006u.TAmb)protNFe.infProt.tpAmb,
                                        verAplic = protNFe.infProt.verAplic,
                                        xMotivo = protNFe.infProt.xMotivo
                                    },
                                    Signature = new PL_006u.SignatureType()
                                    {
                                        Id = protNFe.Signature.Id,
                                        KeyInfo = new PL_006u.KeyInfoType()
                                        {
                                            Id = protNFe.Signature.KeyInfo.Id,
                                            X509Data = new PL_006u.X509DataType()
                                            {
                                                X509Certificate = protNFe.Signature.KeyInfo.X509Data.X509Certificate
                                            }
                                        },
                                        SignatureValue = new PL_006u.SignatureValueType()
                                        {
                                            Id = protNFe.Signature.SignatureValue.Id,
                                            Value = protNFe.Signature.SignatureValue.Value
                                        },
                                        SignedInfo = new PL_006u.SignedInfoType()
                                        {
                                            CanonicalizationMethod = new PL_006u.SignedInfoTypeCanonicalizationMethod()
                                            {
                                                Algorithm = protNFe.Signature.SignedInfo.CanonicalizationMethod.Algorithm
                                            },
                                            Id = protNFe.Signature.SignedInfo.Id,
                                            Reference = new PL_006u.ReferenceType()
                                            {
                                                DigestMethod = new PL_006u.ReferenceTypeDigestMethod()
                                                {
                                                    Algorithm = protNFe.Signature.SignedInfo.Reference.DigestMethod.Algorithm
                                                },
                                                DigestValue = protNFe.Signature.SignedInfo.Reference.DigestValue,
                                                Id = protNFe.Signature.SignedInfo.Reference.Id,
                                                Type = protNFe.Signature.SignedInfo.Reference.Type,
                                                URI = protNFe.Signature.SignedInfo.Reference.URI
                                            },
                                            SignatureMethod = new PL_006u.SignedInfoTypeSignatureMethod()
                                            {
                                                Algorithm = protNFe.Signature.SignedInfo.SignatureMethod.Algorithm
                                            }
                                        }
                                    },
                                    versao = retConsSitNFe.protNFe.versao
                                };

                                foreach (var transform in protNFe.Signature.SignedInfo.Reference.Transforms)
                                {
                                    this.procNFe.protNFe.Signature.SignedInfo.Reference.Transforms.Add(new PL_006u.TransformType()
                                    {
                                        Algorithm = (PL_006u.TTransformURI)transform.Algorithm,
                                        XPath = transform.XPath
                                    });
                                }

                                XmlDocument xmlNFe = this.Assinar("infNFe", this.NFe.ToXmlString(), certificado);
                                XmlDocument xmlProc = this.procNFe.ToXmlDocument();

                                XmlNode node = xmlProc.ImportNode(xmlNFe.DocumentElement, true);
                                xmlProc.DocumentElement.PrependChild(node);
                                xmlProc.PreserveWhitespace = true;

                                xmlProc.Save(GetFile(this.NFe.infNFe.Id.Substring(3) + "-procNFe.xml"));

                                mensagens.Add(retConsSitNFe.cStat + "," + retConsSitNFe.xMotivo);
                                return "0";
                            }
                            else
                            {
                                erros.Add(retConsSitNFe.cStat + "," + retConsSitNFe.xMotivo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                erros.Add("-- Erro ao consultar a nota fiscal --");
                AddException(ex);
            }

            return "1";
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="arquivo"></param>
        /// <param name="logo"></param>
        /// <returns></returns>
        public string Danfe(string arquivo, string logo)
        {
            try
            {
                this.erros = new List<string>();
                this.mensagens = new List<string>();

                XmlDocument xml = new XmlDocument();
                xml.Load(arquivo);

                if (VerifyXml(xml))
                {
                    string resultado = new Relatorio(pasta, arquivo, logo).Run();

                    if (string.IsNullOrWhiteSpace(resultado))
                    {
                        return "0";
                    }
                    else
                    {
                        erros.Add(resultado);
                    }
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao gerar o Danfe --");
                AddException(ex);
            }

            return "1";
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public string GerarChave()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.chaveNFe))
                {
                    List<Int32> mm = new List<Int32>();
                    string digito = "0";

                    if (this.NFe.infNFe.ide == null) erros.Add("Identificação da NFe não localizada.");
                    if (this.NFe.infNFe.emit == null) erros.Add("Emitente não localizado.");

                    if (string.IsNullOrWhiteSpace(this.NFe.infNFe.ide.cNF))
                    {
                        this.NFe.infNFe.ide.cNF = string.Format("{0:ddHHmmss}", DateTime.Now);
                    }

                    if (String.IsNullOrWhiteSpace(this.NFe.infNFe.ide.dEmi)) erros.Add("Data de emissão não informada.");
                    if (String.IsNullOrWhiteSpace(this.NFe.infNFe.ide.mod.Name())) erros.Add("Modelo não informado.");
                    if (String.IsNullOrWhiteSpace(this.NFe.infNFe.ide.nNF)) erros.Add("Número da NF não informado.");
                    if (String.IsNullOrWhiteSpace(this.NFe.infNFe.ide.tpEmis.Name())) erros.Add("Tipo de Emissão de informado.");
                    if (String.IsNullOrWhiteSpace(this.NFe.infNFe.ide.cNF)) erros.Add("Chave da NF inválida.");

                    string documento = this.NFe.infNFe.emit.Item;
                    string ibgeCli = this.NFe.infNFe.ide.cUF.Name();

                    if (String.IsNullOrWhiteSpace(documento)) erros.Add("Documento do emitente não localizado para fornecer a chave.");
                    if (String.IsNullOrWhiteSpace(ibgeCli)) erros.Add("Código IBGE do cliente não localizado.");

                    if (SemErros())
                    {
                        this.chaveNFe = String.Format(
                            "{0}{1}{2}{3}{4}{5}{6}{7}{8}",
                            ibgeCli,
                            this.NFe.infNFe.ide.dEmi.Substring(2, 2),
                            this.NFe.infNFe.ide.dEmi.Substring(5, 2),
                            documento,
                            this.NFe.infNFe.ide.mod,
                            this.NFe.infNFe.ide.serie.PadLeft(3, '0'),
                            this.NFe.infNFe.ide.nNF.PadLeft(9, '0'),
                            this.NFe.infNFe.ide.tpEmis,
                            this.NFe.infNFe.ide.cNF
                        );

                        if (this.chaveNFe == null || this.chaveNFe.Length != 43)
                        {
                            this.erros.Add("Tamanho da chave inválido.");
                        }

                        if (SemErros())
                        {
                            Char[] v = this.chaveNFe.ToCharArray(),
                                   m = "4329876543298765432987654329876543298765432".ToCharArray();

                            for (Int32 i = 0; i < m.Length; i++)
                                mm.Add(Int32.Parse(m[i].ToString()) * Int32.Parse(v[i].ToString()));

                            Int32 ponderacao = mm.Sum() % 11;

                            if (ponderacao != 0 && ponderacao != 1)
                                digito = (11 - ponderacao).ToString();

                            this.NFe.infNFe.Id = "NFe" + this.chaveNFe + digito;
                            this.NFe.infNFe.ide.cDV = digito;

                            this.NFe.infNFe.Id = "NFe" + this.chaveNFe + digito;

                            return this.chaveNFe + digito;
                        }
                    }
                }

                return this.NFe.infNFe.Id.Substring(3);
            }
            catch (Exception ex)
            {
                erros.Add("-- Erro ao obter a chave --");
                AddException(ex);
            }

            return "";
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="serial"></param>
        /// <returns></returns>
        public string InstanciarCertificado(string serial)
        {
            this.erros = new List<string>();

            try
            {
                if (string.IsNullOrWhiteSpace(serial))
                {
                    certificado = new Certificado().Localizar();
                }
                else
                {
                    certificado = new Certificado().Localizar("", serial);
                }

                if (this.certificado == null)
                {
                    erros.Add("Certificado não localizado.");
                }
                else
                {
                    return certificado.GetSerialNumberString();
                }
            }
            catch (Exception ex)
            {
                erros.Add("-- Erro ao instanciar certificado --");
                AddException(ex);
            }

            return "";
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pasta"></param>
        public void SetarPastaAtual(string pasta)
        {
            this.pasta = pasta;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="arquivo"></param>
        /// <returns></returns>
        public string ObterXml(string arquivo)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(arquivo);

                StringBuilder bob = new StringBuilder();

                using (StringWriter sw = new StringWriter(bob))
                using (XmlTextWriter writer = new XmlTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.Indentation = 4;
                    xml.WriteTo(writer);
                }

                return bob.ToString();
            }
            catch
            {
                erros.Add("-- Erro ao obter xml --");
            }

            return "0";
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public string Mensagens()
        {
            StringBuilder sb = new StringBuilder();

            foreach (string mensagen in this.mensagens)
            {
                sb.AppendLine(mensagen);
            }

            return sb.ToString();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public string Erros()
        {
            StringBuilder sb = new StringBuilder();

            foreach (string erro in this.erros)
            {
                sb.AppendLine(erro);
            }

            return sb.ToString();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="Doc"></param>
        /// <returns></returns>
        private Boolean VerifyXml(XmlDocument Doc)
        {
            try
            {
                SignedXml signedXml = new SignedXml(Doc);

                XmlNodeList nodeList = Doc.GetElementsByTagName("Signature");

                if (nodeList.Count < 1)
                {
                    this.erros.Add("Assinatura não localizada no documento xml.");
                }
                else if (nodeList.Count > 1)
                {
                    this.erros.Add("Foi localizado mais de uma assinatura no documento xml.");
                }
                else
                {
                    signedXml.LoadXml((XmlElement)nodeList[0]);

                    return signedXml.CheckSignature(certificado, true);
                }
            }
            catch (Exception ex)
            {
                erros.Add("-- Erro ao verificar a assinatura do documento xml --");
                erros.Add(ex.ToString());
            }

            return false;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private string GetFile(string file)
        {
            return Path.Combine(pasta, file);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="complete"></param>
        private void AddException(Exception ex, bool complete = false)
        {
            if (complete)
            {
                // MessageBox.Show(ex.ToString());
            }

            this.erros.Add(ex.Message);
            if (ex.InnerException != null)
            {
                this.erros.Add(ex.InnerException.Message);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        private bool SemErros()
        {
            return !this.erros.Any();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="erros"></param>
        private void JoinErros(List<String> erros)
        {
            Int32 count = erros.Count;
            for (int i = 0; i < count; i++)
            {
                this.erros.Add(erros[i]);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="servico"></param>
        /// <param name="UF"></param>
        /// <param name="tpAmb"></param>
        private void ObterWebService(string servico, string UF, string tpAmb)
        {
            try
            {
                XElement webservices = XElement.Load(GetFile("webservices.xml"));

                this.webService = webservices.Elements()
                               .Where(t =>
                                   t.Element("servico").Value == servico &&
                                   t.Element("UF").Value.ToLower() == UF.ToLower() &&
                                   t.Element("tpAmb").Value == tpAmb &&
                                   t.Element("versao").Value == schemaWebService)
                               .Select(t => t.Element("url").Value)
                               .FirstOrDefault() ?? webservices.Elements()
                               .Where(t =>
                                   t.Element("servico").Value == servico &&
                                   t.Element("UF").Value.ToLower() == "br" &&
                                   t.Element("tpAmb").Value == tpAmb &&
                                   t.Element("versao").Value == schemaWebService)
                               .Select(t => t.Element("url").Value)
                               .FirstOrDefault() ?? "";

                if (string.IsNullOrWhiteSpace(this.webService))
                {
                    erros.Add("WebService não localizado.");
                }
            }
            catch (FileNotFoundException ex)
            {
                erros.Add(string.Format("Arquivo '{0}' não localizado.", ex.FileName));
            }
            catch (Exception ex)
            {
                erros.Add("-- Erro ao obter o WebService --");
                AddException(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="RefUri"></param>
        /// <param name="xml"></param>
        /// <param name="certificado"></param>
        /// <returns></returns>
        private XmlDocument Assinar(String RefUri, string xml, X509Certificate2 certificado)
        {
            try
            {
                Assinatura.Digital ad = new Assinatura.Digital();

                JoinErros(ad.Assinar(xml, RefUri, certificado));

                if (this.SemErros())
                {
                    XmlDocument xd = new XmlDocument();
                    xd.LoadXml(ad.XMLStringAssinado);

                    return xd.ChangeXmlEncoding("utf-8");
                }
            }
            catch (Exception ex)
            {
                erros.Add("--- Erro ao assinar o documento --");
                AddException(ex);
            }

            return null;
        }
    }
}