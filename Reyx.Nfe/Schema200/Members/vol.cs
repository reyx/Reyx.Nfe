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
	public class vol
    {
        /// <summary>
        /// Quantidade de volumes transportados
        /// </summary>
        [XmlElement]
        public string qVol { get; set; }

        /// <summary>
        /// Espécie dos volumes transportados
        /// </summary>
        [XmlElement]
        public string esp { get; set; }

        /// <summary>
        /// Marca dos volumes transportados
        /// </summary>
        [XmlElement]
        public string marca { get; set; }

        /// <summary>
        /// Numeração dos volumes transportados
        /// </summary>
        [XmlElement]
        public string nVol { get; set; }

        /// <summary>
        /// Peso Líquido (em kg)
        /// </summary>
        [XmlElement]
        public string pesoL { get; set; }

        /// <summary>
        /// Peso Bruto (em kg)
        /// </summary>
        [XmlElement]
        public string pesoB { get; set; }

        /// <summary>
        /// Grupo de Lacres
        /// </summary>
        [XmlElement]
        public List<Reyx.Nfe.Schema200.Members.lacres> lacres { get; set; }
    }
}
