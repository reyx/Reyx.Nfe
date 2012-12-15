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
	public class infCons
    {
        /// <summary>
        /// Versão do Aplicativo que processou a consulta.
        /// A versão deve ser iniciada com a sigla da
        /// UF nos casos de WS próprio ou a sigla SCAN,
        /// SVAN ou SVRS nos demais casos.
        /// </summary>
        [XmlElement]
        public string verAplic { get; set; }

        /// <summary>
        /// Código do status da resposta.
        /// </summary>
        [XmlElement]
        public string cStat { get; set; }

        /// <summary>
        /// Descrição do Status da resposta.
        /// </summary>
        [XmlElement]
        public string xMotivo { get; set; }

        /// <summary>
        /// Sigla da UF consultada.
        /// </summary>
        [XmlElement]
        public string UF { get; set; }

        /// <summary>
        /// Inscrição estadual consultada
        /// </summary>
        [XmlElement]
        public string IE { get; set; }

        /// <summary>
        /// CNPJ consultado
        /// </summary>
        [XmlElement]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF consultado
        /// </summary>
        [XmlElement]
        public string CPF { get; set; }

        /// <summary>
        /// Data e hora de processamento da consulta Formato = AAAA-MMDDTHH:MM:SS
        /// </summary>
        [XmlElement]
        public string dhCons { get; set; }

        /// <summary>
        /// Código da UF que atendeu a solicitação.
        /// </summary>
        [XmlElement]
        public string cUF { get; set; }
    }
}
