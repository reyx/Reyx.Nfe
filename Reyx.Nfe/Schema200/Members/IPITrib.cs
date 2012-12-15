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
	public class IPITrib
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
        public string pIPI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string qUnid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vUnid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vIPI { get; set; }
    }
}
