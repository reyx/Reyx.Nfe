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
	public class ISSQNtot
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vServ { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vBC { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vISS { get; set; }

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
    }
}
