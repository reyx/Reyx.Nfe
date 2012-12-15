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
	public class ender
    {
        /// <summary>
        /// Nome do Logradouro
        /// </summary>
        [XmlElement]
        public string xLgr { get; set; }

        /// <summary>
        /// Número
        /// </summary>
        [XmlElement]
        public string nro { get; set; }

        /// <summary>
        /// Complemento
        /// </summary>
        [XmlElement]
        public string xCpl { get; set; }

        /// <summary>
        /// Nome do Bairro
        /// </summary>
        [XmlElement]
        public string xBairro { get; set; }

        /// <summary>
        /// Código do Município do Contruuinte, conforme Tabela do IBGE
        /// </summary>
        [XmlElement]
        public string cMun { get; set; }

        /// <summary>
        /// Nome do município
        /// </summary>
        [XmlElement]
        public string xMun { get; set; }

        /// <summary>
        /// Código do CEP
        /// </summary>
        [XmlElement]
        public string CEP { get; set; }
    }
}
