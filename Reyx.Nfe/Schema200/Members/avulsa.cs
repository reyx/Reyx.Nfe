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
	public class avulsa
    {
        /// <summary>
        /// CNPJ do órgão emitente
        /// </summary>
        [XmlElement]
        public string CPNJ { get; set; }

        /// <summary>
        /// Órgão emitente
        /// </summary>
        [XmlElement]
        public string xOrgao { get; set; }

        /// <summary>
        /// Matrícula do agente
        /// </summary>
        [XmlElement]
        public string matr { get; set; }

        /// <summary>
        /// Nome do agente
        /// </summary>
        [XmlElement]
        public string xAgente { get; set; }

        /// <summary>
        /// Telefone
        /// <para>Preencher com Código DDD + número do telefone (v.2.0)</para>
        /// </summary>
        [XmlElement]
        public string fone { get; set; }

        /// <summary>
        /// Sigla da UF
        /// </summary>
        [XmlElement]
        public string UF { get; set; }

        /// <summary>
        /// Número do Documento de Arrecadação de Receita
        /// </summary>
        [XmlElement]
        public string nDAR { get; set; }

        /// <summary>
        /// Data de emissão do Documento de Arrecadação
        /// <para>Formato "AAAA-MM-DD"</para>
        /// </summary>
        [XmlElement]
        public string dEmi { get; set; }

        /// <summary>
        /// Valor Total constante no Documento de arrecadação 
        /// de Receita
        /// </summary>
        [XmlElement]
        public string vDAR { get; set; }

        /// <summary>
        /// Repartição Fiscal emitente
        /// </summary>
        [XmlElement]
        public string repEmi { get; set; }

        /// <summary>
        /// Data de pagamento do Documento de Arrecadação
        /// <para>Formato "AAAA-MM-DD"</para>
        /// </summary>
        [XmlElement]
        public string dPag { get; set; }
    }
}