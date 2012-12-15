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
	public class exporta
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string UFEmbarq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string xLocEmbarq { get; set; }
    }
}
