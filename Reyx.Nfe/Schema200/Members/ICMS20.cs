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
	public class ICMS20
    {
        /// <summary>
        /// Origem da mercadoria
        /// <para>0 - Nacional</para>
        /// <para>1 - Estrangeira - Importação direta</para>
        /// <para>2 - Estrangeira - Adquirida no meracado interno</para>
        /// </summary>
        [XmlElement]
        public string orig { get; set; }

        /// <summary>
        /// Tributação do ICMS:
        /// <para>20 - Com redução de base de cálculo</para>
        /// </summary>
        [XmlElement]
        public string CST { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS
        /// <para>0 - Margem Valor Agregado (%)</para>
        /// <para>1 - Pauta (Valor)</para>
        /// <para>2 - Preço Tabelado Máx. (valor)</para>
        /// <para>3 - valor da operação</para>
        /// </summary>
        [XmlElement]
        public string modBC { get; set; }

        /// <summary>
        /// Percentual da Redução de BC
        /// </summary>
        [XmlElement]
        public string pRedBC { get; set; }

        /// <summary>
        /// Valor da BC do ICMS
        /// </summary>
        [XmlElement]
        public string vBC { get; set; }

        /// <summary>
        /// Alíquota do imposto
        /// </summary>
        [XmlElement]
        public string pICMS { get; set; }

        /// <summary>
        /// Valor do ICMS
        /// </summary>
        [XmlElement]
        public string vICMS { get; set; }
    }
}
