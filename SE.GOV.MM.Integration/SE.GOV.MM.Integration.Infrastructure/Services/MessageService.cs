using Authority;
using EnumsNET;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Recipient;
using SE.GOV.MM.Integration.Core.Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static SE.GOV.MM.Integration.Core.Model.Enums;

namespace SE.GOV.MM.Integration.Infrastructure.Services
{
    public class MessageService : IMessageService
    {
        private readonly ILogger logger;
        public int timeoutInSeconds = 60;

        public MessageService()
        {
            logger = new Logger<MessageService>(new NullLoggerFactory());
        }

        public MessageService(ILogger logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Handles sending message to user.
        /// </summary>
        /// <param name="SignedDelivery">Message to process</param>
        /// <param name="endpointAdressRecipient">Endpoint to send recipient request </param>
        /// <param name="endpointAdressAuthority">Endpoint to send authority request</param>
        /// <param name="certificateUrl">Path to certificate</param>
        /// <param name="certificatePassword">Password to certificate</param>
        /// <returns>Result of sending message</returns>
        public async Task<DeliveryResult> distributeSecure(SignedDelivery SignedDelivery, string endpointAdressRecipient, string endpointAdressAuthority, string certificateUrl, string certificatePassword)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: entering distributeSecure"));
            try
            {
                var log = new Logger<CertificateHelper>(new NullLoggerFactory());
                // Get X509Certificate
                var certificateHelper = new CertificateHelper(log);
                var x509Certificate = certificateHelper.GetXMLSigningCertificateFromUrl(certificateUrl, certificatePassword);

                logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: leaving distributeSecure"));
                return await handleDistributeSecure(SignedDelivery, endpointAdressAuthority, endpointAdressRecipient, x509Certificate);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Handles sending message to user.
        /// </summary>
        /// <param name="SignedDelivery">Message to process</param>
        /// <param name="endpointAdressRecipient">Endpoint to send recipient request </param>
        /// <param name="endpointAdressAuthority">Endpoint to send authority request</param>
        /// <param name="signingCertificateSubjectName">Certificate name in store</param>
        /// <returns>Result of sending message</returns>
        public async Task<DeliveryResult> distributeSecure(SignedDelivery SignedDelivery, string endpointAdressRecipient, string endpointAdressAuthority, string signingCertificateSubjectName)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: entering distributeSecure"));
            try
            {
                var log = new Logger<CertificateHelper>(new NullLoggerFactory());
                // Get X509Certificate
                var certificateHelper = new CertificateHelper(log);
                var x509Certificate = certificateHelper.GetXMLSigningCertificateFromStore(signingCertificateSubjectName);

                logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: leaving distributeSecure"));
                return await handleDistributeSecure(SignedDelivery, endpointAdressAuthority, endpointAdressRecipient, x509Certificate);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// Handles sending message to user.
        /// </summary>
        /// <param name="SignedDelivery">Message to process</param>
        /// <param name="endpointAdressRecipient">Endpoint to send recipient request </param>
        /// <param name="endpointAdressAuthority">Endpoint to send authority request</param>
        /// <param name="x509Certificate2">Certificate to sign with</param>
        /// <returns></returns>
        public async Task<DeliveryResult> distributeSecure(SignedDelivery SignedDelivery, string endpointAdressRecipient, string endpointAdressAuthority, X509Certificate2 x509Certificate2)
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
                return await handleDistributeSecure(SignedDelivery, endpointAdressAuthority, endpointAdressRecipient, x509Certificate2);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Validates if xmldocument contains a valid signature
        /// </summary>
        /// <param name="xmlDocument">Xmldocument to verify</param>
        /// <returns>true/false</returns>
        public async Task<bool> IsValidSignature(XmlDocument xmlDocument)
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

        /// <summary>
        /// Checks if recipient is reachable in FaR
        /// </summary>
        /// <param name="recipientId">Recipient person number</param>
        /// <param name="senderOrgNr">Sending organization number</param>
        /// <param name="endpointAdress">>Endpoint to send recipient request</param>
        /// <param name="certificateUrl">Path to certificate</param>
        /// <param name="certificatePassword">Password to certificate</param>
        /// <returns>Reachable status</returns>
        public async Task<ReachabilityStatus[]> IsUserReachableInFaRV3(string recipientId, string senderOrgNr, string endpointAdress, string certificateUrl, string password)
        {
            try
            {
                var log = new Logger<CertificateHelper>(new NullLoggerFactory());

                // Get X509Certificate
                var certificateHelper = new CertificateHelper(log);
                var x509Certificate = certificateHelper.GetXMLSigningCertificateFromUrl(certificateUrl, password);

                return await handleIsUserReachableInFaRV3(recipientId, senderOrgNr, endpointAdress, x509Certificate);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Checks if recipient is reachable in FaR
        /// </summary>
        /// <param name="recipientId">Recipient person number</param>
        /// <param name="senderOrgNr">Sending organization number</param>
        /// <param name="endpointAdress">>Endpoint to send recipient request</param>
        /// <param name="signingCertificateSubjectName">Certificate name in store</param>
        /// <returns>Reachable status</returns>
        public async Task<ReachabilityStatus[]> IsUserReachableInFaRV3(string recipientId, string senderOrgNr, string endpointAdress, string signingCertificateSubjectName)
        {

            try
            {
                var log = new Logger<CertificateHelper>(new NullLoggerFactory());

                // Get X509Certificate
                var certificateHelper = new CertificateHelper(log);
                var x509Certificate = certificateHelper.GetXMLSigningCertificateFromStore(signingCertificateSubjectName);

                return await handleIsUserReachableInFaRV3(recipientId, senderOrgNr, endpointAdress, x509Certificate);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Checks if recipient is reachable in FaR
        /// </summary>
        /// <param name="recipientId">Recipient person number</param>
        /// <param name="senderOrgNr">Sending organization number</param>
        /// <param name="endpointAdress">>Endpoint to send recipient request</param>
        /// <param name="x509Certificate2">Certificate to sign with</param>
        /// <returns>Reachable status</returns>
        public async Task<ReachabilityStatus[]> IsUserReachableInFaRV3(string recipientId, string senderOrgNr, string endpointAdress, X509Certificate2 x509Certificate)
        {
            try
            {
                logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: entering IsUserReachableInFaRV3"));

                return await handleIsUserReachableInFaRV3(recipientId, senderOrgNr, endpointAdress, x509Certificate);

            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// Gets all registered senders
        /// </summary>
        /// <param name="endpointAdressAuthority">Endpoint to send authority request</param>
        /// <param name="x509Certificate2">Certificate to post with</param>
        /// <returns></returns>
        public async Task<Sender[]> GetSenders(string endpointAdress, X509Certificate2 x509Certificate2)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: entering GetSenders"));
          
            // Initiate messageHandler
            var messageHandler = new MessageHandler(logger, timeoutInSeconds);

            //Get IsUserReachable Status
            var response = await messageHandler.GetSendersResponse(x509Certificate2, endpointAdress);
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: leaving GetSenders"));

            return response;
        }



        #region private


        private async Task<ReachabilityStatus[]> handleIsUserReachableInFaRV3(string recipientId, string senderOrgNr, string endpointAdress, X509Certificate2 x509Certificate)
        {
            // Initiate messageHandler
            var messageHandler = new MessageHandler(logger, timeoutInSeconds);

            //Get IsUserReachable Status
            var response = await messageHandler.IsUserReachableInFaRV3(recipientId, senderOrgNr, endpointAdress, x509Certificate);
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: leaving IsUserReachableInFaRV3"));

            return response.@return;
        }

        private async Task<DeliveryResult> handleDistributeSecure(SignedDelivery SignedDelivery, string endpointAdressAuthority, string endpointAdressRecipient, X509Certificate2 x509Certificate)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: entering handleDistributeSecure"));

            // Initilize messageHandler
            var messageHandler = new MessageHandler(logger, timeoutInSeconds);

            //Check if valid Sender
            var senders = await GetSenders(endpointAdressAuthority, x509Certificate);
            if (!senders.Select(x => x.Id).Contains(SignedDelivery.Delivery.Header.Sender.Id))
            {
                var errorMessage = $"SE.GOV.MM.Integration.Infrastructure.MessageService: not valid SenderId={SignedDelivery.Delivery.Header.Sender.Id} in metod handleDistributeSecure";
                logger.LogWarning(errorMessage);
                throw new Exception(errorMessage);
            }

            // Initiate serializeHelper
            var serializehelper = new SerializeHelper(logger);

            // SerializeToXmlDocument
            string defaultNamespace = DefaultNamespace.v3.AsString(EnumFormat.Description);
            var xmlDocSignedDelivery = serializehelper.SerializeToXmlDocumentV3(SignedDelivery, defaultNamespace);

            // Initiate signingHandler
            var signingHandler = new SigningHandler(x509Certificate);

            // Check if signed by Sender, otherwize sign SignedDelivery
            if (!signingHandler.IsMessageSigned(xmlDocSignedDelivery))
            {
                signingHandler.SignXmlDocument(xmlDocSignedDelivery, TagName.Delivery.AsString(EnumFormat.Description));
                SignedDelivery = serializehelper.DeserializeXmlToSignedDeliveryV3(xmlDocSignedDelivery, defaultNamespace);
            }

            // Create signed sealeddelivery 
            var SealedDelivery = CreateSealadDelivery();
            SealedDelivery.SignedDelivery = SignedDelivery;
            var xmlDocSealedDelivery = serializehelper.SerializeToXmlDocumentV3(SealedDelivery, defaultNamespace);
            signingHandler.SignXmlDocument(xmlDocSealedDelivery, TagName.Seal.AsString(EnumFormat.Description));
            SealedDelivery = serializehelper.DeserializeXmlToSealedDeliveryV3(xmlDocSealedDelivery, defaultNamespace);

            // Verify that Receiver is reachable
            var isReachable = await handleIsUserReachableInFaRV3(
                SignedDelivery.Delivery.Header.Recipient,
                SignedDelivery.Delivery.Header.Sender.Id,
                endpointAdressRecipient, x509Certificate);

            // Send to Operator
            if (isReachable == null || isReachable.Count() == 0) throw new Exception($"SE.GOV.MM.Integration.Infrastructure.MessageService: Recipient is not reachable {SignedDelivery.Delivery.Header.Recipient}");
            if (!isReachable[0].SenderAccepted) throw new Exception($"SE.GOV.MM.Integration.Infrastructure.MessageService: Recipient '{SignedDelivery.Delivery.Header.Recipient}' " +
                $"does not accept delivery from supplier '{SignedDelivery.Delivery.Header.Sender.Id}' ");
            if (isReachable[0]?.AccountStatus?.ServiceSupplier == null && isReachable[0]?.AccountStatus?.ServiceSupplier?.UIAdress == null)
                throw new Exception($"SE.GOV.MM.Integration.Infrastructure.MessageService: Recipient does not have an account in FaR {SignedDelivery.Delivery.Header.Recipient}");

            var baseAdressServiceSupplier = isReachable[0].AccountStatus.ServiceSupplier.ServiceAdress;
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageService: leaving handleDistributeSecure"));
            return await messageHandler.SendMessageToMailBoxOperator(SealedDelivery, x509Certificate, baseAdressServiceSupplier);
        }


        private static SealedDelivery CreateSealadDelivery()
        {
            return new SealedDelivery()
            {
                Seal = new Seal()
                {
                    ReceivedTime = DateTime.Now,
                    SignaturesOK = true
                }
            };
        }
        #endregion
    }
}
