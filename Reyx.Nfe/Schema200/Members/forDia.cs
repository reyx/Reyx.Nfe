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
	public class forDia
    {
        /// <summary>
        /// Dia
        /// </summary>
        [XmlElement]
        public string dia { get; set; }

        /// <summary>
        /// Quantidade
        /// </summary>
        [XmlElement]
        public string qtde { get; set; }

        /// <summary>
        /// Quantidade Total do Mês
        /// </summary>
        [XmlElement]
        public string qTotMes { get; set; }

        /// <summary>
        /// Quantidade Total Anterior
        /// </summary>
        [XmlElement]
        public string qTotAnt { get; set; }

        /// <summary>
        /// Quantidade Total Gera
        /// </summary>
        [XmlElement]
        public string qTotGer { get; set; }
    }
}
