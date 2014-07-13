using Reyx.Nfe.XmlParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Reyx.Tester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Reyx.Nfe.Schema200.NFe nfe = new Nfe.Schema200.NFe();
            nfe.infNFe = new Nfe.Schema200.Members.infNFe()
            {
                versao = "2.00",
                Id = "NFe35080599999090910270550010000000015180051273",
                ide = new Nfe.Schema200.Members.ide()
                {
                    cUF = "35",
                    cNF = "51800512",
                    natOp = "Venda a vista",
                    indPag = "0",
                    mod = "55",
                    serie = "1",
                    nNF = "1",
                    dEmi = "2011-11-20",
                    dSaiEnt = "2008-05-06",
                    tpNF = "0",
                    cMunFG = "3550308",
                    tpImp = "1",
                    tpEmis = "1",
                    cDV = "3",
                    tpAmb = "2",
                    finNFe = "1",
                    procEmi = "0",
                    verProc = "rcky-01"
                },
                emit = new Nfe.Schema200.Members.emit()
                {
                    CNPJ = "99999999000191",
                    xNome = "NFe",
                    xFant = "NFe",
                    enderEmit = new Nfe.Schema200.Members.endereco()
                    {
                        xLgr = "Rua Central",
                        nro = "100",
                        xCpl = "Fundos",
                        xBairro = "Distrito Industrial",
                        cMun = "3502200",
                        xMun = "Angatuba",
                        UF = "SP",
                        CEP = "17100171",
                        cPais = "1058",
                        xPais = "Brasil",
                        fone = "1733021717"
                    },
                    IE = "123456789012",
                    CRT = "3"
                },
                dest = new Nfe.Schema200.Members.dest()
                {
                    CNPJ = "00000000000191",
                    xNome = "DISTRIBUIDORA DE AGUAS MINERAIS",
                    enderDest = new Nfe.Schema200.Members.endereco()
                    {
                        xLgr = "V DAS FONTES",
                        nro = "1777",
                        xCpl = "10 Andar",
                        xBairro = "Pq Fontes",
                        cMun = "5030801",
                        xMun = "Sao Paulo",
                        UF = "SP",
                        CEP = "13950000",
                        cPais = "1058",
                        xPais = "Brasil",
                        fone = "1932011234"
                    },
                    IE = ""
                },
                retirada = new Nfe.Schema200.Members.enderCom()
                {
                    CNPJ = "99171171000194",
                    xLgr = "AV PAULISTA",
                    nro = "12345",
                    xCpl = "TERREO",
                    xBairro = "CERQUEIRA CESAR",
                    cMun = "3550308",
                    xMun = "SAO PAULO",
                    UF = "SP"
                },
                entrega = new Nfe.Schema200.Members.enderCom()
                {
                    CNPJ = "99299299000194",
                    xLgr = "AV FARIA LIMA",
                    nro = "1500",
                    xCpl = "15 ANDAR",
                    xBairro = "PINHEIROS",
                    cMun = "3550308",
                    xMun = "SAO PAULO",
                    UF = "SP"
                },
                det = new List<Nfe.Schema200.Members.det>(),
                total = new Nfe.Schema200.Members.total()
                {
                    ICMSTot = new Nfe.Schema200.Members.ICMSTot()
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
                transp = new Nfe.Schema200.Members.transp()
                {
                    modFrete = "0",
                    transporta = new Nfe.Schema200.Members.transporta()
                    {
                        CNPJ = "99171171000191",
                        xNome = "Distribuidora de Bebidas Fazenda de SP Ltda.",
                        IE = "171999999119",
                        xEnder = "Rua Central 100 - Fundos - Distrito Industrial",
                        xMun = "SAO PAULO",
                        UF = "SP",
                    },
                    veicTransp = new Nfe.Schema200.Members.veicTransp()
                    {
                        placa = "BXI1717",
                        UF = "SP",
                        RNTC = "123456789"
                    },
                    reboque = new Nfe.Schema200.Members.reboque()
                    {
                        placa = "BXI1818",
                        UF = "SP",
                        RNTC = "123456789"
                    },
                    vol = new List<Nfe.Schema200.Members.vol>()
                },
                infAdic = new Nfe.Schema200.Members.infAdic()
                {
                    infAdFisco = "Nota Fiscal de exemplo NF-eletronica.com"
                }
            };

            nfe.infNFe.det.Add(new Nfe.Schema200.Members.det()
            {
                nItem = "1",
                prod = new Nfe.Schema200.Members.prod()
                {
                    cProd = "00001",
                    cEAN = "",
                    xProd = "Agua Mineral",
                    NCM = "12002500",
                    CFOP = "5101",
                    uCom = "dz",
                    qCom = "1000000.0000",
                    vUnCom = "1",
                    vProd = "10000000.00",
                    cEANTrib = "",
                    uTrib = "un",
                    qTrib = "12000000.00",
                    vUnTrib = "1",
                    indTot = "1"
                },
                imposto = new Nfe.Schema200.Members.imposto()
                {
                    ICMS = new Reyx.Nfe.Schema200.Members.ICMS()
                    {
                        ICMS00 = new Nfe.Schema200.Members.ICMS00()
                        {
                            orig = "0",
                            CST = "00",
                            modBC = "0",
                            vBC = "10000000.00",
                            pICMS = "18.00",
                            vICMS = "1800000.00"
                        }
                    },
                    PIS = new Nfe.Schema200.Members.PIS()
                    {
                        PISAliq = new Nfe.Schema200.Members.PISAliq()
                        {
                            CST = "01",
                            vBC = "100000000.00",
                            pPIS = "0.65",
                            vPIS = "65000"
                        }
                    },
                    COFINS = new Nfe.Schema200.Members.COFINS()
                    {
                        COFINSAliq = new Nfe.Schema200.Members.COFINSAliq()
                        {
                            CST = "01",
                            vBC = "100000000.00",
                            pCOFINS = "2.00",
                            vCOFINS = "200000.00"
                        }
                    },
                    vTotTrib = "0"
                }
            });

            nfe.infNFe.det.Add(new Nfe.Schema200.Members.det()
            {
                nItem = "2",
                prod = new Nfe.Schema200.Members.prod()
                {
                    cProd = "00002",
                    cEAN = "",
                    xProd = "Agua Mineral",
                    NCM = "12002500",
                    CFOP = "5101",
                    uCom = "pack",
                    qCom = "5000000.0000",
                    vUnCom = "2",
                    vProd = "10000000.00",
                    cEANTrib = "",
                    uTrib = "un",
                    qTrib = "3000000.00",
                    vUnTrib = "0.3333",
                    indTot = "1"
                },
                imposto = new Nfe.Schema200.Members.imposto()
                {
                    ICMS = new Reyx.Nfe.Schema200.Members.ICMS()
                    {
                        ICMS00 = new Nfe.Schema200.Members.ICMS00()
                        {
                            orig = "0",
                            CST = "00",
                            modBC = "0",
                            vBC = "10000000.00",
                            pICMS = "18.00",
                            vICMS = "1800000.00"
                        }
                    },
                    PIS = new Nfe.Schema200.Members.PIS()
                    {
                        PISAliq = new Nfe.Schema200.Members.PISAliq()
                        {
                            CST = "01",
                            vBC = "100000000.00",
                            pPIS = "0.65",
                            vPIS = "65000"
                        }
                    },
                    COFINS = new Nfe.Schema200.Members.COFINS()
                    {
                        COFINSAliq = new Nfe.Schema200.Members.COFINSAliq()
                        {
                            CST = "01",
                            vBC = "100000000.00",
                            pCOFINS = "2.00",
                            vCOFINS = "200000.00"
                        }
                    },
                    vTotTrib = "0"
                }
            });

            nfe.infNFe.transp.vol.Add(new Nfe.Schema200.Members.vol()
            {
                qVol = "10000",
                esp = "CAIXA",
                marca = "LINDOYA",
                nVol = "500",
                pesoL = "1000000000.000",
                pesoB = "1200000000.000",
                lacres = new List<Nfe.Schema200.Members.lacres>()
            });

            nfe.infNFe.transp.vol.First().lacres.Add(new Nfe.Schema200.Members.lacres()
            {
                nLacre = "XYZ10231486"
            });

            Reyx.Nfe.Schema200.procNFe procNFe = new Nfe.Schema200.procNFe();
            procNFe.versao = "2.00";
            procNFe.NFe = nfe;

            procNFe.Save(@"C:\users\regis.silva\desktop\procNFe.xml");

            Reyx.Nfe.Schema200.Envio.enviNFe enviNFe = new Nfe.Schema200.Envio.enviNFe()
            {
                idLote = new Random(132546).Next().ToString(),
                versao = "2.00"
            };
            enviNFe.NFe = new List<Nfe.Schema200.NFe>();
            enviNFe.NFe.Add(procNFe.NFe);

            enviNFe.Save(@"C:\users\regis.silva\desktop\enviNFe.xml");

            //Reyx.Nfe.Schema200.procNFe teste = Reyx.Nfe.XmlParser.Xml.Load<Nfe.Schema200.procNFe>(@"C:\users\regis.silva\desktop\nfe.xml");
            //Console.WriteLine(teste.NFe.infNFe.emit.xNome);
            //Console.Read();
        }
    }
}