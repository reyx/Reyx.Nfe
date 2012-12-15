using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200
{
    /// <summary>
    /// Informações do Protocolo de resposta. TAG a ser assinada
    /// </summary>
    public class infProt
    {
        /// <summary>
        /// Identificador da TAG a ser assinada, somente
        /// precisa ser informado se a UF assinar a
        /// resposta.
        /// Em caso de assinatura da resposta pela
        /// SEFAZ preencher o campo com o Nro do
        /// Protocolo, precedido com o literal "ID"
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
        /// Versão do Aplicativo que recebeu o Lote. A versão deve ser iniciada 
        /// com a sigla da UF nos casos de WS próprio ou a sigla SCAN, SVAN ou 
        /// SVRS nos demais casos.
        /// </summary>
        [XmlElement]
        public string verAplic { get; set; }

        /// <summary>
        /// Chave de Acesso da NF-e (vide item 5.4)
        /// </summary>
        [XmlElement]
        public string chNFe { get; set; }

        /// <summary>
        /// Data e hora de processamento
        /// Formato = AAAA-MM-DDTHH:MM:SS
        /// Preenchido com data e hora da gravação da
        /// NF-e no Banco de Dados.
        /// Em caso de Rejeição, com data e hora do
        /// recebimento do Lote de NF-e enviado.
        /// </summary>
        [XmlElement]
        public string dhRecbto { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string nProt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string digVal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string cStat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string xMotivo { get; set; }
    }
}
