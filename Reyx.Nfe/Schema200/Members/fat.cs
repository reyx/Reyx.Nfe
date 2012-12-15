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
	public class fat
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string nFat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vOrig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vDesc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vLiq { get; set; }
    }
}
