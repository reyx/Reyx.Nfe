// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.0.0.317
//    <NameSpace>Reyx.Nfe.CCe_v100a</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>False</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>False</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>True</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>Default</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><PrivateFieldNamePrefix></PrivateFieldNamePrefix><ClassNamePrefix></ClassNamePrefix><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>False</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>False</CleanupCode><EnableXmlSerialization>False</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><GenerateShouldSerialize>False</GenerateShouldSerialize><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings>
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable

namespace Reyx.Nfe.CCe_v100a.RetEnvCCe
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retEnvEvento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetEnvEvento
    {
        private string _idLote;

        private TAmb _tpAmb;

        private string _verAplic;

        private TCOrgaoIBGE _cOrgao;

        private string _cStat;

        private string _xMotivo;

        private List<TretEvento> _retEvento;

        private string _versao;

        public TRetEnvEvento()
        {
            this._retEvento = new List<TretEvento>();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string idLote
        {
            get
            {
                return this._idLote;
            }
            set
            {
                this._idLote = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TAmb tpAmb
        {
            get
            {
                return this._tpAmb;
            }
            set
            {
                this._tpAmb = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string verAplic
        {
            get
            {
                return this._verAplic;
            }
            set
            {
                this._verAplic = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this._cOrgao;
            }
            set
            {
                this._cOrgao = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string cStat
        {
            get
            {
                return this._cStat;
            }
            set
            {
                this._cStat = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string xMotivo
        {
            get
            {
                return this._xMotivo;
            }
            set
            {
                this._xMotivo = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("retEvento", Order = 6)]
        public List<TretEvento> retEvento
        {
            get
            {
                return this._retEvento;
            }
            set
            {
                this._retEvento = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this._versao;
            }
            set
            {
                this._versao = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TAmb
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCOrgaoIBGE
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TretEvento
    {
        private TretEventoInfEvento _infEvento;

        private SignatureType _signature;

        private string _versao;

        public TretEvento()
        {
            this._signature = new SignatureType();
            this._infEvento = new TretEventoInfEvento();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TretEventoInfEvento infEvento
        {
            get
            {
                return this._infEvento;
            }
            set
            {
                this._infEvento = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", Order = 1)]
        public SignatureType Signature
        {
            get
            {
                return this._signature;
            }
            set
            {
                this._signature = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this._versao;
            }
            set
            {
                this._versao = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TretEventoInfEvento
    {
        private TAmb _tpAmb;

        private string _verAplic;

        private TCOrgaoIBGE _cOrgao;

        private string _cStat;

        private string _xMotivo;

        private string _chNFe;

        private string _tpEvento;

        private string _xEvento;

        private string _nSeqEvento;

        private string _item;

        private ItemChoiceType _itemElementName;

        private string _emailDest;

        private string _dhRegEvento;

        private string _nProt;

        private string _id;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TAmb tpAmb
        {
            get
            {
                return this._tpAmb;
            }
            set
            {
                this._tpAmb = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string verAplic
        {
            get
            {
                return this._verAplic;
            }
            set
            {
                this._verAplic = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this._cOrgao;
            }
            set
            {
                this._cOrgao = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string cStat
        {
            get
            {
                return this._cStat;
            }
            set
            {
                this._cStat = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string xMotivo
        {
            get
            {
                return this._xMotivo;
            }
            set
            {
                this._xMotivo = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string chNFe
        {
            get
            {
                return this._chNFe;
            }
            set
            {
                this._chNFe = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string tpEvento
        {
            get
            {
                return this._tpEvento;
            }
            set
            {
                this._tpEvento = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string xEvento
        {
            get
            {
                return this._xEvento;
            }
            set
            {
                this._xEvento = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string nSeqEvento
        {
            get
            {
                return this._nSeqEvento;
            }
            set
            {
                this._nSeqEvento = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJDest", Order = 9)]
        [System.Xml.Serialization.XmlElementAttribute("CPFDest", Order = 9)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                this._itemElementName = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string emailDest
        {
            get
            {
                return this._emailDest;
            }
            set
            {
                this._emailDest = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string dhRegEvento
        {
            get
            {
                return this._dhRegEvento;
            }
            set
            {
                this._dhRegEvento = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string nProt
        {
            get
            {
                return this._nProt;
            }
            set
            {
                this._nProt = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        /// <remarks/>
        CNPJDest,

        /// <remarks/>
        CPFDest,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType
    {
        private byte[] _x509Certificate;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 0)]
        public byte[] X509Certificate
        {
            get
            {
                return this._x509Certificate;
            }
            set
            {
                this._x509Certificate = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType
    {
        private X509DataType _x509Data;

        private string _id;

        public KeyInfoType()
        {
            this._x509Data = new X509DataType();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X509DataType X509Data
        {
            get
            {
                return this._x509Data;
            }
            set
            {
                this._x509Data = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType
    {
        private string _id;

        private byte[] _value;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType
    {
        private List<string> _xPath;

        private TTransformURI _algorithm;

        public TransformType()
        {
            this._xPath = new List<string>();
        }

        [System.Xml.Serialization.XmlElementAttribute("XPath", Order = 0)]
        public List<string> XPath
        {
            get
            {
                return this._xPath;
            }
            set
            {
                this._xPath = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TTransformURI Algorithm
        {
            get
            {
                return this._algorithm;
            }
            set
            {
                this._algorithm = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public enum TTransformURI
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
        httpwwww3org200009xmldsigenvelopedsignature,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
        httpwwww3orgTR2001RECxmlc14n20010315,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceType
    {
        private List<TransformType> _transforms;

        private ReferenceTypeDigestMethod _digestMethod;

        private byte[] _digestValue;

        private string _id;

        private string _uRI;

        private string _type;

        public ReferenceType()
        {
            this._digestMethod = new ReferenceTypeDigestMethod();
            this._transforms = new List<TransformType>();
        }

        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public List<TransformType> Transforms
        {
            get
            {
                return this._transforms;
            }
            set
            {
                this._transforms = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ReferenceTypeDigestMethod DigestMethod
        {
            get
            {
                return this._digestMethod;
            }
            set
            {
                this._digestMethod = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 2)]
        public byte[] DigestValue
        {
            get
            {
                return this._digestValue;
            }
            set
            {
                this._digestValue = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this._uRI;
            }
            set
            {
                this._uRI = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceTypeDigestMethod
    {
        private string _algorithm;

        public ReferenceTypeDigestMethod()
        {
            this._algorithm = "http://www.w3.org/2000/09/xmldsig#sha1";
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this._algorithm;
            }
            set
            {
                this._algorithm = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType
    {
        private SignedInfoTypeCanonicalizationMethod _canonicalizationMethod;

        private SignedInfoTypeSignatureMethod _signatureMethod;

        private ReferenceType _reference;

        private string _id;

        public SignedInfoType()
        {
            this._reference = new ReferenceType();
            this._signatureMethod = new SignedInfoTypeSignatureMethod();
            this._canonicalizationMethod = new SignedInfoTypeCanonicalizationMethod();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this._canonicalizationMethod;
            }
            set
            {
                this._canonicalizationMethod = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public SignedInfoTypeSignatureMethod SignatureMethod
        {
            get
            {
                return this._signatureMethod;
            }
            set
            {
                this._signatureMethod = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ReferenceType Reference
        {
            get
            {
                return this._reference;
            }
            set
            {
                this._reference = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCanonicalizationMethod
    {
        private string _algorithm;

        public SignedInfoTypeCanonicalizationMethod()
        {
            this._algorithm = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this._algorithm;
            }
            set
            {
                this._algorithm = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeSignatureMethod
    {
        private string _algorithm;

        public SignedInfoTypeSignatureMethod()
        {
            this._algorithm = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this._algorithm;
            }
            set
            {
                this._algorithm = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureType
    {
        private SignedInfoType _signedInfo;

        private SignatureValueType _signatureValue;

        private KeyInfoType _keyInfo;

        private string _id;

        public SignatureType()
        {
            this._keyInfo = new KeyInfoType();
            this._signatureValue = new SignatureValueType();
            this._signedInfo = new SignedInfoType();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public SignedInfoType SignedInfo
        {
            get
            {
                return this._signedInfo;
            }
            set
            {
                this._signedInfo = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public SignatureValueType SignatureValue
        {
            get
            {
                return this._signatureValue;
            }
            set
            {
                this._signatureValue = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public KeyInfoType KeyInfo
        {
            get
            {
                return this._keyInfo;
            }
            set
            {
                this._keyInfo = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }
}

#pragma warning restore