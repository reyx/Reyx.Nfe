using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200.Members
{
    /// <summary>
    /// 
    /// </summary>
    /// <summary>
	/// 
	/// </summary>
	public class transporta
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string CNPJ { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string CPF { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string xNome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string IE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string xEnder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string xMun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string UF { get; set; }
    }
}
