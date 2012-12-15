using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Reyx.Nfe.Schema200.Members;

namespace Reyx.Nfe.Schema200
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace="http://www.portalfiscal.inf.br/nfe")]
    public class cancNFe
    {
        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// Dados do Pedido - TAG a ser assinada
        /// </summary>
        [XmlElement]
        public Reyx.Nfe.Schema200.Members.infCanc infCanc { get; set; }
    }
}