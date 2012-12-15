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
	public class ICMSSN202
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
        public string modBCST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string pMVAST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string pRedBCST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vBCST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string pICMSST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vICMSST { get; set; }
    }
}
