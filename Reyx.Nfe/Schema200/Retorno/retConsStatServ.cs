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
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class retConsStatServ
    {
        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

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
        /// Código do status da resposta.
        /// </summary>
        [XmlElement]
        public string cStat { get; set; }

        /// <summary>
        /// Descrição literal do status da resposta
        /// </summary>
        [XmlElement]
        public string xMotivo { get; set; }

        /// <summary>
        /// Código da UF que atendeu a solicitação.
        /// </summary>
        [XmlElement]
        public string cUF { get; set; }

        /// <summary>
        /// Data e hora de recebimento
        /// Formato = AAAA-MM-DDTHH:MM:SS
        /// Preenchido com data e hora do recebimento do Pedido.
        /// </summary>
        [XmlElement]
        public string dhRecebto { get; set; }

        /// <summary>
        /// Tempo médio de resposta do serviço (em
        /// segundos) dos últimos 5 minutos (item 5.7).
        /// </summary>
        [XmlElement]
        public string tMed { get; set; }

        /// <summary>
        /// Preencher com data e hora previstas para o
        /// retorno do Web Service, no formato AAA-MMDDTHH:MM:SS
        /// </summary>
        [XmlElement]
        public string dhRetorno { get; set; }

        /// <summary>
        /// Informações adicionais para o Contribuinte
        /// </summary>
        [XmlElement]
        public string xObs { get; set; }
    }
}