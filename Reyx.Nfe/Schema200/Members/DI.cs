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
	public class DI
    {
        /// <summary>
        /// Número do Documento de Importação DI/DSI/DA
        /// </summary>
        [XmlElement]
        public string nDI { get; set; }

        /// <summary>
        /// Data de Registro da DI/DSI/DA
        /// <para>Formato "AAAA-MM-DD"</para>
        /// </summary>
        [XmlElement]
        public string dDI { get; set; }

        /// <summary>
        /// Local de desembaraço
        /// </summary>
        [XmlElement]
        public string xLocDesemb { get; set; }

        /// <summary>
        /// Sigla da UF onde ocorreu o Desembaraço Aduaneiro
        /// </summary>
        [XmlElement]
        public string UFDesemb { get; set; }

        /// <summary>
        /// Data do Desembaraço Aduaneiro
        /// <para>Formato "AAAA-MM-DD"</para>
        /// </summary>
        [XmlElement]
        public string dDesemb { get; set; }

        /// <summary>
        /// Código do exportador
        /// </summary>
        [XmlElement]
        public string cExportador { get; set; }

        /// <summary>
        /// Adições
        /// </summary>
        [XmlElement]
        public List<adi> adi { get; set; }
    }
}