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
	public class arma
    {
        /// <summary>
        /// Indicador do tipo de arma de fogo
        /// <para>0 - Uso permitido</para>
        /// <para>1 - Uso restrito</para>
        /// </summary>
        [XmlElement]
        public string tpArma { get; set; }

        /// <summary>
        /// Número de série da arma
        /// </summary>
        [XmlElement]
        public string nSerie { get; set; }

        /// <summary>
        /// Número de série do cano
        /// </summary>
        [XmlElement]
        public string nCano { get; set; }

        /// <summary>
        /// Descrição completa da arma, compreendendo: calibre,
        /// marca, capacidade, tipo de funcionamento, comprimento e
        /// demais elementos que permitam a sua perfeita identificação.
        /// </summary>
        [XmlElement]
        public string descr { get; set; }
    }
}
