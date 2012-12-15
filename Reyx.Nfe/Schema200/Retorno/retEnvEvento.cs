using System.Collections.Generic;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200.Retorno
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class retEnvEvento
    {
        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// <para>
        ///     Identificador de controle do Lote de envio do Evento.
        /// </para>
        /// <para>
        ///     Número sequencial autoincremental único para identificação do Lote
        /// </para>
        /// </summary>
        [XmlElement]
        public string idLote { get; set; }

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
        /// Descrição literal do status da resposta
        /// </summary>
        [XmlElement]
        public string xMotivo { get; set; }

        /// <summary>
        /// Dados do Recibo do Lote (Só é gerado se o Lote for aceito)
        /// </summary>
        //[XmlInclude]
        public List<Reyx.Nfe.Schema200.Retorno.retEvento> retEvento { get; set; }
    }
}
