﻿using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Security.Cryptography.X509Certificates;

namespace SE.GOV.MM.Integration.Infrastructure
{
    public class CertificateHelper : ICertificateHelper
    {
        public X509Certificate _X509Certificate { get;}
        public ILogger logger;

        public CertificateHelper(ILogger logger)
        {
            this.logger = logger;
        }

        public CertificateHelper()
        {
            logger = new Logger<CertificateHelper>(new NullLoggerFactory());
        }
     
        /// <summary>
        /// Get the certificate used to sign xml document from certificate store.
        /// </summary>
        public X509Certificate2 GetXMLSigningCertificateFromStore(string signingCertificateSubjectName)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.CertificateHelper: incoming call GetXMLSigningCertificateFromStore"));

            var certificate = new X509Certificate2();
            var certificates = new X509Certificate2Collection();
            var store = new X509Store();

            try
            {
                store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
                store.Open(OpenFlags.ReadOnly);
                //Since there is no CA för this certificate, onlyValid is set to false
                certificates = store.Certificates.Find(X509FindType.FindBySubjectName, signingCertificateSubjectName, false);

            }
            catch (Exception ce)
            {
                logger.LogError(ce, ce.Message);
            }


            if (certificates.Count == 0)
            {
                var errorMessage = string.Format("SE.GOV.MM.Integration.Infrastructure.SigningCertificateHelper: No certificate found, sign xml.");
                logger.LogError(errorMessage);
                store.Close();
                throw new Exception(errorMessage);
            }
            else
            {
                certificate = certificates[0];
            }

            store.Close();

            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.SigningCertificateHelper: leaving GetXMLSigningCertificateFromStore"));
            return certificate;
        }

        /// <summary>
        /// Get the certificate used to sign xml document from url.
        /// </summary>
        /// <param name="url">Path to certificate</param>
        /// <param name="password">Password to certificate</param>
        /// <returns></returns>
        public X509Certificate2 GetXMLSigningCertificateFromUrl(string url, string password)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.CertificateHelper: incoming call GetXMLSigningCertificateFromUrl"));
            try
            {
                var x509Certifiate2 = new X509Certificate2(url, password);
                logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.SigningCertificateHelper: leaving GetXMLSigningCertificateFromUrl"));
                return x509Certifiate2;
            }
            catch (Exception ce)
            {
                logger.LogError(ce, ce.Message);
                throw ce;
            }
        }
    }
}
