using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace Reyx.Nfe.Assinatura
{
    /// <summary>
    ///
    /// </summary>
    public class Digital
    {
        private XmlDocument XMLDoc = new XmlDocument { PreserveWhitespace = false };

        /// <summary>
        /// Xml assinado
        /// </summary>
        public XmlDocument XMLDocAssinado
        {
            get { return XMLDoc; }
        }

        /// <summary>
        /// Xml assinado serializado
        /// </summary>
        public string XMLStringAssinado
        {
            get { return XMLDoc.OuterXml; }
        }

        /// <summary>
        /// Assinar o arquivo xml
        /// </summary>
        /// <param name="XMLString">Arquivo xml serializado</param>
        /// <param name="RefUri">URI a ser assinada (infNFe para NFe)</param>
        /// <param name="X509Cert">Certificado digital</param>
        /// <returns></returns>
        public List<String> Assinar(String XMLString, string RefUri, X509Certificate2 X509Cert)
        {
            List<String> erros = new List<string>();

            try
            {
                XmlDocument doc = new XmlDocument { PreserveWhitespace = false };

                doc.LoadXml(XMLString);

                try
                {
                    SignedXml signedXml = new SignedXml(doc);
                    signedXml.SigningKey = X509Cert.PrivateKey;

                    Reference reference = new Reference();
                    XmlAttributeCollection uri = doc.GetElementsByTagName(RefUri).Item(0).Attributes;
                    foreach (XmlAttribute atributo in uri)
                    {
                        if (atributo.Name == "Id")
                        {
                            reference.Uri = "#" + atributo.Value;

                            break;
                        }
                    }

                    reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
                    reference.AddTransform(new XmlDsigC14NTransform());

                    signedXml.AddReference(reference);

                    KeyInfo keyInfo = new KeyInfo();
                    keyInfo.AddClause(new KeyInfoX509Data(X509Cert));

                    signedXml.KeyInfo = keyInfo;

                    signedXml.ComputeSignature();

                    XmlElement xmlDigitalSignature = signedXml.GetXml();

                    doc.DocumentElement.AppendChild(doc.ImportNode(xmlDigitalSignature, true));

                    XMLDoc = doc;
                }
                catch (Exception ex)
                {
                    erros.Add("Erro ao assinar digitalmente o documento - " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                erros.Add("XML mal formado - " + ex.Message);
            }

            return erros;
        }
    }
}