using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Reyx.Nfe.Schema200.Members;

namespace Reyx.Nfe.Schema200.Retorno
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace="http://www.portalfiscal.inf.br/nfe")]
    public class retCancNFe
    {
        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlElement]
        public infCanc infCanc { get; set; }

        /// <summary>
        /// Chave de Acesso da NF-e.
        /// </summary>
        [XmlElement]
        public string chNFe { get; set; }

        /// <summary>
        /// Data e hora de processamento
        /// Formato = AAAA-MM-DDTHH:MM:SS
        /// Preenchido com data e hora da homologação
        /// do Pedido.
        /// </summary>
        [XmlElement]
        public string dhRecebto { get; set; }

        /// <summary>
        /// Número do Protocolo de Cancelamento (vide
        /// item 5.6). O controle de numeração de
        /// Protocolo será único para todos os serviços.
        /// </summary>
        [XmlElement]
        public string nProt { get; set; }
    }
}