using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reyx.Nfe
{
    interface IUtil
    {
        string Assinar(string XMLString, string RefUri, string NomeTitular, out int resultado, out string msgResultado);
        int CriarChaveNFe(string cUF, string Ano, string Mes, string CNPJ, string modelo, string serie, string numero, string tpEmis, string codigoSeguranca, out string msgResultado, out string cNF, out string cDV, out string chaveNFe);
        int CriarCodigoBarrasContingencia(string cUF, int tipoEmissao, string CNPJ, double valorTotalNFe, int destaqueICMSproprio, int destaqueICMSST, DateTime dataEmissaoNFe, out string codigoBarras, out string msgResultado);
        string CriarDPEC(string NFeLote, out int resultado, out string msgResultado, out string erroXML);
        string CriarProcCancNFe(string siglaWS, ref string cancNFe, out string protocolo, out string retCancNFe, out int resultado, string nomeCertificado, out string msgResultado, string proxy, string usuario, string senha);
        string CriarProcNFe(string siglaWS, ref string NFeAssinada, out string protocolo, out string retCancNFe, out int resultado, string nomeCertificado, out string msgResultado, string proxy, string usuario, string senha);
        string ObterNumeroSerialCertificado(ref string serial);
        int ValidarAssinatura(string XML, out string msgResultado, out string Titular, out string CNPJ, out string NroSerie, out string Emissor, out string InicioValidade, out string FimValidade);
        int ValidarXML(string XML, int tipoXML, out string msgResultado, out int qtdeErros, out string erroXML);
    }
}
