using EnumsNET;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using static SE.GOV.MM.Integration.Core.Model.Enums;

namespace SE.GOV.MM.Integration.Infrastructure.Services
{
    public class MessageService : IMessageService
    {
        private readonly ILogger logger;

        public MessageService()
        {
            logger = new Logger<MessageService>(new NullLoggerFactory());
        }

        public MessageService(ILogger logger)
        {
            this.logger = logger;
        }

        public DeliveryResult distributeSecure(SignedDelivery2 signedDelivery2, string endpointAdress, string certificateUrl, string certificatePassword)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: entering distributeSecure"));
            try
            {
                // Get X509Certificate
                var certificateHelper = new CertificateHelper(logger);
                var x509Certificate = certificateHelper.GetXMLSigningCertificateFromUrl(certificateUrl, certificatePassword);

                logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: leaving distributeSecure"));
                return handleDistributeSecure(signedDelivery2, endpointAdress, x509Certificate);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw ex;
            }
        }

        public DeliveryResult distributeSecure(SignedDelivery2 signedDelivery2, string endpointAdress, string signingCertificateSubjectName)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: entering distributeSecure"));
            try
            {
                // Get X509Certificate
                var certificateHelper = new CertificateHelper(logger);
                var x509Certificate = certificateHelper.GetXMLSigningCertificateFromStore(signingCertificateSubjectName);

                logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: leaving distributeSecure"));
                return handleDistributeSecure(signedDelivery2, endpointAdress, x509Certificate);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw ex;
            }

        }

        public DeliveryResult distributeSecure(SignedDelivery2 signedDelivery2, string endpointAdress, X509Certificate2 x509Certificate2)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: entering distributeSecure"));
            try
            {
                if (!x509Certificate2.HasPrivateKey)
                {
                    var errorMessage = string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService.distributeSecure: No valid certificate, private key missing");
                    logger.LogError(errorMessage);
                    throw new Exception(errorMessage);
                }
                logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: leaving distributeSecure"));
                return handleDistributeSecure(signedDelivery2, endpointAdress, x509Certificate2);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw ex;
            }
        }

        public bool IsValidSignature(XmlDocument xmlDocument)
        {

            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: entering IsValidSignature"));
            try
            {
                var signingHandler = new SigningHandler();
                var isValid = signingHandler.IsValidSignature(xmlDocument);
                logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: leaving IsValidSignature"));
                return isValid;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw ex;
            }
        }

        private DeliveryResult handleDistributeSecure(SignedDelivery2 signedDelivery2, string endpointAdress, X509Certificate2 x509Certificate)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: entering handleDistributeSecure"));

            // Initiate serializeHelper
            var serializehelper = new SerializeHelper(logger);

            // SerializeToXmlDocument
            string defaultNamespace = DefaultNamespace.v3.AsString(EnumFormat.Description);
            var xmlDocSignedDelivery = serializehelper.SerializeToXmlDocumentV3(signedDelivery2, defaultNamespace);

            // Initiate signingHandler
            var signingHandler = new SigningHandler(x509Certificate);

            // Check if signed by Sender, otherwize sign signedDelivery2
            if (!signingHandler.IsMessageSigned(xmlDocSignedDelivery))
            {
                signingHandler.SignXmlDocument(xmlDocSignedDelivery, TagName.Delivery.AsString(EnumFormat.Description));
                signedDelivery2 = serializehelper.DeserializeXmlToSignedDeliveryV3(xmlDocSignedDelivery, defaultNamespace);
            }

            // Create signed sealeddelivery 
            var sealedDelivery2 = CreateSealadDelivery();
            sealedDelivery2.SignedDelivery = signedDelivery2;
            var xmlDocSealedDelivery = serializehelper.SerializeToXmlDocumentV3(sealedDelivery2, defaultNamespace);
            signingHandler.SignXmlDocument(xmlDocSealedDelivery, TagName.Seal.AsString(EnumFormat.Description));
            sealedDelivery2 = serializehelper.DeserializeXmlToSealedDeliveryV3(xmlDocSealedDelivery, defaultNamespace);


            // Send to Operator
            var messageHandler = new MessageHandler(logger);

            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: leaving handleDistributeSecure"));
            return messageHandler.SendMessageToMailBoxOperator(sealedDelivery2, x509Certificate, endpointAdress);

        }

        private static SealedDelivery2 CreateSealadDelivery()
        {
            return new SealedDelivery2()
            {
                Seal = new Seal()
                {
                    ReceivedTime = DateTime.Now,
                    SignaturesOK = true
                }
            };
        }
    }
}
