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
	public class deduc
    {
        /// <summary>
        /// Descrição da Dedução
        /// </summary>
        [XmlElement]
        public List<forDia> xDed { get; set; }

        /// <summary>
        /// Valor da Dedução
        /// </summary>
        [XmlElement]
        public List<forDia> vDed { get; set; }

        /// <summary>
        /// Valor dos Fornecimentos
        /// </summary>
        [XmlElement]
        public List<forDia> vFor { get; set; }

        /// <summary>
        /// Valor Total da Dedução
        /// </summary>
        [XmlElement]
        public List<forDia> vTotDed { get; set; }

        /// <summary>
        /// Valor Líquido dos Fornecimentos
        /// </summary>
        [XmlElement]
        public List<forDia> vLiqFor { get; set; }
    }
}
