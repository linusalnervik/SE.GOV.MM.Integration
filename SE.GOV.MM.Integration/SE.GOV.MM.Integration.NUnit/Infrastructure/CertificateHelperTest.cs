using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.EventLog;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using SE.GOV.MM.Integration.Infrastructure;
using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace SE.GOV.MM.Integration.NUnit.Infrastructure
{
    [TestFixture]
    public class CertificateHelperTest
    {
        public string certificateUrl { get;}= TestContext.CurrentContext.TestDirectory + "\\Certificates\\KommunA.p12";
        public string certificatePassword { get; } = "4729451359506045";
        public string certificateCN { get; } = "Kommun A";

        public CertificateHelper certificateHelper { get; set; }

        [SetUp]
        public void Setup()
        {
            var logger = SetupLogging();
            certificateHelper = new CertificateHelper(logger);
        }

        [Test]
        public void CreateX509Certificate2FromUrl()
        {
            //Act
            var certificate = certificateHelper.GetXMLSigningCertificateFromUrl(certificateUrl, certificatePassword);

            //Assert
            Assert.That(certificate.GetRSAPrivateKey != null);
            Assert.That(certificate.PublicKey != null);
        }

        /// <summary>   
        /// To run this test, the "Kommun A.p12" needs to be installed into CertificateStore on local machine
        /// </summary>
        [Test]
        [Explicit]
        public void CreateX509Certificate2Store()
        {
            //Act
            var certificate = certificateHelper.GetXMLSigningCertificateFromStore(certificateCN);

            //Assert
            Assert.That(certificate.HasPrivateKey);
            Assert.That(certificate.PublicKey != null);
        }

        private static ILogger<CertificateHelper> SetupLogging()
        {
            var logSettings = new EventLogSettings() { SourceName = "MM", LogName = "MM" };

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddEventLog(logSettings);
            });
            return loggerFactory.CreateLogger<CertificateHelper>();
        }
    }
}