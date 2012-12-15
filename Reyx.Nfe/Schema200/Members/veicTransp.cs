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
	public class veicTransp
    {
        /// <summary>
        /// Placa do Veículo
        /// </summary>
        [XmlElement]
        public string placa { get; set; }

        /// <summary>
        /// Sigla da UF
        /// </summary>
        [XmlElement]
        public string UF { get; set; }

        /// <summary>
        /// Registro Nacional de Transportador de Carga (ANTT)
        /// </summary>
        [XmlElement]
        public string RNTC { get; set; }
    }
}
