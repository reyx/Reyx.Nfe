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
    public class protNFe
    {
        /// <summary>
        /// Versão do leiaute das informações de Protocolo.
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// Informações do Protocolo de resposta.
        /// TAG a ser assinada
        /// </summary>
        [XmlElement]
        public infProt infProt { get; set; }
    }
}