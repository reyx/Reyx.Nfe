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
	public class COFINS
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public COFINSAliq COFINSAliq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public COFINSQtde COFINSQtde { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public COFINSNT COFINSNT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public COFINSOutr COFINSOutr { get; set; }
    }
}
