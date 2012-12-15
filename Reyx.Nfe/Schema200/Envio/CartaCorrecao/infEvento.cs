using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200.Envio.CartaCorrecao
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class infEvento
    {
        /// <summary>
        /// <para>
        ///     Identificador da TAG a ser assinada, a regra de formação do Id é:
        /// </para>
        /// <para>
        ///     "ID" + tpEvento + chave da NF-e + nSeqEvento
        /// </para>
        /// </summary>
        [XmlAttribute]
        public string Id { get; set; }

        /// <summary>
        /// Código do órgão de recepção do Evento. Utilizar a Tabela do IBGE, utilizar 90 
        /// para identificar o Ambiente Nacional.
        /// </summary>
        [XmlElement]
        public string cOrgao { get; set; }

        /// <summary>
        /// Identificação do Ambiente: 
        /// <para>1 - Produção</para>
        /// <para>2 - Homologação</para>
        /// </summary>
        [XmlElement]
        public string tpAmb { get; set; }

        /// <summary>
        /// Informar o CNPJ do autor do Evento.
        /// </summary>
        [XmlElement]
        public string CNPJ { get; set; }

        /// <summary>
        /// Informar o CPF do autor do Evento.
        /// </summary>
        [XmlElement]
        public string CPF { get; set; }

        /// <summary>
        /// Chave de Acesso da NF-e vinculada ao evento.
        /// </summary>
        [XmlElement]
        public string chNFe { get; set; }

        /// <summary>
        /// Data e hora do evento no formato AAAA-MM-DDThh:mm:ssTZD (UTC - Universal 
        /// Coordinated Time, onde TZD pode ser -02:00 (Fernando de Noronha), -03:00 
        /// (Brasília) ou -04:00 (Manaus), no horário de verão serão -01:00, -02:00 e 
        /// -03:00. Ex.: 2010-08-19T13:00:15-03:00.
        /// </summary>
        [XmlElement]
        public string dhEvento { get; set; }

        /// <summary>
        /// Código do evento = 110110
        /// </summary>
        [XmlElement]
        public string tpEvento { get; set; }

        /// <summary>
        /// Sequencial do evento para o mesmo tipo de evento. Para maioria dos eventos 
        /// será 1, nos casos em que possa existir mais de um evento, como é o caso da 
        /// carta de correção, o autor do evento deve numerar de forma sequencial.
        /// </summary>
        [XmlElement]
        public string nSeqEvento { get; set; }

        /// <summary>
        /// Versão do evento
        /// </summary>
        [XmlElement]
        public string verEvento { get; set; }

        /// <summary>
        /// Informações da carta de correção
        /// </summary>
        [XmlElement]
        public Reyx.Nfe.Schema200.detEvento detEvento { get; set; }
    }
}