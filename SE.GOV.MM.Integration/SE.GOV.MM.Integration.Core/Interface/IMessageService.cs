using SE.GOV.MM.Integration.Core.Model;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml;

namespace SE.GOV.MM.Integration.Infrastructure.Services
{
    public interface IMessageService
    {
        Task<DeliveryResult> distributeSecure(SignedDelivery SignedDelivery, string endpointAdressRecipient, string endpointAdressAuthority, string signingCertificateSubjectName);
        Task<DeliveryResult> distributeSecure(SignedDelivery SignedDelivery, string endpointAdressRecipient, string endpointAdressAuthority, string certificateUrl, string certificatePassword);
        Task<DeliveryResult> distributeSecure(SignedDelivery SignedDelivery, string endpointAdressRecipient, string endpointAdressAuthority, X509Certificate2 x509Certificate2);
        Task<Sender[]> GetSenders(string endpointAdress, X509Certificate2 x509Certificate2);
        Task<ReachabilityStatus[]> IsUserReachableInFaRV3(string recipientId, string senderOrgNr, string endpointAdress, string signingCertificateSubjectName);
        Task<ReachabilityStatus[]> IsUserReachableInFaRV3(string recipientId, string senderOrgNr, string endpointAdress, string certificateUrl, string password);
        Task<ReachabilityStatus[]> IsUserReachableInFaRV3(string recipientId, string senderOrgNr, string endpointAdress, X509Certificate2 x509Certificate);
        Task<bool> IsValidSignature(XmlDocument xmlDocument);
    }
}