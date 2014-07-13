using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reyx.Nfe
{
    internal class Util : IUtil
    {
        public string Assinar(string XMLString, string RefUri, string NomeTitular, out int resultado, out string msgResultado)
        {
            throw new NotImplementedException();
        }

        public int CriarChaveNFe(string cUF, string Ano, string Mes, string CNPJ, string modelo, string serie, string numero, string tpEmis, string codigoSeguranca, out string msgResultado, out string cNF, out string cDV, out string chaveNFe)
        {
            throw new NotImplementedException();
        }

        public int CriarCodigoBarrasContingencia(string cUF, int tipoEmissao, string CNPJ, double valorTotalNFe, int destaqueICMSproprio, int destaqueICMSST, DateTime dataEmissaoNFe, out string codigoBarras, out string msgResultado)
        {
            throw new NotImplementedException();
        }

        public string CriarDPEC(string NFeLote, out int resultado, out string msgResultado, out string erroXML)
        {
            throw new NotImplementedException();
        }

        public string CriarProcCancNFe(string siglaWS, ref string cancNFe, out string protocolo, out string retCancNFe, out int resultado, string nomeCertificado, out string msgResultado, string proxy, string usuario, string senha)
        {
            throw new NotImplementedException();
        }

        public string CriarProcNFe(string siglaWS, ref string NFeAssinada, out string protocolo, out string retCancNFe, out int resultado, string nomeCertificado, out string msgResultado, string proxy, string usuario, string senha)
        {
            throw new NotImplementedException();
        }

        public string ObterNumeroSerialCertificado(ref string serial)
        {
            throw new NotImplementedException();
        }

        public int ValidarAssinatura(string XML, out string msgResultado, out string Titular, out string CNPJ, out string NroSerie, out string Emissor, out string InicioValidade, out string FimValidade)
        {
            throw new NotImplementedException();
        }

        public int ValidarXML(string XML, int tipoXML, out string msgResultado, out int qtdeErros, out string erroXML)
        {
            throw new NotImplementedException();
        }
    }
}