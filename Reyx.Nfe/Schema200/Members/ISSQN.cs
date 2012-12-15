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
	public class ISSQN
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
        public string vAliq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vISSQN { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string cMunFG { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string cListServ { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string cSitTrib { get; set; }
    }
}
