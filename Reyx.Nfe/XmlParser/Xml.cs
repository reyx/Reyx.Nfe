using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace Reyx.Nfe.XmlParser
{
    /// <summary>
    /// 
    /// </summary>
    public static class Xml
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        /// <param name="path"></param>
        public static void Save<T>(this T type, string path)
        {
            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(type.GetType());
            
            System.Xml.Serialization.XmlSerializerNamespaces ns = new System.Xml.Serialization.XmlSerializerNamespaces();
            ns.Add("", "http://www.portalfiscal.inf.br/nfe");
            
            using(XmlWriter file = XmlWriter.Create(path))
            {
                xs.Serialize(file, type, ns);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T ToXmlClass<T>(this string xml)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(T));

                using (StringReader sr = new StringReader(xml))
                {
                    using (XmlReader value = XmlReader.Create(sr))
                    {
                        return (T)xs.Deserialize(value);
                    }
                }
            }
            catch
            {
                return (T)new object();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        /// <returns></returns>
        public static XmlDocument ToXmlDocument<T>(this T type)
        {
            try
            {
                XmlDocument xml = new XmlDocument() { PreserveWhitespace = false };
                xml.LoadXml(type.ToXmlString());
                return xml.ChangeXmlEncoding("utf-8");
            }
            catch
            {
                return new XmlDocument();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <param name="newEncoding"></param>
        /// <returns></returns>
        public static XmlDocument ChangeXmlEncoding(this XmlDocument xmlDoc, string newEncoding)
        {
            if (xmlDoc.FirstChild.NodeType == XmlNodeType.XmlDeclaration)
            {
                XmlDeclaration xmlDeclaration = (XmlDeclaration)xmlDoc.FirstChild;
                xmlDeclaration.Encoding = newEncoding;
            }
            return xmlDoc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string ToXmlString<T>(this T type)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(type.GetType());

                System.Xml.Serialization.XmlSerializerNamespaces ns = new System.Xml.Serialization.XmlSerializerNamespaces();
                ns.Add("", "http://www.portalfiscal.inf.br/nfe");
                using (StringWriter sw = new StringWriter())
                {
                    using (XmlWriter value = XmlWriter.Create(sw))
                    {
                        xs.Serialize(value, type, ns);
                        return sw.ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                return "Exception - " + ex.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T Load<T>(string path)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(T));
                using (System.IO.StreamReader file = new System.IO.StreamReader(path))
                {
                    return (T)xs.Deserialize(file);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}