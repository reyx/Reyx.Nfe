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
    public class consReciNFe
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
        /// Número do Recibo
        /// Número gerado pelo Portal da Secretaria de
        /// Fazenda Estadual
        /// </summary>
        [XmlElement]
        public string nRec { get; set; }
    }
}
