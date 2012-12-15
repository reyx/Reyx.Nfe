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
	public class retTrib
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vRetPIS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vRetCOFINS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vRetCSLL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vBCIRRF { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vIRRF { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vBCRetPrev { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vRetPrev { get; set; }
    }
}
