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
	public class ICMSSN101
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
        /// Código de Situação da Operação – Simples Nacional
        /// <para>
        ///     101- Tributada pelo Simples Nacional com permissão 
        ///     de crédito. (v.2.0)
        /// </para>
        /// </summary>
        [XmlElement]
        public string CSOSN { get; set; }

        /// <summary>
        /// Alíquota aplicável de cálculo do crédito (Simples Nacional).
        /// </summary>
        [XmlElement]
        public string pCredSN { get; set; }

        /// <summary>
        /// Valor crédito do ICMS que pode ser aproveitado nos termos 
        /// do art. 23 da LC 123 (Simples Nacional)
        /// </summary>
        [XmlElement]
        public string vCredICMSSN { get; set; }
    }
}
