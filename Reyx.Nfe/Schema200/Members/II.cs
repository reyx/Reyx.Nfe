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
	public class II
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vBC { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vDespAdu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vII { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vIOF { get; set; }
    }
}
