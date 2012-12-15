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
	public class cobr
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public fat fat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public List<Reyx.Nfe.Schema200.Members.dup> dup { get; set; }
    }
}
