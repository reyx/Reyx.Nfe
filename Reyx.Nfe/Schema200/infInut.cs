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
    public class infInut
    {
        /// <summary>
        /// Identificador da TAG a ser assinada formada
        /// com Código da UF + Ano (2 posições) + CNPJ
        /// + modelo + série + nro inicial e nro final
        /// precedida do literal "ID"
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
        /// Serviço solicitado 'INUTILIZAR'
        /// </summary>
        [XmlElement]
        public string xServ { get; set; }

        /// <summary>
        /// Código da UF do solicitante
        /// </summary>
        [XmlElement]
        public string cUF { get; set; }

        /// <summary>
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
        /// Modelo da NF-e (55)
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
        /// Informar a justificativa do pedido de inutilização
        /// </summary>
        [XmlElement]
        public string xJust { get; set; }
    }
}
