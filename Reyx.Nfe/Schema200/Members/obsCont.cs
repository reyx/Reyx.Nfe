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
	public class obsCont
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string xCampo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string xTexto { get; set; }
    }
}
