using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200.Retorno
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class retConsSitNFe
    {
        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// Identificação do Ambiente: 
        /// <para>1 - Produção</para>
        /// <para>2 - Homologação</para>
        /// </summary>
        [XmlElement]
        public string tpAmb { get; set; }

        /// <summary>
        /// Versão do Aplicativo que recebeu o Lote. A versão deve ser iniciada 
        /// com a sigla da UF nos casos de WS próprio ou a sigla SCAN, SVAN ou 
        /// SVRS nos demais casos.
        /// </summary>
        [XmlElement]
        public string verAplic { get; set; }

        /// <summary>
        /// Código do status da resposta.
        /// </summary>
        [XmlElement]
        public string cStat { get; set; }

        /// <summary>
        /// Descrição literal do status da resposta
        /// </summary>
        [XmlElement]
        public string xMotivo { get; set; }

        /// <summary>
        /// Código da UF que atendeu a solicitação.
        /// </summary>
        [XmlElement]
        public string cUF { get; set; }

        /// <summary>
        /// Chave de Acesso da NF-e consultada.
        /// </summary>
        [XmlElement]
        public string chNFe { get; set; }

        /// <summary>
        /// Protocolo de autorização ou denegação de uso
        /// do NF-e (vide item 4.2.2).
        /// Informar se localizado uma NF-e com cStat =
        /// 100 (uso autorizado) ou 110 (uso denegado).
        /// </summary>
        [XmlElement]
        public Reyx.Nfe.Schema200.protNFe protNFe { get; set; }

        /// <summary>
        /// Protocolo de homologação de cancelamento
        /// de NF-e (vide item 4.3.2).
        /// Informar se localizado uma NF-e com cStat =
        /// 101 (cancelado).
        /// </summary>
        [XmlElement]
        public Reyx.Nfe.Schema200.Retorno.retCancNFe retCancNFe { get; set; }
    }
}