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
	public class ICMSTot
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vBC { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vICMS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vBCST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vProd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vFrete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vSeg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vDesc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vII { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vIPI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vPIS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vCOFINS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vOutro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vNF { get; set; }
    }
}
