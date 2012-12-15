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
	public class transp
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string modFrete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public transporta transporta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public retTransp retTransp { get; set; }

        /// <summary>
        /// Grupo Veículo
        /// </summary>
        [XmlElement]
        public veicTransp veicTransp { get; set; }

        /// <summary>
        /// Grupo Reboque
        /// </summary>
        [XmlElement]
        public reboque reboque { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vagao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string balsa { get; set; }

        /// <summary>
        /// Grupo Volumes
        /// </summary>
        [XmlElement]
        public List<Reyx.Nfe.Schema200.Members.vol> vol { get; set; }
    }
}
