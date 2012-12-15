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
	public class ICMS60
    {
        /// <summary>
        /// Origem da mercadoria
        /// <para>0 - Nacional</para>
        /// <para>1 - Estrangeira - Importação direta</para>
        /// <para>2 - Estrangeira - Adquirida no meracado interno</para>
        /// </summary>
        [XmlElement]
        public string orig { get; set; }

        /// <summary>
        /// Tributação do ICMS:
        /// <para>
        ///     Tributação pelo ICMS 60 - ICMS cobrado
        ///     anteriormente por substituição tributária
        /// </para>
        /// </summary>
        [XmlElement]
        public string CST { get; set; }

        /// <summary>
        /// Valor da BC do ICMS ST retido
        /// </summary>
        [XmlElement]
        public string vBCSTRet { get; set; }

        /// <summary>
        /// Valor do ICMS ST retido
        /// </summary>
        [XmlElement]
        public string vICMSSTRet { get; set; }
    }
}
