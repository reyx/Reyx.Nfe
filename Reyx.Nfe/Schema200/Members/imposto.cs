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
	public class imposto
    {
        /// <summary>
        /// Grupo do ICMS da Operação própria e ST
        /// </summary>
        [XmlElement]
        public ICMS ICMS { get; set; }

        /// <summary>
        /// Grupo do IPI
        /// <para>Informar apenas quando o item for sujeito ao IPI</para>
        /// </summary>
        [XmlElement]
        public IPI IPI { get; set; }

        /// <summary>
        /// Grupo do II
        /// <para>Informar apenas quando o item for sujeito ao II</para>
        /// </summary>
        [XmlElement]
        public II II { get; set; }

        /// <summary>
        /// Grupo do PIS
        /// </summary>
        [XmlElement]
        public PIS PIS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public PISST PISST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public COFINS COFINS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public COFINSST COFINSST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public ISSQN ISSQN { get; set; }
    }
}