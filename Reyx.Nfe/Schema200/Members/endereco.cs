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
	public class endereco
    {
        /// <summary>
        /// Logradouro
        /// </summary>
        [XmlElement]
        public string xLgr { get; set; }

        /// <summary>
        /// Número
        /// </summary>
        [XmlElement]
        public string nro { get; set; }

        /// <summary>
        /// Complemento
        /// </summary>
        [XmlElement]
        public string xCpl { get; set; }

        /// <summary>
        /// Bairro
        /// </summary>
        [XmlElement]
        public string xBairro { get; set; }

        /// <summary>
        /// Código do Município
        /// </summary>
        [XmlElement]
        public string cMun { get; set; }

        /// <summary>
        /// Nome do Município
        /// </summary>
        [XmlElement]
        public string xMun { get; set; }

        /// <summary>
        /// Sigla da UF
        /// </summary>
        [XmlElement]
        public string UF { get; set; }

        /// <summary>
        /// Código do CEP
        /// </summary>
        [XmlElement]
        public string CEP { get; set; }

        /// <summary>
        /// Código do País 
        /// <para>1058 - Brasi</para>
        /// </summary>
        [XmlElement]
        public string cPais { get; set; }

        /// <summary>
        /// Nome do País
        /// </summary>
        [XmlElement]
        public string xPais { get; set; }

        /// <summary>
        /// Telefone
        /// <para>
        ///     Preencher com o Código DDD + número do 
        ///     telefone. Nas operações com exterior é
        ///     permitido informar o código do país + 
        ///     código da localidade + número do telefone (v.2.0)
        /// </para>
        /// </summary>
        [XmlElement]
        public string fone { get; set; }
    }
}
