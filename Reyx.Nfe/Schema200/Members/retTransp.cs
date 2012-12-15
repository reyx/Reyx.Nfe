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
	public class retTransp
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vServ { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vBCRet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string pICMSRet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vICMSRet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string CFOP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string cMunFG { get; set; }
    }
}
