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
	public class NFref
    {
        /// <summary>
        /// Chave de acesso da NF-e referenciada
        /// <para>
        ///     Utilizar esta TAG para referenciar uma Nota 
        ///     Fiscal Eletrônica emitida anteriormente, 
        ///     vinculada a NF-e atual.
        /// </para>
        /// </summary>
        [XmlElement]
        public string refNFe { get; set; }
        
        /// <summary>
        /// Grupo de informações da NF referenciada
        /// </summary>
        [XmlElement]
        public refNF refNF { get; set; }

        /// <summary>
        /// Grupo de informações da NF de produtor rural referenciada
        /// </summary>
        [XmlElement]
        public refNFP refNFP { get; set; }

        /// <summary>
        /// Chave de acesso do CT-e referenciada
        /// </summary>
        [XmlElement]
        public string refCTe { get; set; }

        /// <summary>
        /// Informações do Cupom Fiscal referenciado
        /// </summary>
        [XmlElement]
        public refECF refECF { get; set; }
    }
}
