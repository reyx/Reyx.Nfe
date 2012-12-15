using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200
{
    /// <summary>
    /// 
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public class NFe
    {
        /// <summary>
        /// Grupo que contém as informações da NF-e
        /// </summary>
        public Reyx.Nfe.Schema200.Members.infNFe infNFe;
    }
}