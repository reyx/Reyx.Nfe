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
	public class infCad
    {
        /// <summary>
        /// Inscrição estadual do contribuinte
        /// </summary>
        [XmlElement]
        public string IE { get; set; }

        /// <summary>
        /// CNPJ do contribuinte
        /// </summary>
        [XmlElement]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF em caso de pessoa física com IE
        /// </summary>
        [XmlElement]
        public string CPF { get; set; }

        /// <summary>
        /// O campo deve ser preenchido com a sigla
        /// da UF de localização do contribuinte. Em algumas
        /// situações, a UF de localização pode ser
        /// diferente da UF consultada. Ex. IE de contribuinte inscrito
        /// </summary>
        [XmlElement]
        public string UF { get; set; }

        /// <summary>
        /// Situação do contribuinte:
        /// <para>0 - não habilitado</para>
        /// <para>1 - habilitado</para>
        /// </summary>
        [XmlElement]
        public string cSit { get; set; }

        /// <summary>
        /// Indicador de contribuinte credenciado a emitir NFe.
        /// <para>0 - Não credenciado para emissão da NF-e</para>
        /// <para>1 - Credenciado</para>
        /// <para>2 - Credenciado com obrigatoriedade para todas operações</para>
        /// <para>3 - Credenciado com obrigatoriedade parcial</para>
        /// <para>
        ///     4 – a SEFAZ não fornece a informação. 
        ///     Este indicador significa apenas que o contribuinte é
        ///     credenciado para emitir NF-e na SEFAZ consultada
        /// </para>
        /// </summary>
        [XmlElement]
        public string indCredNFe { get; set; }

        /// <summary>
        /// Indicador de contribuinte credenciado a emitir CTe.
        /// <para>0 - Não credenciado para emissão da CT-e</para>
        /// <para>1 - Credenciado</para>
        /// <para>2 - Credenciado com obrigatoriedade para todas operações</para>
        /// <para>3 - Credenciado com obrigatoriedade parcial</para>
        /// <para>
        ///     4 – a SEFAZ não fornece a informação. 
        ///     Este indicador significa apenas que o contribuinte é
        ///     credenciado para emitir CT-e na SEFAZ consultada
        /// </para>
        /// </summary>
        [XmlElement]
        public string indCredCTe { get; set; }

        /// <summary>
        /// Razão Social ou nome do Contribuinte
        /// </summary>
        [XmlElement]
        public string xNome { get; set; }

        /// <summary>
        /// Nome Fantasia
        /// </summary>
        [XmlElement]
        public string xFant { get; set; }

        /// <summary>
        /// Regime de Apuração do ICMS do Contribuinte
        /// </summary>
        [XmlElement]
        public string xRegApur { get; set; }

        /// <summary>
        /// CNAE principal do contribuinte
        /// </summary>
        [XmlElement]
        public string CNAE { get; set; }

        /// <summary>
        /// Data de Início da Atividade do Contribuinte
        /// </summary>
        [XmlElement]
        public string dIniAtiv { get; set; }

        /// <summary>
        /// Data da última modificação da situação cadastral do contribuinte.
        /// </summary>
        [XmlElement]
        public string dUltSit { get; set; }

        /// <summary>
        /// Data de ocorrência da baixa do contribuinte.
        /// </summary>
        [XmlElement]
        public string dBaixa { get; set; }

        /// <summary>
        /// IE única, este campo será informado quando o 
        /// contribuinte possuir IE única.
        /// </summary>
        [XmlElement]
        public string IEUnica { get; set; }

        /// <summary>
        /// IE atual (em caso de IE antiga consultada)
        /// </summary>
        [XmlElement]
        public string IEAtual { get; set; }
    }
}
