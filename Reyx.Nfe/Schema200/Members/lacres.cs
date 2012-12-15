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
	public class lacres
    {
        /// <summary>
        /// Número dos Lacres
        /// </summary>
        [XmlElement]
        public string nLacre { get; set; }
    }
}
