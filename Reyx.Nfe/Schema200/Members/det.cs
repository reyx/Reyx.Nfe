using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Reyx.Nfe.Schema200.Members
{
    /// <summary>
	/// 
	/// </summary>
	public class det
    {
        /// <summary>
        /// Número do item
        /// </summary>
        [XmlAttribute]
        public string nItem { get; set; }

        /// <summary>
        /// TAG de grupo do detalhamento de Produtos e Serviços da NF-e
        /// </summary>
        [XmlElement]
        public prod prod { get; set; }

        /// <summary>
        /// Grupo de Tributos incidentes no Produto ou Serviço
        /// </summary>
        [XmlElement]
        public imposto imposto { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string infAdProd { get; set; }
    }
}