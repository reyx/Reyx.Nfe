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
	public class enderCom
    {
        /// <summary>
        /// CNPJ
        /// </summary>
        [XmlElement]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
        [XmlElement]
        public string CPF { get; set; }

        /// <summary>
        /// Logradouro
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
        /// Bairro
        /// </summary>
        [XmlElement]
        public string xBairro { get; set; }

        /// <summary>
        /// Cósigo do Município
        /// </summary>
        [XmlElement]
        public string cMun { get; set; }

        /// <summary>
        /// Nome do Município
        /// </summary>
        [XmlElement]
        public string xMun { get; set; }

        /// <summary>
        /// Sigla da UF
        /// </summary>
        [XmlElement]
        public string UF { get; set; }
    }
}
