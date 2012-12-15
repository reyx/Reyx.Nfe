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
	public class refNFP
    {
        /// <summary>
        /// Código da UF do emitente do Documento Fiscal
        /// <para>
        ///     Utilizar a Tabela do IBGE (Anexo VII - 
        ///     Tabela de UF, Município e País) (v2.0)
        /// </para>
        /// </summary>
        [XmlElement]
        public string cUF { get; set; }

        /// <summary>
        /// Ano e Mês de emissão da NFe (AAMM)
        /// </summary>
        [XmlElement]
        public string AAMM { get; set; }

        /// <summary>
        /// CNPJ do emitente
        /// </summary>
        [XmlElement]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF do emitente
        /// </summary>
        [XmlElement]
        public string CPF { get; set; }

        /// <summary>
        /// IE do emitente
        /// </summary>
        [XmlElement]
        public string IE { get; set; }

        /// <summary>
        /// Modelo do Documento Fiscal
        /// <para>01- NF avulsa</para>
        /// <para>04 – NF de Produtor</para>
        /// </summary>
        [XmlElement]
        public string mod { get; set; }

        /// <summary>
        /// Série do Documento Fiscal (informar zero se inexistente)
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
