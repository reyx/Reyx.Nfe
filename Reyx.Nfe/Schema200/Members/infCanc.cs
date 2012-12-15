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
	public class infCanc
    {
        /// <summary>
        /// Identificador da TAG a ser assinada
        /// Informar a chave de acesso precedida do literal "ID"
        /// </summary>
        [XmlAttribute]
        public string Id { get; set; }

        /// <summary>
        /// Identificação do Ambiente: 
        /// <para>1 - Produção</para>
        /// <para>2 - Homologação</para>
        /// </summary>
        [XmlElement]
        public string tpAmb { get; set; }

        /// <summary>
        /// Serviço solicitado 'CANCELAR'
        /// </summary>
        [XmlElement]
        public string xServ { get; set; }

        /// <summary>
        /// Chave de Acesso da NF-e (vide item 5.4)
        /// </summary>
        [XmlElement]
        public string chNFe { get; set; }

        /// <summary>
        /// Informar o número do Protocolo de
        /// Autorização da NF-e a ser Cancelada (vide item 5.4).
        /// </summary>
        [XmlElement]
        public string nProt { get; set; }

        /// <summary>
        /// Informar a justificativa do cancelamento
        /// </summary>
        [XmlElement]
        public string xJust { get; set; }
    }
}
