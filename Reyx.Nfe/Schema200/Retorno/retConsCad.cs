using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Reyx.Nfe.Schema200.Members;

namespace Reyx.Nfe.Schema200.Retorno
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class retConsCad
    {
        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlElement]
        public infCons infCons { get; set; }

        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlElement]
        public infCad infCad { get; set; }

        /// <summary>
        /// Versão do leiauteender
        /// </summary>
        [XmlElement]
        public ender ender { get; set; }
    }
}