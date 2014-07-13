using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Reyx.Nfe.Assinatura
{
    /// <summary>
    ///
    /// </summary>
    public class Certificado
    {
        /// <summary>
        /// Localizar certificado para utilizaçao no sistema
        /// </summary>
        /// <param name="Nome"></param>
        /// <param name="NroSerie"></param>
        /// <returns></returns>
        public X509Certificate2 Localizar(String Nome, string NroSerie)
        {
            X509Certificate2 X509Cert = new X509Certificate2();

            try
            {
                X509Store store = new X509Store("MY", StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
                X509Certificate2Collection collection = store.Certificates;
                X509Certificate2Collection collection1 = collection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
                X509Certificate2Collection collection2 = collection.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, false);

                X509Certificate2Collection scollection;

                if (String.IsNullOrEmpty(Nome) && String.IsNullOrEmpty(NroSerie))
                {
                    scollection = X509Certificate2UI.SelectFromCollection(collection2, "Certificado(s) Digital(is) disponível(is)", "Selecione o Certificado Digital", X509SelectionFlag.SingleSelection);
                }
                else if (!String.IsNullOrEmpty(Nome))
                {
                    scollection = (X509Certificate2Collection)collection2.Find(X509FindType.FindBySubjectDistinguishedName, Nome, false);
                }
                else
                {
                    scollection = (X509Certificate2Collection)collection2.Find(X509FindType.FindBySerialNumber, NroSerie, true);
                }

                if (scollection.Count == 0)
                {
                    X509Cert.Reset();
                }
                else
                {
                    X509Cert = scollection[0];
                }

                store.Close();

                return X509Cert;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Localizar certificado pelo valor e tipo
        /// </summary>
        /// <param name="Valor"></param>
        /// <param name="Tipo">A - Nome, B - NroSerie</param>
        /// <returns></returns>
        public X509Certificate2 Localizar(String Valor, Char Tipo)
        {
            switch (Tipo)
            {
                case 'A':
                    return Localizar(Valor, String.Empty);

                default:
                    return Localizar(String.Empty, Valor);
            }
        }

        /// <summary>
        /// Localizar certificados pessoais
        /// </summary>
        /// <returns></returns>
        public X509Certificate2 Localizar()
        {
            return Localizar(String.Empty, String.Empty);
        }
    }
}