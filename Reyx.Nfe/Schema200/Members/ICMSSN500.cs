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
	public class ICMSSN500
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string orig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string CSOSN { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vBCSTRet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vICMSSTRet { get; set; }
    }
}
