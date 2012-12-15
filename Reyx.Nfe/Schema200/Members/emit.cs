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
	public class emit
    {
        /// <summary>
        /// CNPJ do emitente
        /// </summary>
        [XmlElement]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF do remetente
        /// </summary>
        [XmlElement]
        public string CPF { get; set; }

        /// <summary>
        /// Razão Social ou Nome do emitente
        /// </summary>
        [XmlElement]
        public string xNome { get; set; }

        /// <summary>
        /// Nome fantasia
        /// </summary>
        [XmlElement]
        public string xFant { get; set; }

        /// <summary>
        /// Grupo do Endereço do emitente
        /// </summary>
        [XmlElement]
        public endereco enderEmit { get; set; }

        /// <summary>
        /// Inscrição Estadual
        /// <para>
        ///     Obrigatória nos casos de emissão própria 
        ///     (procEmi = 0, ou 3). A IE deve ser informada 
        ///     apenas com algarismos para destinatários 
        ///     contribuintes do ICMS, sem caracteres de 
        ///     formatação (ponto, barra, hífen, etc.);
        ///     O literal “ISENTO” deve ser informado apenas 
        ///     para contribuintes do ICMS que são isentos de 
        ///     inscrição no cadastro de contribuintes do ICMS 
        ///     e estejam emitindo NF-e avulsa
        /// </para>
        /// </summary>
        [XmlElement]
        public string IE { get; set; }

        /// <summary>
        /// IE do Substituto Tributário
        /// </summary>
        [XmlElement]
        public string IEST { get; set; }

        /// <summary>
        /// Inscrição Municipal
        /// <para>
        ///     Este campo deve ser informado, quando ocorrer a 
        ///     emissão de NF-e conjugada, com prestação de 
        ///     serviços sujeitos ao ISSQN e fornecimento de 
        ///     peças sujeitos ao ICMS.
        /// </para>
        /// </summary>
        [XmlElement]
        public string IM { get; set; }

        /// <summary>
        /// CNAE fiscal
        /// </summary>
        [XmlElement]
        public string CNAE { get; set; }
        
        /// <summary>
        /// Código de Regime Tributário
        /// <para>1 – Simples Nacional;</para>
        /// <para>2 – Simples Nacional – excesso de sublimite de receita bruta</para>
        /// <para>3 – Regime Normal.</para>
        /// </summary>
        [XmlElement]
        public string CRT { get; set; }
    }
}