using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections;

namespace Reyx.Nfe.Schema200.Envio
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace="http://www.portalfiscal.inf.br/nfe")]
    public class enviNFe
    {
        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// Identificador de controle do envio do lote.
        /// Número seqüencial auto-incremental, de
        /// controle correspondente ao identificador único
        /// do lote enviado. A responsabilidade de gerar e
        /// controlar esse número é exclusiva do
        /// contribuinte.
        /// </summary>
        [XmlElement]
        public string idLote { get; set; }

        /// <summary>
        /// Conjunto de NF-e transmitidas (máximo de 50
        /// NF-e), seguindo definição do Anexo I - Leiaute da NF-e.
        /// </summary>
        [XmlElement]
        public List<Reyx.Nfe.Schema200.NFe> NFe { get; set; }
    }
}