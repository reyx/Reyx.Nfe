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
	public class med
    {
        /// <summary>
        /// Número do Lote de medicamentos ou de matériasprimas
        /// farmacêuticas
        /// </summary>
        [XmlElement]
        public string nLote { get; set; }

        /// <summary>
        /// Quantidade de produto no Lote de medicamentos ou de
        /// matérias-primas farmacêuticas
        /// </summary>
        [XmlElement]
        public string qLote { get; set; }

        /// <summary>
        /// Data de fabricação
        /// <para>Formato AAAA-MM-DD</para>
        /// </summary>
        [XmlElement]
        public string dFab { get; set; }

        /// <summary>
        /// Data de validade
        /// <para>Formato AAAA-MM-DD</para>
        /// </summary>
        [XmlElement]
        public string dVal { get; set; }

        /// <summary>
        /// Preço máximo consumidor
        /// </summary>
        [XmlElement]
        public string vPMC { get; set; }
    }
}
