using SE.GOV.MM.Integration.Core.Interface;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace SE.GOV.MM.Integration.Infrastructure
{
    internal class SigningHandler
    {

        private X509Certificate2 x509Certificate2 { get; set; }

        internal SigningHandler() {}

      
        internal SigningHandler(X509Certificate2 x509Certificate2)
        {
            this.x509Certificate2 = x509Certificate2;
        }

        /// <summary>
        /// Signs xmldocument
        /// </summary>
        /// <param name="xmlDoc">Document to sign</param>
        /// <param name="tagName">Element to insert signature after</param>
        internal void SignXmlDocument(XmlDocument xmlDoc, string tagName)
        {
            xmlDoc.Normalize();

            SignedXml signedXml = new SignedXml(xmlDoc);
            signedXml.SigningKey = x509Certificate2.PrivateKey;

            // Create a reference to be signed.
            Reference reference = new Reference("");
            reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
            signedXml.AddReference(reference);

            // Specify a canonicalization method.
            signedXml.SignedInfo.CanonicalizationMethod = SignedXml.XmlDsigExcC14NTransformUrl;
            signedXml.KeyInfo = new KeyInfo();

            var keyInfoData = new KeyInfoX509Data();
            keyInfoData.AddSubjectName(x509Certificate2.SubjectName.Name);
            keyInfoData.AddCertificate(x509Certificate2);
            signedXml.KeyInfo.AddClause(keyInfoData);

            signedXml.ComputeSignature();

            XmlNodeList nodes = xmlDoc.DocumentElement.GetElementsByTagName(tagName);
            nodes[0].ParentNode.InsertAfter(xmlDoc.ImportNode(signedXml.GetXml(), true), nodes[0]);
        }

        /// <summary>
        /// Method to validate if SignedDelivery message har valid signature
        /// </summary>
        /// <param name="xmlDoc">message to check</param>
        /// <returns>status</returns>
        internal bool IsValidSignature(XmlDocument xmlDoc)
        {

            SignedXml signedXml = new SignedXml(xmlDoc);
            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("Signature");
            bool hasValidSignature = false;

            
            foreach (XmlElement element in nodeList)
            {
                XmlNodeList certificates = xmlDoc.GetElementsByTagName("X509Certificate");
                X509Certificate2 dcert2 = new X509Certificate2(Convert.FromBase64String(certificates[0].InnerText));
                signedXml.LoadXml(element);
                if (!signedXml.CheckSignature(dcert2, true)) return false;
                hasValidSignature = true;
            }
            return hasValidSignature;
        }

        /// <summary>
        /// Method checks if xmldocument has a Signature
        /// </summary>
        /// <param name="xmlDoc">message to check</param>
        /// <returns>status</returns>
        internal bool IsMessageSigned(XmlDocument xmlDoc)
        {
            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("Signature");
            XmlNodeList certificates = xmlDoc.GetElementsByTagName("X509Certificate");
            return nodeList.Count > 0 && certificates.Count > 0;
        }
    }
}
