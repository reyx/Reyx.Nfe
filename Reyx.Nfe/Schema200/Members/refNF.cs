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
	public class refNF
    {
        /// <summary>
        /// Código da UF do emitente do Documento Fiscal
        /// <para>
        ///     Utilizar a Tabela do IBGE (Anexo VII - 
        ///     Tabela de UF, Município e País)
        /// </para>
        /// </summary>
        [XmlElement]
        public string cUF { get; set; }

        /// <summary>
        /// Ano e Mês de emissão da NFe
        /// <para>
        ///     AAMM da emissão da NF
        /// </para>
        /// </summary>
        [XmlElement]
        public string AAMM { get; set; }

        /// <summary>
        /// CNPJ do emitente
        /// </summary>
        [XmlElement]
        public string CNPJ { get; set; }

        /// <summary>
        /// Modelo do Documento Fiscal
        /// </summary>
        [XmlElement]
        public string mod { get; set; }

        /// <summary>
        /// Série do Documento Fiscal (informar zero se inexistente).
        /// </summary>
        [XmlElement]
        public string serie { get; set; }

        /// <summary>
        /// Número do Documento Fiscal
        /// </summary>
        [XmlElement]
        public string nNF { get; set; }
    }
}
