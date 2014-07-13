using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace Reyx.Nfe
{
    /// <summary>
    /// Interface pública de comunicação com Visual Ojects
    /// </summary>
    [ComVisible(true), GuidAttribute("CB36B6E0-E69A-42AE-954C-3C16873ED882")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface INotaFiscal
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="xml"></param>
        void IntervencaoManual(XmlDocument xml);

        /// <summary>
        /// Inicializa um novo documento fiscal
        /// </summary>
        /// <param name="pasta">Local em que o arquivo será salvo</param>
        /// <param name="chave">Chave - opcional</param>
        void Nova(string pasta, string chave);

        /// <summary>
        /// Adicionar nota fiscal referenciada
        /// </summary>
        /// <param name="refNFe">Chave de acesso da NFe referenciada</param>
        /// <param name="tipo">
        ///     <para>Tipo da NFe referenciada:</para>
        ///     <para>'refNF' - NFe</para>
        ///     <para>'refECF' - Cupom Fiscal</para>
        /// </param>
        /// <param name="cUF">Código IBGE da UF do emitente</param>
        /// <param name="AAMM">Ano e mês de emissão da NFe</param>
        /// <param name="CNPJ">CNPJ do emitente</param>
        /// <param name="mod">Modelo da NFe</param>
        /// <param name="serie">Série da NFe</param>
        /// <param name="nNF">Número do Documento Fiscal</param>
        /// <param name="nECF">Número de ordem sequencial do ECF</param>
        /// <param name="nCOO">Número do contador de ordem de operação</param>
        void AdicionarNotaReferenciada(string refNFe, string tipo, string cUF, string AAMM, string CNPJ, string mod, string serie, string nNF, string nECF, string nCOO);

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
        void AdicionarCabecalho(
            string idLote, string versao, string cUF, string natOp, string indPag, string mod, string serie, string nNF, string dEmi,
            string dSaiEnt, string hSaiEnt, string tpNF, string cMunFG, string tpImp, string tpEmis, string cDV, string tpAmb, string finNFe,
            string procEmi, string verProc, string infAdFisco, string infCpl);

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
        void AdicionarDadosEmitente(
            string CPF, string CNPJ, string IE, string IEST, string IM, string CNAE, string CRT, string xNome, string xFant,
            string xLgr, string nro, string xCpl, string xBairro, string cMun, string xMun, string UF, string CEP, string cPais, string xPais, string fone);

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
        void AdicionarDadosDestinatario(
            string CPF, string CNPJ, string IE, string ISUF, string xNome, string email,
            string xLgr, string nro, string xCpl, string xBairro, string cMun, string xMun,
            string UF, string CEP, string cPais, string xPais, string fone);

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
        void AdicionarDadosEntrega(string CPF, string CNPJ, string xLgr, string nro, string xCpl, string xBairro, string cMun, string xMun, string UF);

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
        void AdicionarDadosRetirada(string CPF, string CNPJ, string xLgr, string nro, string xCpl, string xBairro, string cMun, string xMun, string UF);

        /// <summary>
        ///
        /// </summary>
        /// <param name="nItem"></param>
        /// <param name="infAdProd"></param>
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
        /// <param name="indTot"></param>
        /// <param name="vFrete"></param>
        /// <param name="vSeg"></param>
        /// <param name="vDesc"></param>
        /// <param name="vOutro"></param>
        /// <param name="xPed"></param>
        /// <param name="nItemPed"></param>
        void AdicionarItem(
            string nItem, string infAdProd, string cProd, string cEAN, string xProd, string NCM, string EXTIPI, string CFOP,
            string uCom, string qCom, string vUnCom, string vProd, string cEANTrib, string uTrib, string qTrib, string vUnTrib,
            string indTot, string vFrete, string vSeg, string vDesc, string vOutro, string xPed, string nItemPed);

        /// <summary>
        ///
        /// </summary>
        /// <param name="CST">Código da situação tributária</param>
        /// <param name="orig">Origem do produto</param>
        /// <param name="modBC">Modalidade da base de cálculo</param>
        /// <param name="vBC">Valor da base de cálculo</param>
        /// <param name="pRedBC">Alíquota de redução da base de cálculo</param>
        /// <param name="pICMS">Alíquota de ICMS</param>
        /// <param name="vICMS">Valor do ICMS</param>
        /// <param name="modBCST">Modalidade da base de cálculo da substituição tributária</param>
        /// <param name="pMVAST">Aliquota de margem de valor agregado da substituição tributária</param>
        /// <param name="pRedBCST">Alíquota de redução da substituição tributária</param>
        /// <param name="vBCST">Valor da base de cálculo da substituição tributária</param>
        /// <param name="pICMSST">Alíquota de ICMS da substituição tributária</param>
        /// <param name="vICMSST">Valor do ICMS da substituição tributária</param>
        /// <param name="pCredSN">Alíquota de crédito do Simples Nacional</param>
        /// <param name="vCredICMSSN">Valor do crédito do Simples Nacional</param>
        /// <param name="motDesICMS">Motivo de desoneração do ICMS</param>
        /// <param name="pBCOp"></param>
        /// <param name="UFST">UF da operação Interestadual</param>
        /// <param name="vICMSSTRet">Valor de substituição tributária retido na operação Interestadual</param>
        /// <param name="vBCSTRet">Valor da base de cálculo do ICMS retido na operação Interestadual</param>
        void AdicionarIcmsItem(
            string CST, string orig, string modBC, string vBC, string pRedBC, string pICMS, string vICMS, string modBCST, string pMVAST,
            string pRedBCST, string vBCST, string pICMSST, string vICMSST, string pCredSN, string vCredICMSSN, string motDesICMS,
            string pBCOp, string UFST, string vICMSSTRet, string vBCSTRet);

        /// <summary>
        ///
        /// </summary>
        /// <param name="cEnq">Classe de enquadramento</param>
        /// <param name="CST">Código da situação tributária</param>
        /// <param name="vBC">Valor da base de cálculo</param>
        /// <param name="pIPI">Percentual de alíquota</param>
        /// <param name="qUnid">Quantidade unitária</param>
        /// <param name="vUnid">Valor unitário</param>
        /// <param name="vIPI">Valor total do IPI</param>
        void AdicionarIpiItem(string cEnq, string CST, string vBC, string pIPI, string qUnid, string vUnid, string vIPI);

        /// <summary>
        /// Adiciona parametros de PIS ao item atual
        /// </summary>
        /// <param name="CST">Código da situação tributária</param>
        /// <param name="vBC">Valor da base de cálculo</param>
        /// <param name="pPIS">Percentual de alíquota</param>
        /// <param name="vPIS">Valor total do PIS</param>
        /// <param name="qBCProd">Base de cálculo do produto</param>
        /// <param name="vAliqProd">Valor de alíquota do produto</param>
        void AdicionarPisItem(string CST, string vBC, string pPIS, string vPIS, string qBCProd, string vAliqProd);

        /// <summary>
        /// Adiciona parametros de cofins ao item atual
        /// </summary>
        /// <param name="CST">Código da situação tributária</param>
        /// <param name="vBC">Valor da base de cálculo</param>
        /// <param name="pCOFINS">Percentual de alíquota</param>
        /// <param name="vCOFINS">Valor total do COFINS</param>
        /// <param name="qBCProd">Base de cálculo do produto</param>
        /// <param name="vAliqProd">Valor de alíquota do produto</param>
        void AdicionarCofinsItem(string CST, string vBC, string pCOFINS, string vCOFINS, string qBCProd, string vAliqProd);

        /// <summary>
        /// Adiciona parametros importação ao item atual
        /// </summary>
        /// <param name="vBC">Valor da base de cálculo</param>
        /// <param name="vDespAdu">Valor de despesas aduaneiras</param>
        /// <param name="vII">Valor total do II</param>
        /// <param name="vIOF">Valor do IOF</param>
        void AdicionarIiItem(string vBC, string vDespAdu, string vII, string vIOF);

        /// <summary>
        /// Adiciona duplicatas no documento fiscal
        /// </summary>
        /// <param name="numero">Número sequencial</param>
        /// <param name="data">AAAA-MM-DD</param>
        /// <param name="valor">Valor da duplicata</param>
        void AdicionarDuplicata(string numero, string data, string valor);

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
        void AdicionarDadosTransportador(
            string CPF, string CNPJ, string IE, string xNome, string xEnder, string xMun, string UF,
            string vServ, string vBCRet, string pICMSRet, string vICMSRet, string CFOP, string cMunFG);

        /// <summary>
        ///
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="RNTC"></param>
        /// <param name="UF"></param>
        void AdicionarVeiculoTransporte(string placa, string RNTC, string UF);

        /// <summary>
        /// Adiciona volumes no documento fiscal
        /// </summary>
        /// <param name="esp">Espécie</param>
        /// <param name="marca">Marca</param>
        /// <param name="nVol">Númeração sequencial</param>
        /// <param name="pesoB">Peso Bruto</param>
        /// <param name="pesoL">Peso Liquido</param>
        /// <param name="qVol">Quantidade de Volumes</param>
        void AdicionarVolume(string esp, string marca, string nVol, string pesoB, string pesoL, string qVol);

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
        void AdicionarTotalIcms(
            string vBC, string vBCST, string vCOFINS, string vDesc, string vFrete, string vICMS, string vII,
            string vIPI, string vNF, string vOutro, string vPIS, string vProd, string vSeg, string vST);

        /// <summary>
        ///
        /// </summary>
        /// <param name="vBC"></param>
        /// <param name="vCOFINS"></param>
        /// <param name="vISS"></param>
        /// <param name="vPIS"></param>
        /// <param name="vServ"></param>
        void AdicionarTotalIssqn(string vBC, string vCOFINS, string vISS, string vPIS, string vServ);

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
        void AdicionarTotalRetencaoTributaria(string vBCIRRF, string vBCRetPrev, string vIRRF, string vRetCOFINS, string vRetCSLL, string vRetPIS, string vRetPrev);

        /// <summary>
        /// Envia os dados do documento fiscal atual através de webservice para a Receita Federal
        /// </summary>
        /// <returns></returns>
        string Enviar();

        /// <summary>
        /// Cancelar documento fiscal através de webservice
        /// </summary>
        /// <param name="arquivo">Caminho completo do arquivo xml de processamento da NFe</param>
        /// <param name="xJust">Justificativa de cancelamento</param>
        /// <returns></returns>
        string Cancelar(string arquivo, string xJust);

        /// <summary>
        /// Cancelar documento fiscal por evento através de webservice
        /// </summary>
        /// <param name="arquivo"></param>
        /// <param name="idLote"></param>
        /// <param name="xJust"></param>
        /// <param name="dhEvento"></param>
        /// <returns></returns>
        string CancelarEvento(string arquivo, string idLote, string xJust, string dhEvento);

        /// <summary>
        /// Inutilizar documento fiscal através de webservice
        /// </summary>
        /// <param name="pasta">Caminho completo do local onde está o documento</param>
        /// <param name="tpAmb">Tipo de Ambiente</param>
        /// <param name="inicial">Numeração inicial</param>
        /// <param name="final">Numeração final</param>
        /// <param name="serie">Série</param>
        /// <param name="xJust">Justificativa de inutilização</param>
        /// <param name="UF">Sigla da UF</param>
        /// <param name="cUF">Codigo IBGE da UF</param>
        /// <param name="ano">Ano de referência</param>
        /// <param name="cnpj">CNPJ do emitente</param>
        /// <returns></returns>
        string Inutilizar(string pasta, string tpAmb, string inicial, string final, string serie, string xJust, string UF, string cUF, string ano, string cnpj);

        /// <summary>
        /// Corrigir documento fiscal através de webservice
        /// </summary>
        /// <param name="arquivo">Caminho completo do arquivo xml de processamento da NFe</param>
        /// <param name="idLote">Identificador de referencia</param>
        /// <param name="xCorrecao">Correções da nota fiscal</param>
        /// <param name="dhEvento">Data e hora do evento no formato AAAA-MM-DD hh:mm:ss</param>
        /// <param name="xCondUso">
        /// <para>
        ///     Condições para inutilização do documento:
        /// </para>
        /// <para>
        ///     Por padrão será enviado o seguinte texto:
        /// </para>
        /// <para>
        ///     A Carta de Correcao e disciplinada pelo paragrafo 1o-A do art. 7o do Convenio S/N, de 15 de dezembro de 1970 e pode ser utilizada para
        ///     regularizacao de erro ocorrido na emissao de documento fiscal, desde que o erro nao esteja relacionado com: I - as variaveis que
        ///     determinam o valor do imposto tais como: base de calculo, aliquota, diferenca de preco, quantidade, valor da operacao ou da prestacao;
        ///     II - a correcao de dados cadastrais que implique mudanca do remetente ou do destinatario; III - a data de emissao ou de saida.
        /// </para>
        /// </param>
        /// <returns></returns>
        string Corrigir(string arquivo, string idLote, string xCorrecao, string dhEvento, string xCondUso);

        /// <summary>
        /// Consulta a situação atual da nota fiscal através de webservice
        /// </summary>
        /// <returns></returns>
        string ConsultarSituacaoAtual(string serial, string arquivo, string idLote);

        /// <summary>
        /// Consulta o status da nota fiscal através de webservice
        /// </summary>
        /// <returns></returns>
        string Consultar(string serial, string arquivo);

        /// <summary>
        /// Salva e exibe o documento auxiliar da nota fiscal eletrônica
        /// </summary>
        /// <param name="arquivo">Caminho completo do arquivo xml de processamento da NFe</param>
        /// <param name="logo">arquivo de imagem para ser adicionado ao Danfe - opcional</param>
        /// <returns></returns>
        string Danfe(string arquivo, string logo);

        /// <summary>
        /// Extrai a chave de assinatura do documento fiscal gerado pelo sistema
        /// </summary>
        /// <returns></returns>
        string GerarChave();

        /// <summary>
        /// Obtém os dados do certificado digital do cliente
        /// </summary>
        /// <returns></returns>
        string InstanciarCertificado(string serial);

        /// <summary>
        /// Atualiza a pasta padrão para persistência dos arquivos
        /// </summary>
        /// <param name="pasta"></param>
        void SetarPastaAtual(string pasta);

        /// <summary>
        /// Converte o xml do arquivo informado em formato 'texto'
        /// </summary>
        /// <param name="arquivo"></param>
        /// <returns></returns>
        string ObterXml(string arquivo);

        /// <summary>
        /// Retorna as mensagens geradas pelo sistema concatenados por ,(vírgula)
        /// </summary>
        /// <returns></returns>
        string Mensagens();

        /// <summary>
        /// Retorna as pendências apontadas pelo sistema concatenados por ,(vírgula)
        /// </summary>
        /// <returns></returns>
        string Erros();
    }
}