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
	public class compra
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string xNEmp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string xPed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string xCont { get; set; }
    }
}
