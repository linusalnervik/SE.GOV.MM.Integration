using Authority;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Recipient;
using SE.GOV.MM.Integration.Core.Model;
using Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SE.GOV.MM.Integration.Infrastructure
{
    internal class MessageHandler
    {
        private readonly ILogger logger;
        public  MessageHandler(ILogger logger)
        {
            this.logger = logger;
        }

        public MessageHandler()
        {
         this.logger = new Logger<MessageHandler>(new NullLoggerFactory());

        }

        internal async Task<DeliveryResult> SendMessageToMailBoxOperator(SealedDelivery SealedDelivery, X509Certificate2 x509Certificate2, string endpointAdress, int timeoutInSeconds = 60)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageHandler: entering SendMessageToMailBoxOperator"));


            var binding = GetBinding(timeoutInSeconds);

            try
            {
                var client = new ServicePortv3Client(binding, new EndpointAddress(endpointAdress));
                client.ClientCredentials.ClientCertificate.Certificate = x509Certificate2;

                logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageHandler: Sending message to MailBoxOperator"));
                var response= await client.deliverSecureAsync(SealedDelivery);
                logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageHandler: leaving SendMessageToMailBoxOperator"));
                return response.@return;
            }
            catch (Exception ce)
            {
                logger.LogError(ce, ce.Message);
                throw ce;
            }
        }

        /// <summary>
        /// Call webservice RecipientV3 in FaR
        /// </summary>
        /// <param name="recipient">Recipient to check if reachable</param>
        /// <param name="senderOrgNr">Sender Organizationnumber</param>
        /// <returns></returns>
        internal async Task<isReachableResponse> IsUserReachableInFaRV3(string recipientId, string senderOrgNr, string endpointAdress, X509Certificate2 x509Certificate2, int timeoutInSeconds=60)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageHandler: incoming IsUserReachableInFaRV3"));

            isReachableResponse status = null;
         
            try
            {
                using (var client = new RecipientPortv3Client(GetBinding(timeoutInSeconds), GetEndpoint(endpointAdress)))
                {
                    client.ClientCredentials.ClientCertificate.Certificate = x509Certificate2;
                    status = await client.isReachableAsync(senderOrgNr, new string[] { recipientId });

                    logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageHandler: leaving IsUserReachableInFaRV3"));
                    return status;
                }

            }
            catch (SecurityNegotiationException se)
            {
                string errorMessage = string.Format("SE.GOV.MM.Integration.Infrastructure.MessageHandler: SecurityNegotiationException during request to Recipient, Exception: {0}, Trying to check recipient: {1}", se.Message, recipientId);
                logger.LogError(se, errorMessage);

                throw se;
            }
            catch (TimeoutException te)
            {
                string errorMessage = string.Format("SE.GOV.MM.Integration.Infrastructure.MessageHandler: TimeoutException during request to Recipient, Exception: {0}, Trying to check recipient: {1}.", te.Message, recipientId);
                logger.LogError(te, errorMessage);


                throw te;
            }
            catch (CommunicationException ce)
            {
                string errorMessage = string.Format("SE.GOV.MM.Integration.Infrastructure.MessageHandler: CommunicationException during request to Recipient, Exception: {0}, Trying to check recipient: {1}.", ce.Message, recipientId);
                logger.LogError(ce, errorMessage);

                throw ce;
            }
            catch (Exception e)
            {
                string errorMessage = string.Format("SE.GOV.MM.Integration.Infrastructure.MessageHandler: Exception during request to Recipient, Exception: {0}, Trying to check recipient: {1}.", e, recipientId);
                logger.LogError(e, errorMessage);

                throw e;
            }
           
         

        }

        internal async Task<Sender[]> GetSendersResponse(X509Certificate2 x509Certificate2, string endpointAddress, int timeoutInSeconds=60)
        {
            var client = new AuthorityPortClient(GetBinding(timeoutInSeconds), GetEndpoint(endpointAddress));
            client.ClientCredentials.ClientCertificate.Certificate = x509Certificate2;

            var response =await client.getSendersAsync();
            
            return response.@return;

        }



        private BasicHttpBinding GetBinding(int timeoutInSeconds)
        {
            return new BasicHttpBinding()
            {
                MaxBufferSize = 2147483647,
                MaxReceivedMessageSize = 2147483647,
                Name = "Binding",
                Security = new BasicHttpSecurity()
                {
                    Mode = BasicHttpSecurityMode.Transport,
                    Transport = new HttpTransportSecurity()
                    {
                        ClientCredentialType = HttpClientCredentialType.Certificate
                    }
                },
                OpenTimeout = TimeSpan.FromMinutes(timeoutInSeconds),
                SendTimeout = TimeSpan.FromMinutes(timeoutInSeconds),
                ReceiveTimeout = TimeSpan.FromMinutes(timeoutInSeconds),
                CloseTimeout = TimeSpan.FromMinutes(timeoutInSeconds)
            };
        }

        private EndpointAddress GetEndpoint(string url)
        {
            return new EndpointAddress(url);
        }
    }
}
