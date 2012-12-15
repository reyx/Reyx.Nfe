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
    public class consSitNFe
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
        /// Serviço solicitado "CONSULTAR"
        /// </summary>
        [XmlElement]
        public string xServ { get; set; }

        /// <summary>
        /// Chave de Acesso da NF-e.
        /// </summary>
        [XmlElement]
        public string chNFe { get; set; }
    }
}