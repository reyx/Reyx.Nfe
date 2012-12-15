using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200.Retorno
{
    /// <summary>
    /// 
    /// </summary>
    public class infEvento
    {
        /// <summary>
        /// <para>
        ///     Identificador da TAG a ser assinada, somente deve ser informado se o 
        ///     órgão de registro assinar a resposta.
        /// </para>
        /// <para>
        ///     Em caso de assinatura da resposta pelo órgão de registro, preencher 
        ///     com o número do protocolo, precedido pela literal “ID”
        /// </para>
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
        /// Versão da aplicação que registrou o Evento, utilizar literal que permita a 
        /// identificação do órgão, como a sigla da UF ou do órgão.
        /// </summary>
        [XmlElement]
        public string verAplic { get; set; }

        /// <summary>
        /// Código da UF que registrou o Evento. Utilizar 90 para o Ambiente Nacional.
        /// </summary>
        [XmlElement]
        public string cOrgao { get; set; }

        /// <summary>
        /// Código do status da resposta
        /// </summary>
        [XmlElement]
        public string cStat { get; set; }

        /// <summary>
        /// Descrição do status da resposta.
        /// </summary>
        [XmlElement]
        public string xMotivo { get; set; }

        /// <summary>
        /// Chave de Acesso da NF-e vinculada ao evento.
        /// </summary>
        [XmlElement]
        public string chNFe { get; set; }

        /// <summary>
        /// Código do Tipo do Evento.
        /// </summary>
        [XmlElement]
        public string tpEvento { get; set; }

        /// <summary>
        /// Descrição do Evento – “Carta de Correção registrada”
        /// </summary>
        [XmlElement]
        public string xEvento { get; set; }

        /// <summary>
        /// Sequencial do evento para o mesmo tipo de evento. Para maioria dos eventos 
        /// será 1, nos casos em que possa existir mais de um evento, como é o caso da 
        /// carta de correção, o autor do evento deve numerar de forma sequencial.
        /// </summary>
        [XmlElement]
        public string nSeqEvento { get; set; }

        /// <summary>
        /// Informar o CNPJ do destinatário da NF-e.
        /// </summary>
        [XmlElement]
        public string CNPJDest { get; set; }

        /// <summary>
        /// Informar o CPF do destinatário da NF-e.
        /// </summary>
        [XmlElement]
        public string CPFDest { get; set; }

        /// <summary>
        /// email do destinatário informado na NF-e.
        /// </summary>
        [XmlElement]
        public string emailDest { get; set; }

        /// <summary>
        /// Data e hora de registro do evento no formato AAAA-MM-DDTHH:MM:SSTZD 
        /// (formato UTC, onde TZD é +HH:MM ou –HH:MM), se o evento for rejeitado 
        /// informar a data e hora de recebimento do evento.
        /// </summary>
        [XmlElement]
        public string dhRegEvento { get; set; }

        /// <summary>
        /// Número do Protocolo da NF-e 1 posição (1-Secretaria da Fazenda Estadual, 2-RFB), 
        /// 2 posições para o código da UF, 2 posições para o ano e 10 posições para o 
        /// sequencial no ano.
        /// </summary>
        [XmlElement]
        public string nProt { get; set; }
    }
}
