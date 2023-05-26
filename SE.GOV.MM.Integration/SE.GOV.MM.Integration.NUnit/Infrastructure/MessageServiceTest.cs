using EnumsNET;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using SE.GOV.MM.Integration.Infrastructure;
using SE.GOV.MM.Integration.Infrastructure.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static SE.GOV.MM.Integration.Core.Model.Enums;

namespace SE.GOV.MM.Integration.NUnit.Infrastructure
{
    [TestFixture]
    public class MessageServiceTest
    {
        public string certificateUrl { get; } = TestContext.CurrentContext.TestDirectory + "\\Certificates\\KommunA.p12";
        public string certificatePassword { get; } = "4729451359506045";
        public string certificateCN { get; } = "Kommun A";

        public string endpointAdressAuthory { get; set; } = @"https://notarealhost.skatteverket.se/webservice/acc1accao/Authority";

        public string endpointAdressRecipient { get; set; } = @"https://notarealhost.skatteverket.se/webservice/acc1accao/Recipient/v3";

        [Test]
        public async Task distributeSecure_CertificateFromUrl()
        {
            //Arrange
            var logger = new Logger<MessageService>(new NullLoggerFactory());
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(TestContext.CurrentContext.TestDirectory + @"\\TestSets\\SignedDelivery.xml");
            string defaultNamespace = DefaultNamespace.v3.AsString(EnumFormat.Description);
            var serializeHelper = new SerializeHelper(logger);
            var signedDelivery = serializeHelper.DeserializeXmlToSignedDeliveryV3(xmlDocument, defaultNamespace);
            var messageService = new MessageService(logger);

            //Act
            var result =await messageService.distributeSecure(signedDelivery, endpointAdressRecipient, endpointAdressAuthory,  certificateUrl, certificatePassword);

            //Assert
            Assert.IsTrue(result.Status != null);
        }

        [Test]
        [Explicit]
        public async Task distributeSecure_CertificateFromStore()
        {
            //Arrange
            var logger = new Logger<MessageService>(new NullLoggerFactory());
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(TestContext.CurrentContext.TestDirectory + @"\\TestSets\\SignedDelivery.xml");
            string defaultNamespace = DefaultNamespace.v3.AsString(EnumFormat.Description);
            var serializeHelper = new SerializeHelper(logger);
            var signedDelivery = serializeHelper.DeserializeXmlToSignedDeliveryV3(xmlDocument, defaultNamespace);
            var messageService = new MessageService(logger);

            //Act
            var result =await messageService.distributeSecure(signedDelivery, endpointAdressRecipient, endpointAdressAuthory, certificateCN);

            //Assert
            Assert.IsTrue(result.Status != null);
        }

        [Test]
        public async Task distributeSecure_CertificateIncluded()
        {
            //Arrange
            var logger = new Logger<MessageService>(new NullLoggerFactory());
            var log = new Logger<CertificateHelper>(new NullLoggerFactory());

            var xmlDocument = new XmlDocument();
            xmlDocument.Load(TestContext.CurrentContext.TestDirectory + @"\\TestSets\\SignedDelivery.xml");
            string defaultNamespace = DefaultNamespace.v3.AsString(EnumFormat.Description);
            var serializeHelper = new SerializeHelper(logger);
            var signedDelivery = serializeHelper.DeserializeXmlToSignedDeliveryV3(xmlDocument, defaultNamespace);
            var messageService = new MessageService(logger);
            var certificateHelper = new CertificateHelper(log);
            var x509Certificate2 = certificateHelper.GetXMLSigningCertificateFromUrl(certificateUrl, certificatePassword);
           
            //Act
            var result =await messageService.distributeSecure(signedDelivery, endpointAdressRecipient, endpointAdressAuthory, x509Certificate2);

            //Assert
            Assert.IsTrue(result.Status != null);
        }

        [Test]
        public async Task distributeSecurePreSigned()
        {
            //Arrange
            var logger = new Logger<MessageService>(new NullLoggerFactory());
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(TestContext.CurrentContext.TestDirectory + @"\\TestSets\\SignedDeliveryWithoutSignature.xml");
            string defaultNamespace = DefaultNamespace.v3.AsString(EnumFormat.Description);
            var serializeHelper = new SerializeHelper(logger);
            var signedDelivery = serializeHelper.DeserializeXmlToSignedDeliveryV3(xmlDocument, defaultNamespace);
            var messageService = new MessageService(logger);

            //Act
            var result = await messageService.distributeSecure(signedDelivery, endpointAdressRecipient, endpointAdressAuthory, certificateUrl, certificatePassword);

            //Assert
            Assert.IsTrue(result.Status != null);
        }

        [Test]
        public async Task getSenders()
        {
            //Arrange
            var logger = new Logger<MessageService>(new NullLoggerFactory());
            var log = new Logger<CertificateHelper>(new NullLoggerFactory());

            var messageService = new MessageService(logger);
            var certificateHelper = new CertificateHelper(log);
            var x509Certificate2 = certificateHelper.GetXMLSigningCertificateFromUrl(certificateUrl, certificatePassword);

            //Act
            var result =await messageService.GetSenders(endpointAdressAuthory, x509Certificate2);
            result.ToList().ForEach(x=> 
            {
                Console.WriteLine(x.Attention + " " + x.Id + " " +x.Name);
            });
            //Assert
            Assert.IsTrue(result.ToList().Count>0);

        }
//        19861003T010
        [Test]
        public async Task IsUserReachableInFaRV3()
        {
            //Arrange
            var logger = new Logger<MessageService>(new NullLoggerFactory());
            var messageService = new MessageService(logger);
            var recipientId = @"197710182382";
            var senderOrgNr = @"162120001355";
           

            //Act
            var result = await messageService.IsUserReachableInFaRV3(recipientId, senderOrgNr, endpointAdressRecipient, certificateUrl, certificatePassword);

            //Assert
            Assert.IsTrue(result.ToList()[0].SenderAccepted);

        }
        [Test]
        public async Task UserNotReachableInFaRV3()
        {
            //Arrange
            var logger = new Logger<MessageService>(new NullLoggerFactory());
            var messageService = new MessageService(logger);
            var recipientId = @"197810182382";
            var senderOrgNr = @"162120001355";


            //Act
            var result = await messageService.IsUserReachableInFaRV3(recipientId, senderOrgNr, endpointAdressRecipient, certificateUrl, certificatePassword);

            //Assert
            Assert.IsTrue(!result.ToList()[0].SenderAccepted);

        }

        [Test]
        public async Task UserValidationErrorReachableInFaRV3()
        {
            //Arrange
            var logger = new Logger<MessageService>(new NullLoggerFactory());
            var messageService = new MessageService(logger);
            var recipientId = @"19861003T010";
            var senderOrgNr = @"162120001355";


            //Act
            try
            {
                var result = await messageService.IsUserReachableInFaRV3(recipientId, senderOrgNr, endpointAdressRecipient, certificateUrl, certificatePassword);
                Assert.Fail();
            }
            catch (CommunicationException ex) 
            {
                Assert.Pass();
            }
            

           

        }
    }
}
