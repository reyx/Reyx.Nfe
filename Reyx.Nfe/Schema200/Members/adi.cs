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
	public class adi
    {
        /// <summary>
        /// Numero da adição
        /// </summary>
        [XmlElement]
        public string nAdicao { get; set; }

        /// <summary>
        /// Numero seqüencial do item dentro da adição
        /// </summary>
        [XmlElement]
        public string nSeqAdic { get; set; }

        /// <summary>
        /// Código do fabricante estrangeiro
        /// </summary>
        [XmlElement]
        public string cFabricante { get; set; }

        /// <summary>
        /// Valor do desconto do item da DI – adição
        /// </summary>
        [XmlElement]
        public string vDescDI { get; set; }
    }
}
