using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200
{
    /// <summary>
    /// 
    /// </summary>
    public class infCons
    {
        /// <summary>
        /// Serviço solicitado 'CONS-CAD'
        /// </summary>
        [XmlElement]
        public string xServ { get; set; }

        /// <summary>
        /// Sigla da UF consultada, informar 'SU' para SUFRAMA.
        /// </summary>
        [XmlElement]
        public string UF { get; set; }

        /// <summary>
        /// Inscrição estadual do contribuinte
        /// </summary>
        [XmlElement]
        public string IE { get; set; }

        /// <summary>
        /// CNPJ do contribuinte
        /// </summary>
        [XmlElement]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF do contribuinte
        /// </summary>
        [XmlElement]
        public string CPF { get; set; }
    }
}
