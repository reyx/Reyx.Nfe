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
    [XmlType]
	public class infAdic
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string infAdFisco { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string infCpl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public List<Reyx.Nfe.Schema200.Members.obsCont> obsCont { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public List<Reyx.Nfe.Schema200.Members.obsFisco> obsFisco { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public List<Reyx.Nfe.Schema200.Members.procRef> procRef { get; set; }
    }
}