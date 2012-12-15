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
	public class IPI
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string clEnq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string CNPJProd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string cSelo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string qSelo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string cEnq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public IPITrib IPITrib { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public IPINT IPINT { get; set; }
    }
}
