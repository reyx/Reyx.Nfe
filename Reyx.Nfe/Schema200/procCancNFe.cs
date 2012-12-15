using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class procCancNFe
    {
        /// <summary>
        /// Versão do laioute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// Dados do Pedido de Cancelamento (item 4.3.1)
        /// </summary>
        [XmlElement]
        public cancNFe cancNFe { get; set; }

        /// <summary>
        /// Dados da homologação do pedido (item 4.3.2)
        /// </summary>
        [XmlElement]
        public Reyx.Nfe.Schema200.Retorno.retCancNFe retCancNFe { get; set; }
    }
}
