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
	public class refECF
    {
        /// <summary>
        /// Modelo do Documento Fiscal
        /// <para>
        ///     Preencher com "2B", quando se tratar de Cupom 
        ///     Fiscal emitido por máquina registradora (não ECF), 
        ///     com "2C", quando se tratar de Cupom Fiscal PDV, ou
        ///     "2D", quando se tratar de Cupom Fiscal (emitido por ECF) (v2.0).
        /// </para>
        /// </summary>
        [XmlElement]
        public string mod { get; set; }

        /// <summary>
        /// Número de ordem seqüencial do ECF 
        /// </summary>
        [XmlElement]
        public string nECF { get; set; }

        /// <summary>
        /// Número do Contador de Ordem de Operação - COO
        /// </summary>
        [XmlElement]
        public string nCOO { get; set; }
    }
}
