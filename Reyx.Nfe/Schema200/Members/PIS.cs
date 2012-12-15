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
	public class PIS
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public PISAliq PISAliq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public PISQtde PISQtde { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public PISNT PISNT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public PISOutr PISOutr { get; set; }
    }
}
