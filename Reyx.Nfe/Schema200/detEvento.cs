using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections;

namespace Reyx.Nfe.Schema200
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace="http://www.portalfiscal.inf.br/nfe")]
    public class detEvento
    {
        /// <summary>
        /// Versão da carta de correção
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// "Carta de Correção" ou "Carta de Correcao"
        /// </summary>
        [XmlElement]
        public string descEvento { get; set; }

        /// <summary>
        /// Correção a ser considerada, texto livre. A correção mais recente substitui 
        /// as anteriores.
        /// </summary>
        [XmlElement]
        public string xCorrecao { get; set; }

        /// <summary>
        /// <para>
        ///     Condições de uso da Carta de Correção, informar a literal:
        /// </para>
        /// <para>
        ///     "A Carta de Correção é disciplinada pelo § 1º-A do art. 7º do Convênio S/N, de 15 de dezembro de 1970 e pode ser utilizada para regularização de erro ocorrido na emissão de documento fiscal, desde que o erro não esteja relacionado com: I - as variáveis que determinam o valor do imposto tais como: base de cálculo, alíquota, diferença de preço, quantidade, valor da operação ou da prestação; II - a correção de dados cadastrais que implique mudança do remetente ou do destinatário; III - a data de emissão ou de saída." (texto com acentuação) ou
        /// </para>
        /// <para>
        ///     "A Carta de Correcao e disciplinada pelo paragrafo 1o-A do art. 7o do Convenio S/N, de 15 de dezembro de 1970 e pode ser utilizada para regularizacao de erro ocorrido na emissao de documento fiscal, desde que o erro nao esteja relacionado com: I - as variaveis que determinam o valor do imposto tais como: base de calculo, aliquota, diferenca de preco, quantidade, valor da operacao ou da prestacao; II - a correcao de dados cadastrais que implique mudanca do remetente ou do destinatario; III - a data de emissao ou de saida." (texto sem acentuação)
        /// </para>
        /// </summary>
        [XmlElement]
        public string xCondUso { get; set; }
    }
}