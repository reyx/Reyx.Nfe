using Reyx.Nfe.XmlParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Reyx.Tester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Reyx.Nfe.PL_006u.TNFe nfe = new Nfe.PL_006u.TNFe();
            nfe.infNFe = new Nfe.PL_006u.TNFeInfNFe()
            {
                versao = "2.00",
                Id = "NFe35080599999090910270550010000000015180051273",
                ide = new Nfe.PL_006u.TNFeInfNFeIde()
                {
                    cUF = Nfe.PL_006u.TCodUfIBGE.Item35,
                    cNF = "51800512",
                    natOp = "Venda a vista",
                    indPag = Nfe.PL_006u.TNFeInfNFeIdeIndPag.Item0,
                    mod = Nfe.PL_006u.TMod.Item55,
                    serie = "1",
                    nNF = "1",
                    dEmi = "2011-11-20",
                    dSaiEnt = "2008-05-06",
                    tpNF = Nfe.PL_006u.TNFeInfNFeIdeTpNF.Item0,
                    cMunFG = "3550308",
                    tpImp = Nfe.PL_006u.TNFeInfNFeIdeTpImp.Item1,
                    tpEmis = Nfe.PL_006u.TNFeInfNFeIdeTpEmis.Item1,
                    cDV = "3",
                    tpAmb = Nfe.PL_006u.TAmb.Item2,
                    finNFe = Nfe.PL_006u.TFinNFe.Item1,
                    procEmi = Nfe.PL_006u.TProcEmi.Item0,
                    verProc = "rcky-01"
                },
                emit = new Nfe.PL_006u.TNFeInfNFeEmit()
                {
                    ItemElementName = Nfe.PL_006u.ItemChoiceType2.CNPJ,
                    Item = "99999999000191",
                    xNome = "NFe",
                    xFant = "NFe",
                    enderEmit = new Nfe.PL_006u.TEnderEmi()
                    {
                        xLgr = "Rua Central",
                        nro = "100",
                        xCpl = "Fundos",
                        xBairro = "Distrito Industrial",
                        cMun = "3502200",
                        xMun = "Angatuba",
                        UF = Nfe.PL_006u.TUfEmi.SP,
                        CEP = "17100171",
                        cPais = Nfe.PL_006u.TEnderEmiCPais.Item1058,
                        xPais = Nfe.PL_006u.TEnderEmiXPais.Brasil,
                        fone = "1733021717"
                    },
                    IE = "123456789012",
                    CRT = Nfe.PL_006u.TNFeInfNFeEmitCRT.Item3
                },
                dest = new Nfe.PL_006u.TNFeInfNFeDest()
                {
                    ItemElementName = Nfe.PL_006u.ItemChoiceType3.CNPJ,
                    Item = "00000000000191",
                    xNome = "DISTRIBUIDORA DE AGUAS MINERAIS",
                    enderDest = new Nfe.PL_006u.TEndereco()
                    {
                        xLgr = "V DAS FONTES",
                        nro = "1777",
                        xCpl = "10 Andar",
                        xBairro = "Pq Fontes",
                        cMun = "5030801",
                        xMun = "Sao Paulo",
                        UF = Nfe.PL_006u.TUf.SP,
                        CEP = "13950000",
                        cPais = Nfe.PL_006u.Tpais.Item1058,
                        xPais = "Brasil",
                        fone = "1932011234"
                    },
                    IE = ""
                },
                retirada = new Nfe.PL_006u.TLocal()
                {
                    ItemElementName = Nfe.PL_006u.ItemChoiceType4.CNPJ,
                    Item = "99171171000194",
                    xLgr = "AV PAULISTA",
                    nro = "12345",
                    xCpl = "TERREO",
                    xBairro = "CERQUEIRA CESAR",
                    cMun = "3550308",
                    xMun = "SAO PAULO",
                    UF = Nfe.PL_006u.TUf.SP
                },
                entrega = new Nfe.PL_006u.TLocal()
                {
                    ItemElementName = Nfe.PL_006u.ItemChoiceType4.CNPJ,
                    Item = "99299299000194",
                    xLgr = "AV FARIA LIMA",
                    nro = "1500",
                    xCpl = "15 ANDAR",
                    xBairro = "PINHEIROS",
                    cMun = "3550308",
                    xMun = "SAO PAULO",
                    UF = Nfe.PL_006u.TUf.SP
                },
                det = new List<Nfe.PL_006u.TNFeInfNFeDet>(),
                total = new Nfe.PL_006u.TNFeInfNFeTotal()
                {
                    ICMSTot = new Nfe.PL_006u.TNFeInfNFeTotalICMSTot()
                    {
                        vBC = "20000000.00",
                        vICMS = "18.00",
                        vBCST = "0",
                        vST = "0",
                        vProd = "20000000.00",
                        vFrete = "0",
                        vSeg = "0",
                        vDesc = "0",
                        vII = "0",
                        vIPI = "0",
                        vPIS = "130000.00",
                        vCOFINS = "400000.00",
                        vOutro = "0",
                        vNF = "20000000.00",
                        vTotTrib = "0"
                    }
                },
                transp = new Nfe.PL_006u.TNFeInfNFeTransp()
                {
                    modFrete = Nfe.PL_006u.TNFeInfNFeTranspModFrete.Item0,
                    transporta = new Nfe.PL_006u.TNFeInfNFeTranspTransporta()
                    {
                        ItemElementName = Nfe.PL_006u.ItemChoiceType5.CNPJ,
                        Item = "99171171000191",
                        xNome = "Distribuidora de Bebidas Fazenda de SP Ltda.",
                        IE = "171999999119",
                        xEnder = "Rua Central 100 - Fundos - Distrito Industrial",
                        xMun = "SAO PAULO",
                        UF = Nfe.PL_006u.TUf.SP
                    },
                    //veicTransp = new
                    //{
                    //    placa = "BXI1717",
                    //    UF = "SP",
                    //    RNTC = "123456789"
                    //},
                    //reboque = new Nfe.Schema200.Members.reboque()
                    //{
                    //    placa = "BXI1818",
                    //    UF = "SP",
                    //    RNTC = "123456789"
                    //},
                    vol = new List<Nfe.PL_006u.TNFeInfNFeTranspVol>()
                },
                infAdic = new Nfe.PL_006u.TNFeInfNFeInfAdic()
                {
                    infAdFisco = "Nota Fiscal de exemplo NF-eletronica.com"
                },
                exporta = new Nfe.PL_006u.TNFeInfNFeExporta()
                {
                    UFEmbarq = Nfe.PL_006u.TUf.SP,
                    xLocEmbarq = "Porto de Santos"
                }
            };

            nfe.infNFe.det.Add(new Nfe.PL_006u.TNFeInfNFeDet()
            {
                nItem = "1",
                prod = new Nfe.PL_006u.TNFeInfNFeDetProd()
                {
                    cProd = "00001",
                    cEAN = "",
                    xProd = "Agua Mineral",
                    NCM = "12002500",
                    CFOP = Nfe.PL_006u.TCfop.Item5101,
                    uCom = "dz",
                    qCom = "1000000.0000",
                    vUnCom = "1",
                    vProd = "10000000.00",
                    cEANTrib = "",
                    uTrib = "un",
                    qTrib = "12000000.00",
                    vUnTrib = "1",
                    indTot = Nfe.PL_006u.TNFeInfNFeDetProdIndTot.Item1
                },
                imposto = new Nfe.PL_006u.TNFeInfNFeDetImposto()
                {
                    Items = new List<object>() {
                        new Nfe.PL_006u.TNFeInfNFeDetImpostoICMS()
                        {
                            Item = new Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS00() {
                                orig = Nfe.PL_006u.Torig.Item0,
                                CST = Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS00CST.Item00,
                                modBC = Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS00ModBC.Item0,
                                vBC = "10000000.00",
                                pICMS = "18.00",
                                vICMS = "1800000.00"
                            }
                        }
                    },
                    PIS = new Nfe.PL_006u.TNFeInfNFeDetImpostoPIS()
                    {
                        Item = new Nfe.PL_006u.TNFeInfNFeDetImpostoPISPISAliq()
                        {
                            CST = Nfe.PL_006u.TNFeInfNFeDetImpostoPISPISAliqCST.Item01,
                            vBC = "100000000.00",
                            pPIS = "0.65",
                            vPIS = "65000"
                        }
                    },
                    COFINS = new Nfe.PL_006u.TNFeInfNFeDetImpostoCOFINS()
                    {
                        Item = new Nfe.PL_006u.TNFeInfNFeDetImpostoCOFINSCOFINSAliq()
                        {
                            CST = Nfe.PL_006u.TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST.Item01,
                            vBC = "100000000.00",
                            pCOFINS = "2.00",
                            vCOFINS = "200000.00"
                        }
                    },
                    vTotTrib = "0"
                }
            });

            nfe.infNFe.det.Add(new Nfe.PL_006u.TNFeInfNFeDet()
            {
                nItem = "2",
                prod = new Nfe.PL_006u.TNFeInfNFeDetProd()
                {
                    cProd = "00002",
                    cEAN = "",
                    xProd = "Agua Mineral",
                    NCM = "12002500",
                    CFOP = Nfe.PL_006u.TCfop.Item5101,
                    uCom = "pack",
                    qCom = "5000000.0000",
                    vUnCom = "2",
                    vProd = "10000000.00",
                    cEANTrib = "",
                    uTrib = "un",
                    qTrib = "3000000.00",
                    vUnTrib = "0.3333",
                    indTot = Nfe.PL_006u.TNFeInfNFeDetProdIndTot.Item1
                },
                imposto = new Nfe.PL_006u.TNFeInfNFeDetImposto()
                {
                    Items = new List<object>() {
                        new Nfe.PL_006u.TNFeInfNFeDetImpostoICMS()
                        {
                            Item = new Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS00() {
                                orig = Nfe.PL_006u.Torig.Item0,
                                CST = Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS00CST.Item00,
                                modBC = Nfe.PL_006u.TNFeInfNFeDetImpostoICMSICMS00ModBC.Item0,
                                vBC = "10000000.00",
                                pICMS = "18.00",
                                vICMS = "1800000.00"
                            }
                        }
                    },
                    PIS = new Nfe.PL_006u.TNFeInfNFeDetImpostoPIS()
                    {
                        Item = new Nfe.PL_006u.TNFeInfNFeDetImpostoPISPISAliq()
                        {
                            CST = Nfe.PL_006u.TNFeInfNFeDetImpostoPISPISAliqCST.Item01,
                            vBC = "100000000.00",
                            pPIS = "0.65",
                            vPIS = "65000"
                        }
                    },
                    COFINS = new Nfe.PL_006u.TNFeInfNFeDetImpostoCOFINS()
                    {
                        Item = new Nfe.PL_006u.TNFeInfNFeDetImpostoCOFINSCOFINSAliq()
                        {
                            CST = Nfe.PL_006u.TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST.Item01,
                            vBC = "100000000.00",
                            pCOFINS = "2.00",
                            vCOFINS = "200000.00"
                        }
                    },
                    vTotTrib = "0"
                }
            });

            

            nfe.infNFe.transp.vol.Add(new Nfe.PL_006u.TNFeInfNFeTranspVol()
            {
                qVol = "10000",
                esp = "CAIXA",
                marca = "LINDOYA",
                nVol = "500",
                pesoL = "1000000000.000",
                pesoB = "1200000000.000",
                lacres = new List<Nfe.PL_006u.TNFeInfNFeTranspVolLacres>()
                {
                    new Nfe.PL_006u.TNFeInfNFeTranspVolLacres()
                    {
                        nLacre = "XYZ10231486"
                    }
                }
            });

            Reyx.Nfe.PL_006u.TNfeProc procNFe = new Nfe.PL_006u.TNfeProc();
            procNFe.versao = "2.00";
            procNFe.NFe = nfe;

            procNFe.SaveToFile(@"C:\users\user\desktop\procNFe.xml");

            Reyx.Nfe.PL_006u.EnviNFe.TEnviNFe enviNFe = new Nfe.PL_006u.EnviNFe.TEnviNFe()
            {
                idLote = new Random(132546).Next().ToString(),
                versao = "2.00"
            };
            enviNFe.NFe = new List<Nfe.PL_006u.EnviNFe.TNFe>();

            Nfe.PL_006u.EnviNFe.TNFe procNFeout = new Nfe.PL_006u.EnviNFe.TNFe();
            Map<Nfe.PL_006u.TNFe, Nfe.PL_006u.EnviNFe.TNFe>(procNFe.NFe, procNFeout);
            enviNFe.NFe.Add(procNFeout);
            enviNFe.Save(@"C:\users\user\desktop\enviNFe.xml");

            //Reyx.Nfe.Schema200.procNFe teste = Reyx.Nfe.XmlParser.Xml.Load<Nfe.Schema200.procNFe>(@"C:\users\regis.silva\desktop\nfe.xml");
            //Console.WriteLine(teste.NFe.infNFe.emit.xNome);
            //Console.Read();
        }

        public static void Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            var props = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var type = typeof(TDestination);

            foreach (var prop in props)
            {
                object value = prop.GetValue(source, null);

                var prop2 = type.GetProperty(prop.Name);
                if (prop2 == null)
                    continue;

                if (prop.PropertyType != prop2.PropertyType)
                    continue;

                prop2.SetValue(destination, value, null);
            }
        }
    }
}