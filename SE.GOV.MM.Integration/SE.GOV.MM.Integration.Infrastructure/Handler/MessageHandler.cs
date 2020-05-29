using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SE.GOV.MM.Integration.Infrastructure
{
    internal class MessageHandler
    {
        private readonly ILogger logger;
        internal MessageHandler(ILogger logger)
        {
            this.logger = logger;
        }

        internal DeliveryResult SendMessageToMailBoxOperator(SealedDelivery2 sealedDelivery2, X509Certificate2 x509Certificate2, string endpointAdress)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageHandler: entering SendMessageToMailBoxOperator"));

            var binding = new BasicHttpBinding()
            {
                Security = new BasicHttpSecurity()
                {
                    Transport = new HttpTransportSecurity()
                    {
                        ClientCredentialType = HttpClientCredentialType.Certificate
                    },
                    Mode = BasicHttpSecurityMode.Transport
                }
            };

            try
            {
                var client = new ServicePortv3Client(binding, new EndpointAddress(endpointAdress));
                client.ClientCredentials.ClientCertificate.Certificate = x509Certificate2;

                logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageHandler: Sending message to MailBoxOperator"));
                var response= client.deliverSecure(sealedDelivery2);
                logger.LogTrace(string.Format("SE.GOV.MM.Integration.Infrastructure.MessageHandler: leaving SendMessageToMailBoxOperator"));
                return response;
            }
            catch (Exception ce)
            {
                logger.LogError(ce, ce.Message);
                throw ce;
            }
        }
    }
}
