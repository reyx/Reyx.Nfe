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
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class consStatServ
    {
        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// Identificação do Ambiente:
        /// <para>1 – Produção</para>
        /// <para>2 – Homologação</para>
        /// </summary>
        [XmlElement]
        public string tpAmb { get; set; }

        /// <summary>
        /// Código da UF consultada
        /// </summary>
        [XmlElement]
        public string cUF { get; set; }

        /// <summary>
        /// Serviço solicitado 'STATUS'
        /// </summary>
        [XmlElement]
        public string xServ { get; set; }
    }
}
