using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace SE.GOV.MM.Integration.Infrastructure
{
    public interface ISigningHandler
    {
        bool IsMessageSigned(XmlDocument xmlDoc);
        bool IsValidSignature(XmlDocument xmlDoc);
        void SignXmlDocument(XmlDocument xmlDoc, string tagName, X509Certificate2 x509Certificate2 = null);
    }
}