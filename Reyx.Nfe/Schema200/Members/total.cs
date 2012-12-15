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
	public class total
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public ICMSTot ICMSTot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public ISSQNtot ISSQNtot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public retTrib retTrib { get; set; }
    }
}
