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
	public class infInut
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
        /// Identificação do Ambiente: 
        /// <para>1 - Produção</para>
        /// <para>2 - Homologação</para>
        /// </summary>
        [XmlElement]
        public string verAplic { get; set; }

        /// <summary>
        /// Código do status da resposta (vide item 5.1.1).
        /// </summary>
        [XmlElement]
        public string cStat { get; set; }

        /// <summary>
        /// Descrição literal do status da resposta.
        /// </summary>
        [XmlElement]
        public string xMotivo { get; set; }

        /// <summary>
        /// Código da UF que atendeu a solicitação.
        /// </summary>
        [XmlElement]
        public string cUF { get; set; }

        /// <summary>s
        /// Ano de inutilização da numeração
        /// </summary>
        [XmlElement]
        public string ano { get; set; }

        /// <summary>
        /// CNPJ do emitente
        /// </summary>
        [XmlElement]
        public string CNPJ { get; set; }

        /// <summary>
        /// Modelo da NF-e
        /// </summary>
        [XmlElement]
        public string mod { get; set; }

        /// <summary>
        /// Série da NF-e
        /// </summary>
        [XmlElement]
        public string serie { get; set; }

        /// <summary>
        /// Número da NF-e inicial a ser inutilizada
        /// </summary>
        [XmlElement]
        public string nNFIni { get; set; }

        /// <summary>
        /// Número da NF-e final a ser inutilizada
        /// </summary>
        [XmlElement]
        public string nNFFin { get; set; }

        /// <summary>
        /// Data e hora de processamento
        /// Formato = AAAA-MM-DDTHH:MM:SS
        /// Preenchido com data e hora da gravação no
        /// Banco de Dados em caso de Confirmação.
        /// Em caso de Rejeição, com data e hora dorecebimento do Pedido.
        /// </summary>
        [XmlElement]
        public string dhRecbto { get; set; }

        /// <summary>
        /// Número do Protocolo de Inutilização (vide item 5.4).
        /// </summary>
        [XmlElement]
        public string nProt { get; set; }
    }
}
