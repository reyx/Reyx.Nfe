using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reyx.Nfe
{
    /// <summary>
    /// 
    /// </summary>
    public interface INFe
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cUF"></param>
        /// <param name="cNF"></param>
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
        /// <param name="NFref"></param>
        /// <param name="tpImp"></param>
        /// <param name="tpEmis"></param>
        /// <param name="cDV"></param>
        /// <param name="tpAmb"></param>
        /// <param name="finNFe"></param>
        /// <param name="procEmi"></param>
        /// <param name="verProc"></param>
        /// <param name="dhCont"></param>
        /// <param name="xJust"></param>
        /// <returns></returns>
        string identificador(int cUF, int cNF, string natOp, int indPag, int mod, int serie, int nNF, DateTime dEmi, DateTime dSaiEnt, string hSaiEnt, int tpNF, string cMunFG, string NFref, int tpImp, int tpEmis, int cDV, int tpAmb, int finNFe, int procEmi, string verProc, DateTime dhCont, string xJust);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NFe"></param>
        /// <returns></returns>
        string NFeRef(string NFe);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cUF"></param>
        /// <param name="AAMM"></param>
        /// <param name="CNPJ"></param>
        /// <param name="mod"></param>
        /// <param name="serie"></param>
        /// <param name="nNF"></param>
        /// <returns></returns>
        string NFRef(int cUF, string AAMM, string CNPJ, int mod, int serie, int nNF);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CTe"></param>
        /// <returns></returns>
        string CTeRef(string CTe);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mod"></param>
        /// <param name="nECF"></param>
        /// <param name="nCOO"></param>
        /// <returns></returns>
        string ECFRef(string mod, int nECF, int nCOO);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CNPJ"></param>
        /// <param name="CPF"></param>
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
        /// <param name="IE"></param>
        /// <param name="IEST"></param>
        /// <param name="IM"></param>
        /// <param name="CNAE"></param>
        /// <param name="CRT"></param>
        /// <returns></returns>
        string emitente(string CNPJ, string CPF, string xNome, string xFant, string xLgr, string nro, string xCpl, string xBairro, string cMun, string xMun, string UF, string CEP, string cPais, string xPais, string fone, string IE, string IEST, string IM, string CNAE, string CRT);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CNPJ"></param>
        /// <param name="CPF"></param>
        /// <param name="xNome"></param>
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
        /// <param name="IE"></param>
        /// <param name="IESUF"></param>
        /// <param name="eMail"></param>
        /// <returns></returns>
        string destinatario(string CNPJ, string CPF, string xNome, string xLgr, string nro, string xCpl, string xBairro, string cMun, string xMun, string UF, string CEP, string cPais, string xPais, string fone, string IE, string IESUF, string eMail);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CNPJ"></param>
        /// <param name="CPF"></param>
        /// <param name="xLgr"></param>
        /// <param name="nro"></param>
        /// <param name="xCpl"></param>
        /// <param name="xBairro"></param>
        /// <param name="cMun"></param>
        /// <param name="xMun"></param>
        /// <param name="UF"></param>
        /// <returns></returns>
        string localRetirada(string CNPJ, string CPF, string xLgr, string nro, string xCpl, string xBairro, string cMun, string xMun, string UF);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CNPJ"></param>
        /// <param name="CPF"></param>
        /// <param name="xLgr"></param>
        /// <param name="nro"></param>
        /// <param name="xCpl"></param>
        /// <param name="xBairro"></param>
        /// <param name="cMun"></param>
        /// <param name="xMun"></param>
        /// <param name="UF"></param>
        /// <returns></returns>
        string localEntrega(string CNPJ, string CPF, string xLgr, string nro, string xCpl, string xBairro, string cMun, string xMun, string UF);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cProd"></param>
        /// <param name="cEAN"></param>
        /// <param name="xProd"></param>
        /// <param name="NCM"></param>
        /// <param name="EXTIPI"></param>
        /// <param name="CFOP"></param>
        /// <param name="uCom"></param>
        /// <param name="qCom"></param>
        /// <param name="vUnCom"></param>
        /// <param name="vProd"></param>
        /// <param name="cEANTrib"></param>
        /// <param name="uTrib"></param>
        /// <param name="qTrib"></param>
        /// <param name="vUnTrib"></param>
        /// <param name="vFrete"></param>
        /// <param name="vSeg"></param>
        /// <param name="vDesc"></param>
        /// <param name="vOutro"></param>
        /// <param name="indTot"></param>
        /// <param name="DI"></param>
        /// <param name="DetEspecifico"></param>
        /// <param name="xPed"></param>
        /// <param name="nItemPed"></param>
        /// <returns></returns>
        string produto(string cProd, string cEAN, string xProd, string NCM, string EXTIPI, int CFOP, string uCom, double qCom, double vUnCom, double vProd, string cEANTrib, string uTrib, double qTrib, double vUnTrib, double vFrete, double vSeg, double vDesc, double vOutro, int indTot, string DI, string DetEspecifico, string xPed, int nItemPed);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nAdicao"></param>
        /// <param name="nSeqAdic"></param>
        /// <param name="cFabricante"></param>
        /// <param name="vDescDI"></param>
        /// <returns></returns>
        string adi(int nAdicao, int nSeqAdic, string cFabricante, double vDescDI);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="infAdProd"></param>
        /// <returns></returns>
        string infAdProd(string infAdProd);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tpOp"></param>
        /// <param name="chassi"></param>
        /// <param name="cCor"></param>
        /// <param name="xCor"></param>
        /// <param name="pot"></param>
        /// <param name="cilin"></param>
        /// <param name="peloL"></param>
        /// <param name="pesoB"></param>
        /// <param name="nSerie"></param>
        /// <param name="tpComb"></param>
        /// <param name="nMotor"></param>
        /// <param name="CMT"></param>
        /// <param name="dist"></param>
        /// <param name="anoMod"></param>
        /// <param name="anoFab"></param>
        /// <param name="tpPint"></param>
        /// <param name="tpVeic"></param>
        /// <param name="espVeic"></param>
        /// <param name="VIN"></param>
        /// <param name="condVeic"></param>
        /// <param name="cMod"></param>
        /// <param name="cCorDENATRAN"></param>
        /// <param name="lota"></param>
        /// <param name="tpRest"></param>
        /// <returns></returns>
        string veicProd(int tpOp, string chassi, string cCor, string xCor, string pot, string cilin, string peloL, string pesoB, string nSerie, string tpComb, string nMotor, string CMT, string dist, string anoMod, string anoFab, string tpPint, string tpVeic, string espVeic, string VIN, string condVeic, string cMod, string cCorDENATRAN, string lota, string tpRest);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nLote"></param>
        /// <param name="qLote"></param>
        /// <param name="dFab"></param>
        /// <param name="dVal"></param>
        /// <param name="vPMC"></param>
        /// <returns></returns>
        string med(string nLote, double qLote, DateTime dFab, DateTime dVal, double vPMC);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tpArma"></param>
        /// <param name="nSerie"></param>
        /// <param name="nCano"></param>
        /// <param name="descr"></param>
        /// <returns></returns>
        string arma(int tpArma, string nSerie, string nCano, string descr);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cProdANP"></param>
        /// <param name="CODIF"></param>
        /// <param name="qTemp"></param>
        /// <param name="UFCons"></param>
        /// <param name="qBCProd"></param>
        /// <param name="vAliqProd"></param>
        /// <param name="vCIDE"></param>
        /// <returns></returns>
        string comb(string cProdANP, string CODIF, double qTemp, string UFCons, double qBCProd, double vAliqProd, double vCIDE);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ICMS"></param>
        /// <param name="IPI"></param>
        /// <param name="II"></param>
        /// <param name="PIS"></param>
        /// <param name="PISST"></param>
        /// <param name="COFINS"></param>
        /// <param name="COFINSST"></param>
        /// <param name="ISSQN"></param>
        /// <returns></returns>
        string imposto(string ICMS, string IPI, string II, string PIS, string PISST, string COFINS, string COFINSST, string ISSQN);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orig"></param>
        /// <param name="CST"></param>
        /// <param name="modBC"></param>
        /// <param name="pRedBC"></param>
        /// <param name="vBC"></param>
        /// <param name="pICMS"></param>
        /// <param name="vICMS"></param>
        /// <param name="modBCST"></param>
        /// <param name="pMVAST"></param>
        /// <param name="pRedBCST"></param>
        /// <param name="vBCST"></param>
        /// <param name="pICMSST"></param>
        /// <param name="vICMSST"></param>
        /// <param name="vBCSTRet"></param>
        /// <param name="vICMSSRet"></param>
        /// <param name="vBCSTDest"></param>
        /// <param name="vICMSSTDest"></param>
        /// <param name="motDesICMS"></param>
        /// <param name="pBCOp"></param>
        /// <param name="UFST"></param>
        /// <param name="pCredSN"></param>
        /// <param name="vCredICMSSN"></param>
        /// <returns></returns>
        string icms(string orig, string CST, int modBC, double pRedBC, double vBC, double pICMS, double vICMS, int modBCST, double pMVAST, double pRedBCST, double vBCST, double pICMSST, double vICMSST, double vBCSTRet, double vICMSSRet, double vBCSTDest, double vICMSSTDest, int motDesICMS, double pBCOp, string UFST, double pCredSN, double vCredICMSSN);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clEnq"></param>
        /// <param name="CNPJProd"></param>
        /// <param name="cSelo"></param>
        /// <param name="qSelo"></param>
        /// <param name="cEnq"></param>
        /// <param name="CST"></param>
        /// <param name="vBC"></param>
        /// <param name="pIPI"></param>
        /// <param name="vIPI"></param>
        /// <param name="qUnid"></param>
        /// <param name="vUnid"></param>
        /// <returns></returns>
        string IPI(string clEnq, string CNPJProd, string cSelo, double qSelo, string cEnq, string CST, double vBC, double pIPI, double vIPI, double qUnid, double vUnid);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vBC"></param>
        /// <param name="vDespAdu"></param>
        /// <param name="vII"></param>
        /// <param name="vIOF"></param>
        /// <returns></returns>
        string II(double vBC, double vDespAdu, double vII, double vIOF);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CST"></param>
        /// <param name="vBC"></param>
        /// <param name="pPIS"></param>
        /// <param name="vPIS"></param>
        /// <param name="qBCProd"></param>
        /// <param name="vAliqProd"></param>
        /// <returns></returns>
        string PIS(string CST, double vBC, double pPIS, double vPIS, double qBCProd, double vAliqProd);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vBC"></param>
        /// <param name="pPIS"></param>
        /// <param name="vPIS"></param>
        /// <param name="qBCProd"></param>
        /// <param name="vAliqProd"></param>
        /// <returns></returns>
        string PISST(double vBC, double pPIS, double vPIS, double qBCProd, double vAliqProd);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CST"></param>
        /// <param name="vBC"></param>
        /// <param name="pCOFINS"></param>
        /// <param name="vCOFINS"></param>
        /// <param name="qBCProd"></param>
        /// <param name="vAliqProd"></param>
        /// <returns></returns>
        string COFINS(string CST, double vBC, double pCOFINS, double vCOFINS, double qBCProd, double vAliqProd);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vBC"></param>
        /// <param name="pCOFINS"></param>
        /// <param name="vCOFINS"></param>
        /// <param name="qBCProd"></param>
        /// <param name="vAliqProd"></param>
        /// <returns></returns>
        string COFINSST(double vBC, double pCOFINS, double vCOFINS, double qBCProd, double vAliqProd);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vBC"></param>
        /// <param name="vAliq"></param>
        /// <param name="vISSQN"></param>
        /// <param name="cMunFG"></param>
        /// <param name="cListServ"></param>
        /// <param name="cSitTrib"></param>
        /// <returns></returns>
        string ISSQN(double vBC, double vAliq, double vISSQN, string cMunFG, int cListServ, string cSitTrib);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ICMSTot"></param>
        /// <param name="ISSQNTot"></param>
        /// <param name="retTrib"></param>
        /// <returns></returns>
        string total(string ICMSTot, string ISSQNTot, string retTrib);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vBC"></param>
        /// <param name="vICMS"></param>
        /// <param name="vBCST"></param>
        /// <param name="vST"></param>
        /// <param name="vProd"></param>
        /// <param name="vFrete"></param>
        /// <param name="vSeg"></param>
        /// <param name="vDesc"></param>
        /// <param name="vII"></param>
        /// <param name="vIPI"></param>
        /// <param name="vPIS"></param>
        /// <param name="vCOFINS"></param>
        /// <param name="vOutro"></param>
        /// <param name="vNF"></param>
        /// <returns></returns>
        string totalICMS(double vBC, double vICMS, double vBCST, double vST, double vProd, double vFrete, double vSeg, double vDesc, double vII, double vIPI, double vPIS, double vCOFINS, double vOutro, double vNF);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vServ"></param>
        /// <param name="vBC"></param>
        /// <param name="vISS"></param>
        /// <param name="vPIS"></param>
        /// <param name="vCOFINS"></param>
        /// <returns></returns>
        string totalISS(double vServ, double vBC, double vISS, double vPIS, double vCOFINS);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vRetPIS"></param>
        /// <param name="vRetCOFINS"></param>
        /// <param name="vRetCSLL"></param>
        /// <param name="vBCIRRF"></param>
        /// <param name="vIRRF"></param>
        /// <param name="vBCRetPrev"></param>
        /// <param name="vRetPrev"></param>
        /// <returns></returns>
        string tributoRetido(double vRetPIS, double vRetCOFINS, double vRetCSLL, double vBCIRRF, double vIRRF, double vBCRetPrev, double vRetPrev);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modFrete"></param>
        /// <param name="transporta"></param>
        /// <param name="retTransp"></param>
        /// <param name="veicTransp"></param>
        /// <param name="reboque"></param>
        /// <param name="vagao"></param>
        /// <param name="balsa"></param>
        /// <param name="vol"></param>
        /// <returns></returns>
        string transportador(string modFrete, string transporta, string retTransp, string veicTransp, string reboque, string vagao, string balsa, string vol);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CNPJ"></param>
        /// <param name="CPF"></param>
        /// <param name="xNome"></param>
        /// <param name="IE"></param>
        /// <param name="xEnder"></param>
        /// <param name="xMun"></param>
        /// <param name="UF"></param>
        /// <returns></returns>
        string transporta(string CNPJ, string CPF, string xNome, string IE, string xEnder, string xMun, string UF);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vServ"></param>
        /// <param name="vBCRet"></param>
        /// <param name="pICMSRet"></param>
        /// <param name="vICMSRet"></param>
        /// <param name="CFOP"></param>
        /// <param name="cMunFG"></param>
        /// <returns></returns>
        string retTransp(double vServ, double vBCRet, double pICMSRet, double vICMSRet, int CFOP, string cMunFG);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="UF"></param>
        /// <param name="RNTC"></param>
        /// <returns></returns>
        string veicTransp(string placa, string UF, string RNTC);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="UF"></param>
        /// <param name="RNTC"></param>
        /// <returns></returns>
        string reboque(string placa, string UF, string RNTC);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="qVol"></param>
        /// <param name="esp"></param>
        /// <param name="marca"></param>
        /// <param name="nVol"></param>
        /// <param name="pesoL"></param>
        /// <param name="pesoB"></param>
        /// <param name="lacres"></param>
        /// <returns></returns>
        string vol(string qVol, string esp, string marca, string nVol, double pesoL, double pesoB, string lacres);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nLacre"></param>
        /// <returns></returns>
        string lacres(string nLacre);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="infAdFisco"></param>
        /// <param name="infCpl"></param>
        /// <param name="obsCont"></param>
        /// <param name="obsFisco"></param>
        /// <param name="procRef"></param>
        /// <returns></returns>
        string infAdic(string infAdFisco, string infCpl, string obsCont, string obsFisco, string procRef);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xCampo"></param>
        /// <param name="xTexto"></param>
        /// <returns></returns>
        string obsCont(string xCampo, string xTexto);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xCampo"></param>
        /// <param name="xTexto"></param>
        /// <returns></returns>
        string obsFisco(string xCampo, string xTexto);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nProc"></param>
        /// <param name="indProc"></param>
        /// <returns></returns>
        string procRef(string nProc, int indProc);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nFat"></param>
        /// <param name="vOrig"></param>
        /// <param name="vDesc"></param>
        /// <param name="vLiq"></param>
        /// <param name="dup"></param>
        /// <returns></returns>
        string cobr(string nFat, double vOrig, double vDesc, double vLiq, string dup);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nDup"></param>
        /// <param name="dVenc"></param>
        /// <param name="vDup"></param>
        /// <returns></returns>
        string dup(string nDup, DateTime dVenc, double vDup);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UFEmbarq"></param>
        /// <param name="xLocEmbarq"></param>
        /// <returns></returns>
        string exporta(string UFEmbarq, string xLocEmbarq);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xNEmp"></param>
        /// <param name="xPed"></param>
        /// <param name="xCont"></param>
        /// <returns></returns>
        string compra(string xNEmp, string xPed, string xCont);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="safra"></param>
        /// <param name="ref"></param>
        /// <param name="forDias"></param>
        /// <param name="qTotMes"></param>
        /// <param name="qTotAnt"></param>
        /// <param name="qTotGer"></param>
        /// <param name="deducs"></param>
        /// <param name="vFor"></param>
        /// <param name="vTotDed"></param>
        /// <param name="vLiqFor"></param>
        /// <returns></returns>
        string cana(string safra, string @ref, string forDias, string qTotMes, string qTotAnt, string qTotGer, string deducs, double vFor, double vTotDed, double vLiqFor);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="qtde"></param>
        /// <returns></returns>
        string forDia(int dia, double qtde);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xDed"></param>
        /// <param name="vDed"></param>
        /// <returns></returns>
        string deduc(string xDed, double vDed);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="versao"></param>
        /// <param name="Id"></param>
        /// <param name="ide"></param>
        /// <param name="emit"></param>
        /// <param name="avulsa"></param>
        /// <param name="dest"></param>
        /// <param name="retirada"></param>
        /// <param name="entrega"></param>
        /// <param name="detalhes"></param>
        /// <param name="total"></param>
        /// <param name="transp"></param>
        /// <param name="cobr"></param>
        /// <param name="infAdic"></param>
        /// <param name="exporta"></param>
        /// <param name="compra"></param>
        /// <param name="cana"></param>
        /// <returns></returns>
        string NFe(string versao, string Id, string ide, string emit, string avulsa, string dest, string retirada, string entrega, string detalhes, string total, string transp, string cobr, string infAdic, string exporta, string compra, string cana);
    }
}