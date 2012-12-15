using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200.Envio.Cancelamento
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class evtCancNFe
    {
        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// Identificador de controle do Lote de envio do Evento.
        /// Número sequencial autoincremental único para identificação do
        /// Lote. A responsabilidade de gerar e controlar é exclusiva do autor
        /// do evento. O Web Service não faz qualquer uso deste
        /// identificador.
        /// </summary>
        [XmlAttribute]
        public string idLote { get; set; }

        /// <summary>
        /// Evento, um lote pode conter até 20 eventos
        /// </summary>
        [XmlElement]
        public List<Reyx.Nfe.Schema200.Envio.Cancelamento.evento> evento { get; set; }

        /// <summary>
        /// Grupo de informações do registro do Evento
        /// </summary>
        [XmlElement]
        public Reyx.Nfe.Schema200.Retorno.infEvento infEvento { get; set; }
    }
}
