using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections;

namespace Reyx.Nfe.Schema200.Envio.CartaCorrecao
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace="http://www.portalfiscal.inf.br/nfe")]
    public class evento
    {
        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }
        
        /// <summary>
        /// Grupo de informações do registro do Evento
        /// </summary>
        [XmlElement]
        public Reyx.Nfe.Schema200.Envio.CartaCorrecao.infEvento infEvento { get; set; }
    }
}