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
    [XmlRoot(Namespace="http://www.portalfiscal.inf.br/nfe")]
    public class retInutNFe
    {
        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// Dados da resposta - TAG a ser assinada
        /// </summary>
        [XmlElement]
        public Reyx.Nfe.Schema200.Members.infInut infInut { get; set; }
    }
}