using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace SE.GOV.MM.Integration.Infrastructure.Services
{
    public interface IMessageService
    {
        DeliveryResult distributeSecure(SignedDelivery2 signedDelivery2, string endpointAdress, string signingCertificateSubjectName);
        DeliveryResult distributeSecure(SignedDelivery2 signedDelivery2, string endpointAdress, string certificateUrl, string certificatePassword);
        DeliveryResult distributeSecure(SignedDelivery2 signedDelivery2, string endpointAdress, X509Certificate2 x509Certificate2);
        bool IsValidSignature(XmlDocument xmlDocument);
    }
}