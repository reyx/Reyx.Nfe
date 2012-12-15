using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Reyx.Nfe.Schema200.Members
{
    /// <summary>
	/// 
	/// </summary>
	public class infNFe
    {
        /// <summary>
        /// Versão do leiaute (v2.0)
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// informar a chave de acesso da 
        /// NF-e precedida do literal 'NFe',
        /// acrescentada a validação do formato (v2.0)
        /// </summary>
        [XmlAttribute]
        public string Id { get; set; }

        /// <summary>
        /// Grupo das informações de identificação da NF-e
        /// </summary>
        [XmlElement]
        public ide ide { get; set; }

        /// <summary>
        /// Grupo de identificação do emitente da NF-e
        /// </summary>
        [XmlElement]
        public emit emit { get; set; }

        /// <summary>
        /// Informações do fisco emitente, grupo de uso exclusivo do fisco.
        /// </summary>
        [XmlElement]
        public avulsa avulsa { get; set; }

        /// <summary>
        /// Grupo de identificação do Destinatário da NF-e
        /// </summary>
        [XmlElement]
        public dest dest { get; set; }

        /// <summary>
        /// Grupo de identificação do Local de retirada
        /// <para>
        ///     Informar apenas quando for diferente do endereço 
        ///     do remetente.
        /// </para>
        /// </summary>
        [XmlElement]
        public enderCom retirada { get; set; }

        /// <summary>
        /// Grupo de identificação do Local de entrega
        /// <para>
        ///     Informar apenas quando for diferente do endereço 
        ///     do destinatário.
        /// </para>
        /// </summary>
        [XmlElement]
        public enderCom entrega { get; set; }

        /// <summary>
        /// Grupo do detalhamento de Produtos e Serviços da NF-e
        /// </summary>
        [XmlElement]
        public List<Reyx.Nfe.Schema200.Members.det> det { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public total total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public transp transp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public cobr cobr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public infAdic infAdic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public exporta exporta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public compra compra { get; set; }

        /// <summary>
        /// Grupo de aquisição de cana
        /// </summary>
        [XmlElement]
        public cana cana { get; set; }
    }
}