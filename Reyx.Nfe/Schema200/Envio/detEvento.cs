using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200.Envio
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace="http://www.portalfiscal.inf.br/nfe")]
    public class detEvento
    {
        /// <summary>
        /// Versão do Pedido de Cancelamento, deve ser informado com a
        /// mesma informação da tag verEvento (HP16)
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// “Cancelamento”
        /// </summary>
        [XmlElement]
        public string descEvento { get; set; }

        /// <summary>
        /// Informar o número do Protocolo de Autorização da NF-e a ser
        /// Cancelada. (vide item 5.6).
        /// </summary>
        [XmlElement]
        public string nProt { get; set; }

        /// <summary>
        /// Informar a justificativa do cancelamento
        /// </summary>
        [XmlElement]
        public string xJust { get; set; }
    }
}