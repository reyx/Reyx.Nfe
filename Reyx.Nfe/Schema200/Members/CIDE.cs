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
	public class CIDE
    {
        /// <summary>
        /// BC da CIDE em quantidade
        /// </summary>
        [XmlElement]
        public string qBCprod { get; set; }

        /// <summary>
        /// Valor da alíquota da CID
        /// </summary>
        [XmlElement]
        public string vAliqProd { get; set; }

        /// <summary>
        /// Valor da CIDE
        /// </summary>
        [XmlElement]
        public string vCIDE { get; set; }
    }
}
