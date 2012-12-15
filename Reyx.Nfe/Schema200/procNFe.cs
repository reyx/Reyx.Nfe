using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Reyx.Nfe.XmlParser;

namespace Reyx.Nfe.Schema200
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe", ElementName="nfeProc")]
    public class procNFe
    {
        /// <summary>
        /// Versão do laioute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// Dados da NF-e, inclusive com os dados da assinatura (Anexo I)
        /// </summary>
        [XmlElement]
        public Reyx.Nfe.Schema200.NFe NFe { get; set; }

        /// <summary>
        /// Dados do Protocolo de Autorização de Uso (item 4.2.2)
        /// </summary>
        [XmlElement]
        public Reyx.Nfe.Schema200.protNFe protNFe { get; set; }
    }
}