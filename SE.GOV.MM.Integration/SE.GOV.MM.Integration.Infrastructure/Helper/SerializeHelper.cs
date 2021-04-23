using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using SE.GOV.MM.Integration.Core.Interface;
using SE.GOV.MM.Integration.Core.Model;
using Service;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SE.GOV.MM.Integration.Infrastructure
{
    public class SerializeHelper:ISerializeHelper
    {
        private readonly ILogger logger;

        public SerializeHelper(ILogger logger)
        {
            this.logger = logger;
        }

        public SerializeHelper()
        {
            logger = new Logger<SerializeHelper>(new NullLoggerFactory());
        }

        /// <summary>
        /// Serialize a SignedDelivery object to a XmlDocument. using defaultnamespaceV3.
        /// </summary>
        public XmlDocument SerializeToXmlDocumentV3(SignedDelivery signedDelivery, string defaultNameSpace)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelperV3: incoming SerializeToXmlDocumentV3"));

            var xmlDocument = new XmlDocument();
            xmlDocument.PreserveWhitespace = false;

            var xmlSerializerNameSpace = new XmlSerializerNamespaces();
            xmlSerializerNameSpace.Add("", defaultNameSpace);

            using (var memoryStream = new MemoryStream())
            {
                var xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.OmitXmlDeclaration = true;
                xmlWriterSettings.Encoding = Encoding.UTF8;

                using (var xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings))
                {
                    var xmlSerializer = new XmlSerializer(typeof(SignedDelivery), defaultNameSpace);
                    xmlSerializer.Serialize(xmlWriter,(SignedDelivery) signedDelivery, xmlSerializerNameSpace);
                }

                memoryStream.Position = 0;
                xmlDocument.Load(memoryStream);
            }

            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: leaving SerializeToXmlDocumentV3"));
            return xmlDocument;
        }

        /// <summary>
        /// Serialize a SealedDelivery object to a XmlDocument. using defaultnamespaceV2, that is a property from config file, add this to xmlserializer.
        /// </summary>
        public XmlDocument SerializeToXmlDocumentV3(SealedDelivery sealedDelivery, string defaultNameSpaceV3)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: incoming SerializeToXmlDocumentV3"));

            var xmlDocument = new XmlDocument();
            xmlDocument.PreserveWhitespace = false;

            var xmlSerializerNameSpace = new XmlSerializerNamespaces();
            xmlSerializerNameSpace.Add("", defaultNameSpaceV3);

            using (var memoryStream = new MemoryStream())
            {
                var xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.OmitXmlDeclaration = true;
                xmlWriterSettings.Encoding = Encoding.UTF8;

                using (var xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings))
                {
                    var xmlSerializer = new XmlSerializer(typeof(SealedDelivery), defaultNameSpaceV3);
                    xmlSerializer.Serialize(xmlWriter,sealedDelivery, xmlSerializerNameSpace);
                }

                memoryStream.Position = 0;
                xmlDocument.Load(memoryStream);
            }

            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: leaving SerializeToXmlDocumentV3"));
            return xmlDocument;
        }

        /// <summary>
        /// Read the xmldocument and deserialize it to a SignedDelivery object. Important to use the default namespace for version 2.
        /// </summary>
        public SignedDelivery DeserializeXmlToSignedDeliveryV3(XmlDocument xmlDocument, string defaultNameSpaceV3)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: incoming DeserializeXmlToSignedDeliveryV3"));

            SignedDelivery signedDelivery;
            using (var memoryStream = new MemoryStream(UTF8Encoding.UTF8.GetBytes(xmlDocument.OuterXml)))
            {
                var xmlSerializer = new XmlSerializer(typeof(SignedDelivery), defaultNameSpaceV3);
                signedDelivery = (SignedDelivery)xmlSerializer.Deserialize(memoryStream);

            };

            var xmlDocumentAsString = string.Empty;
            using (var stringWriter = new StringWriter())
            {
                using (var xmlTextWriter = XmlWriter.Create(stringWriter))
                {
                    xmlDocument.WriteTo(xmlTextWriter);
                    xmlTextWriter.Flush();
                    xmlDocumentAsString = stringWriter.GetStringBuilder().ToString();
                }
            }

            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: leaving DeserializeXmlToSignedDeliveryV3"));
            return signedDelivery;
        }

        /// <summary>
        /// Read the xmldocument and deserialize it to a SealedDelivery object. Important to use the default namespace.
        /// </summary>
        public SealedDelivery DeserializeXmlToSealedDeliveryV3(XmlDocument xmlDocument, string defaultNameSpaceV3)
        {
            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: incoming DeserializeXmlToSealedDeliveryV3"));

            SealedDelivery sealedDelivery;
            using (var memoryStream = new MemoryStream(UTF8Encoding.UTF8.GetBytes(xmlDocument.OuterXml)))
            {
                var xmlSerializer = new XmlSerializer(typeof(SealedDelivery), defaultNameSpaceV3);
                sealedDelivery = (SealedDelivery)xmlSerializer.Deserialize(memoryStream);

            };

            var xmlDocumentAsString = string.Empty;
            using (var stringWriter = new StringWriter())
            {
                using (var xmlTextWriter = XmlWriter.Create(stringWriter))
                {
                    xmlDocument.WriteTo(xmlTextWriter);
                    xmlTextWriter.Flush();
                    xmlDocumentAsString = stringWriter.GetStringBuilder().ToString();
                }
            }

            logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: leaving DeserializeXmlToSealedDeliveryV3"));
            return sealedDelivery;
        }
    }
}
