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
	public class procRef
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string nProc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string indProc { get; set; }
    }
}
