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
	public class ICMSST
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
        ///     Tributação pelo ICMS 41 – Não Tributado (v2.0</para>
        /// </summary>
        [XmlElement]
        public string CST { get; set; }

        /// <summary>
        /// Valor do BC do ICMS ST retido na UF remetente
        /// </summary>
        [XmlElement]
        public string vBCSTRet { get; set; }

        /// <summary>
        /// Valor do ICMS ST retido na UF remetente
        /// </summary>
        [XmlElement]
        public string vICMSSTRet { get; set; }

        /// <summary>
        /// Valor da BC do ICMS ST da UF destino
        /// </summary>
        [XmlElement]
        public string vBCSTDest { get; set; }

        /// <summary>
        /// Valor do ICMS ST da UF destino
        /// </summary>
        [XmlElement]
        public string vICMSSTDest { get; set; }
    }
}
