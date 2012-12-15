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
	public class cana
    {
        /// <summary>
        /// Identificação da safra AAAA ou AAAA/AAAA
        /// </summary>
        [XmlElement]
        public string safra { get; set; }

        /// <summary>
        /// Mês e ano de referência MM/AAAA.
        /// </summary>
        [XmlElement]
        public string @ref { get; set; }

        /// <summary>
        /// Grupo de Fornecimento diário de cana
        /// </summary>
        [XmlElement]
        public List<forDia> forDia { get; set; }

        /// <summary>
        /// Grupo de Deduções – Taxas e Contribuições
        /// </summary>
        [XmlElement]
        public List<deduc> deduc { get; set; }
    }
}