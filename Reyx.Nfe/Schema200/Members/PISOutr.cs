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
	public class PISOutr
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string CST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vBC { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string pPIS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string qBCProd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vAliqProd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vPIS { get; set; }
    }
}
