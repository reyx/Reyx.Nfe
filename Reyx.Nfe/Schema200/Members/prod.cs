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
	public class prod
    {
        /// <summary>
        /// Código do produto ou serviço
        /// <para>
        ///     Preencher com CFOP, caso se trate de itens não 
        ///     relacionados com mercadorias/produtos e que o 
        ///     contribuinte não possua codificação própria.
        ///     Formato "CFOP9999"
        /// </para>
        /// </summary>
        [XmlElement]
        public string cProd { get; set; }

        /// <summary>
        /// GTIN (Global Trade Item do produto, antigo código 
        /// EAN ou código de barras
        /// </summary>
        [XmlElement]
        public string cEAN { get; set; }

        /// <summary>
        /// Descrição do produto ou serviço
        /// </summary>
        [XmlElement]
        public string xProd { get; set; }

        /// <summary>
        /// Código NCM com 8 dígitos ou 2 dígitos (gênero)
        /// <para>Em caso de serviço informar 99</para>
        /// </summary>
        [XmlElement]
        public string NCM { get; set; }

        /// <summary>
        /// EX_TIPI
        /// <para>
        ///     Preencher de acordo com o código EX da TIPI. 
        ///     Em caso de serviço, não incluir a TAG.
        /// </para>
        /// </summary>
        [XmlElement]
        public string EXTIPI { get; set; }

        /// <summary>
        /// Código Fiscal de Operações e Prestações
        /// </summary>
        [XmlElement]
        public string CFOP { get; set; }

        /// <summary>
        /// Unidade Comercial
        /// </summary>
        [XmlElement]
        public string uCom { get; set; }

        /// <summary>
        /// Quantidade Comercial
        /// </summary>
        [XmlElement]
        public string qCom { get; set; }

        /// <summary>
        /// <para>
        ///     Valor Unitário de Comercialização
        /// </para>
        /// <para>
        ///     Informar o valor unitário de comercialização do 
        ///     produto, campo meramente informativo, o contribuinte 
        ///     pode utilizar a precisão desejada (0-10 decimais). 
        ///     Para efeitos de cálculo, o valor unitário será obtido 
        ///     pela divisão do valor do produto pela quantidade 
        ///     comercial. (v2.0)
        /// </para>
        /// </summary>
        [XmlElement]
        public string vUnCom { get; set; }

        /// <summary>
        /// Valor Total Bruto dos Produtos
        /// </summary>
        [XmlElement]
        public string vProd { get; set; }

        /// <summary>
        /// GTIN (Global Trade Item do produto, antigo código 
        /// EAN ou código de barras
        /// </summary>
        [XmlElement]
        public string cEANTrib { get; set; }

        /// <summary>
        /// Unidade Tributável
        /// </summary>
        [XmlElement]
        public string uTrib { get; set; }

        /// <summary>
        /// Quantidade Tributável
        /// </summary>
        [XmlElement]
        public string qTrib { get; set; }

        /// <summary>
        /// Valor Unitário de tributação
        /// <para>
        ///     Informar o valor unitário de tributação do produto, 
        ///     campo meramente informativo, o contribuinte pode 
        ///     utilizar a precisão desejada (0-10 decimais). Para 
        ///     efeitos de cálculo, o valor unitário será obtido 
        ///     pela divisão do valor do produto pela quantidade 
        ///     tributável.
        /// </para>
        /// </summary>
        [XmlElement]
        public string vUnTrib { get; set; }

        /// <summary>
        /// Valor Total do Frete
        /// </summary>
        [XmlElement]
        public string vFrete { get; set; }

        /// <summary>
        /// Valor Total do Seguro
        /// </summary>
        [XmlElement]
        public string vSeg { get; set; }

        /// <summary>
        /// Valor do Desconto
        /// </summary>
        [XmlElement]
        public string vDesc { get; set; }

        /// <summary>
        /// Outras despesas acessórias
        /// </summary>
        [XmlElement]
        public string vOutro { get; set; }

        /// <summary>
        /// Indica se valor do Item (vProd) entra no valor total da 
        /// NF-e (vProd)
        /// <para>
        ///     0 – o valor do item (vProd) não compõe o valor 
        ///     total da NF-e (vProd)
        /// </para>
        /// <para>
        ///     1 – o valor do item (vProd) compõe o valor total 
        ///     da NF-e (vProd)
        /// </para>
        /// </summary>
        [XmlElement]
        public string indTot { get; set; }

        /// <summary>
        /// Tag da Declaração de Importação
        /// </summary>
        [XmlElement]
        public DI DI { get; set; }

        /// <summary>
        /// Número do Pedido de Compra
        /// </summary>
        [XmlElement]
        public string xPed { get; set; }

        /// <summary>
        /// Item do Pedido de Compra
        /// </summary>
        [XmlElement]
        public string nItemPed { get; set; }

        /// <summary>
        /// Grupo do detalhamento de Veículos novos
        /// </summary>
        [XmlElement]
        public veicProd veicProd { get; set; }

        /// <summary>
        /// Grupo do detalhamento de Medicamentos e de 
        /// matériasprimas farmacêuticas
        /// </summary>
        [XmlElement]
        public med med { get; set; }

        /// <summary>
        /// Grupo do detalhamento de Armamento
        /// </summary>
        [XmlElement]
        public arma arma { get; set; }

        /// <summary>
        /// Grupo de informações específicas para combustíveis
        /// líquidos e lubrificantes
        /// </summary>
        [XmlElement]
        public comb comb { get; set; }
    }
}
