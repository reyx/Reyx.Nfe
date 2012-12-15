using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reyx.Nfe
{
    class WebServices : IWebServices
    {
        public string CancelarNFe(string siglaWS, int tipoAmbiente, string nomeCertificado, string versao, out string msgDados, out string msgRetWS, out int cStat, out string msgResultado, string chaveNFe, string nProtocolo, string justificativa, out string nProtocoloCanc, out string dProtocoloCanc, string proxy, string usuario, string senha, string licenca)
        {
            throw new NotImplementedException();
        }

        public int ConsultarCadastro(string siglaUF, int tipoAmbiente, string nomeCertificado, string versao, out string msgDados, out string msgRetWS, out string msgResultado, string tpArgumento, string argumento, string proxy, string usuario, string senha)
        {
            throw new NotImplementedException();
        }

        public int ConsultarDPEC(int tipoAmbiente, string nomeCertificado, out string msgDados, out string msgRetWS, out string msgResultado, string tpArgumento, string argumento, out string DPEC, string proxy, string usuario, string senha, string licenca)
        {
            throw new NotImplementedException();
        }

        public int ConsultarNF(string siglaWS, int tipoAmbiente, string nomeCertificado, string versao, out string msgDados, out string msgRetWS, out string msgResultado, string chaveNFe, string proxy, string usuario, string senha)
        {
            throw new NotImplementedException();
        }

        public int ConsultarStatus(string siglaWS, string siglaUF, int tipoAmbiente, string nomeCertificado, string versao, out string msgDados, out string msgRetWS, out string msgResultado, string proxy, string usuario, string senha)
        {
            throw new NotImplementedException();
        }

        public int EnviarDPEC(ref string DPEC, string nomeCertificado, out string DPECAssinado, out string msgRetWS, out string msgResultado, out string dhRegDPEC, out string nRegDPEC, string proxy, string usuario, string senha, string licenca)
        {
            throw new NotImplementedException();
        }

        public int EnviarLote(string siglaWS, int tipoAmbiente, string nomeCertificado, string versao, ref string msgDados, out string msgRetWS, out string msgResultado, out string nRec, out string dhRecbto, out string tMed, string proxy, string usuario, string senha, string licenca)
        {
            throw new NotImplementedException();
        }

        public string EnviarNFe(string siglaWS, ref string NFe, string nomeCertificado, string versao, out string msgDados, out string msgRetWS, out int cStat, out string msgResultado, out string nroRecibo, out string dhRecbto, out string tMed, string proxy, string usuario, string senha, string licenca)
        {
            throw new NotImplementedException();
        }

        public string InutilizarNumerosNF(string siglaWS, int tipoAmbiente, string nomeCertificado, string versao, out string msgDados, out string msgRetWS, out int cStat, out string msgResultado, string cUF, string ano, string CNPJ, string modelo, string serie, string nroNFeInicial, string nroNFeFinal, string justificativa, out string nProtocoloInut, out string dProtocoloInut, string proxy, string usuario, string senha, string licenca)
        {
            throw new NotImplementedException();
        }
    }
}