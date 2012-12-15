using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200
{
    /// <summary>
    /// 
    /// </summary>
    public class infCanc
    {
        /// <summary>
        /// 
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
        /// Versão do Aplicativo que processou o pedido de 
        /// cancelamento. A versão deve ser iniciada com a 
        /// sigla da UF nos casos de WS próprio ou a sigla SCAN,
        /// SVAN ou SVRS nos demais casos.
        /// </summary>
        [XmlElement]
        public string verAplic { get; set; }

        /// <summary>
        /// Código do status da resposta (
        /// </summary>
        [XmlElement]
        public string cStat { get; set; }

        /// <summary>
        /// Descrição literal do status da resposta.
        /// </summary>
        [XmlElement]
        public string xMotivo { get; set; }

        /// <summary>
        /// Código da UF que atendeu a solicitação
        /// </summary>
        [XmlElement]
        public string cUF { get; set; }
    }
}
