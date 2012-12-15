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
	public class ICMS40
    {
        /// <summary>
        /// Origem da mercadoria
        /// <para>0 - Nacional</para>
        /// <para>1 - Estrangeira - Importação direta</para>
        /// <para>2 - Estrangeira - Adquirida no meracado interno</para>
        /// </summary>
        [XmlElement]
        public string orig { get; set; }

        /// <summary>
        /// Tributação pelo ICMS
        /// <para>40 - Isenta</para>
        /// <para>41 - Não tributada</para>
        /// <para>50 - Suspensão</para>
        /// </summary>
        [XmlElement]
        public string CST { get; set; }

        /// <summary>
        /// O valor do ICMS será informado apenas nas 
        /// operações com veículos beneficiados com a 
        /// desoneração condicional do ICMS. (v2.0)
        /// </summary>
        [XmlElement]
        public string vICMS { get; set; }

        /// <summary>
        /// Motivo da desoneração do ICMS
        /// <para>1 – Táxi</para>
        /// <para>2 – Deficiente Físico</para>
        /// <para>3 – Produtor Agropecuário</para>
        /// <para>4 – Frotista/Locadora</para>
        /// <para>5 – Diplomático/Consular</para>
        /// <para>
        ///     6 – Utilitários e Motocicletas da Amazônia 
        ///     Ocidental e Áreas deLivre Comércio (Resolução 
        ///     714/88 e 790/94 – CONTRAN e suas alterações)
        /// </para>
        /// <para>7 – SUFRAMA</para>
        /// <para>9 – outros. (v2.0)</para>
        /// </summary>
        [XmlElement]
        public string motDesICMS { get; set; }
    }
}
