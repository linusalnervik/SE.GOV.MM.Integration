using System;
using System.Security.Cryptography.X509Certificates;

namespace SE.GOV.MM.Integration.Infrastructure
{
    public interface ICertificateHelper
    {
        X509Certificate2 GetXMLSigningCertificateFromStore(string signingCertificateSubjectName);
        X509Certificate2 GetXMLSigningCertificateFromUrl(string url, string password);
    }
}