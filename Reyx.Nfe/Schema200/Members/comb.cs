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
	public class comb
    {
        /// <summary>
        /// Código de produto da ANP
        /// <para>
        ///     Utilizar a codificação de produtos do Sistema de
        ///     Informações de Movimentação de produtos - SIMP
        ///     (http://www.anp.gov.br/simp/index.htm). 
        /// </para>
        /// <para>
        ///     Informar 999999999 se o produto não possuir código 
        ///     de produto ANP.
        /// </para>
        /// </summary>
        [XmlElement]
        public string cProdANP { get; set; }

        /// <summary>
        /// Código de autorização / registro do CODIF
        /// <para>
        ///     Informar apenas quando a UF utilizar o CODIF 
        ///     (Sistema de Controle do Diferimento do Imposto 
        ///     nas Operações com AEAC - Álcool Etílico Anidro
        ///     Combustível).
        /// </para>
        /// </summary>
        [XmlElement]
        public string CODIF { get; set; }

        /// <summary>
        /// Quantidade de combustível faturada à temperatura ambiente
        /// <para>
        ///     Informar quando a quantidade faturada informada no campo
        ///     qCom (I10) tiver sido ajustada para uma temperatura 
        ///     diferente da ambiente.
        /// </para>
        /// </summary>
        [XmlElement]
        public string qTemp { get; set; }

        /// <summary>
        /// Sigla da UF de consumo
        /// </summary>
        [XmlElement]
        public string UFCons { get; set; }

        /// <summary>
        /// Grupo da CIDE
        /// </summary>
        [XmlElement]
        public CIDE CIDE { get; set; }
    }
}
