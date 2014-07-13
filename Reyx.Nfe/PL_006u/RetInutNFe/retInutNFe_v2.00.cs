// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.0.0.317
//    <NameSpace>Reyx.Nfe.PL_006u.RetInutNFe</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>False</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>False</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>Default</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><PrivateFieldNamePrefix></PrivateFieldNamePrefix><ClassNamePrefix></ClassNamePrefix><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>False</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>False</CleanupCode><EnableXmlSerialization>False</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><GenerateShouldSerialize>False</GenerateShouldSerialize><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings>
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace Reyx.Nfe.PL_006u.RetInutNFe
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retInutNFe", Namespace="http://www.portalfiscal.inf.br/nfe", IsNullable=false)]
    public partial class TRetInutNFe
    {
        
        private TRetInutNFeInfInut _infInut;
        
        private SignatureType _signature;
        
        private string _versao;
        
        public TRetInutNFe()
        {
            this._signature = new SignatureType();
            this._infInut = new TRetInutNFeInfInut();
        }
        
        public TRetInutNFeInfInut infInut
        {
            get
            {
                return this._infInut;
            }
            set
            {
                this._infInut = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetInutNFeInfInut
    {
        
        private TAmb _tpAmb;
        
        private string _verAplic;
        
        private string _cStat;
        
        private string _xMotivo;
        
        private TCodUfIBGE _cUF;
        
        private string _ano;
        
        private string _cNPJ;
        
        private System.Nullable<TMod> _mod;
        
        private string _serie;
        
        private string _nNFIni;
        
        private string _nNFFin;
        
        private System.Nullable<System.DateTime> _dhRecbto;
        
        private string _nProt;
        
        private string _id;
        
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
        
        public TCodUfIBGE cUF
        {
            get
            {
                return this._cUF;
            }
            set
            {
                this._cUF = value;
            }
        }
        
        public string ano
        {
            get
            {
                return this._ano;
            }
            set
            {
                this._ano = value;
            }
        }
        
        public string CNPJ
        {
            get
            {
                return this._cNPJ;
            }
            set
            {
                this._cNPJ = value;
            }
        }
        
        public TMod mod
        {
            get
            {
                if (this._mod.HasValue)
                {
                    return this._mod.Value;
                }
                else
                {
                    return default(TMod);
                }
            }
            set
            {
                this._mod = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modSpecified
        {
            get
            {
                return this._mod.HasValue;
            }
            set
            {
                if (value==false)
                {
                    this._mod = null;
                }
            }
        }
        
        public string serie
        {
            get
            {
                return this._serie;
            }
            set
            {
                this._serie = value;
            }
        }
        
        public string nNFIni
        {
            get
            {
                return this._nNFIni;
            }
            set
            {
                this._nNFIni = value;
            }
        }
        
        public string nNFFin
        {
            get
            {
                return this._nNFFin;
            }
            set
            {
                this._nNFFin = value;
            }
        }
        
        public System.DateTime dhRecbto
        {
            get
            {
                if (this._dhRecbto.HasValue)
                {
                    return this._dhRecbto.Value;
                }
                else
                {
                    return default(System.DateTime);
                }
            }
            set
            {
                this._dhRecbto = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dhRecbtoSpecified
        {
            get
            {
                return this._dhRecbto.HasValue;
            }
            set
            {
                if (value==false)
                {
                    this._dhRecbto = null;
                }
            }
        }
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe")]
    public enum TCodUfIBGE
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe")]
    public enum TMod
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType
    {
        
        private byte[] _x509Certificate;
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType
    {
        
        private X509DataType _x509Data;
        
        private string _id;
        
        public KeyInfoType()
        {
            this._x509Data = new X509DataType();
        }
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType
    {
        
        private string _id;
        
        private byte[] _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
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
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType
    {
        
        private List<string> _xPath;
        
        private TTransformURI _algorithm;
        
        public TransformType()
        {
            this._xPath = new List<string>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("XPath")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable=false)]
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
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceTypeDigestMethod
    {
        
        private string _algorithm;
        
        public ReferenceTypeDigestMethod()
        {
            this._algorithm = "http://www.w3.org/2000/09/xmldsig#sha1";
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCanonicalizationMethod
    {
        
        private string _algorithm;
        
        public SignedInfoTypeCanonicalizationMethod()
        {
            this._algorithm = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeSignatureMethod
    {
        
        private string _algorithm;
        
        public SignedInfoTypeSignatureMethod()
        {
            this._algorithm = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
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
