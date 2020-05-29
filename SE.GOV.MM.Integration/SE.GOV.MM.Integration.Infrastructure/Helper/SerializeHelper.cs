﻿using Microsoft.Extensions.Logging;
using SE.GOV.MM.Integration.Core.Interface;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SE.GOV.MM.Integration.Infrastructure
{
    public class SerializeHelper:ISerializeHelper
    {
        private readonly ILogger _logger;

        public SerializeHelper(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Serialize a SignedDelivery2 object to a XmlDocument. using defaultnamespaceV3.
        /// </summary>
       internal XmlDocument SerializeToXmlDocumentV3(SignedDelivery2 signedDelivery, string defaultNameSpace)
        {
            _logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelperV3: incoming SerializeToXmlDocumentV3"));

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
                    var xmlSerializer = new XmlSerializer(typeof(SignedDelivery2), defaultNameSpace);
                    xmlSerializer.Serialize(xmlWriter,(SignedDelivery2) signedDelivery, xmlSerializerNameSpace);
                }

                memoryStream.Position = 0;
                xmlDocument.Load(memoryStream);
            }

            _logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: leaving SerializeToXmlDocumentV3"));
            return xmlDocument;
        }

        /// <summary>
        /// Serialize a SealedDelivery2 object to a XmlDocument. using defaultnamespaceV2, that is a property from config file, add this to xmlserializer.
        /// </summary>
        internal XmlDocument SerializeToXmlDocumentV3(SealedDelivery2 sealedDelivery, string defaultNameSpaceV3)
        {
            _logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: incoming SerializeToXmlDocumentV3"));

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
                    var xmlSerializer = new XmlSerializer(typeof(SealedDelivery2), defaultNameSpaceV3);
                    xmlSerializer.Serialize(xmlWriter,sealedDelivery, xmlSerializerNameSpace);
                }

                memoryStream.Position = 0;
                xmlDocument.Load(memoryStream);
            }

            _logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: leaving SerializeToXmlDocumentV3"));
            return xmlDocument;
        }

        /// <summary>
        /// Read the xmldocument and deserialize it to a SignedDelivery2 object. Important to use the default namespace for version 2.
        /// </summary>
        public SignedDelivery2 DeserializeXmlToSignedDeliveryV3(XmlDocument xmlDocument, string defaultNameSpaceV3)
        {
            _logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: incoming DeserializeXmlToSignedDeliveryV3"));

            SignedDelivery2 signedDelivery;
            using (var memoryStream = new MemoryStream(UTF8Encoding.UTF8.GetBytes(xmlDocument.OuterXml)))
            {
                var xmlSerializer = new XmlSerializer(typeof(SignedDelivery2), defaultNameSpaceV3);
                signedDelivery = (SignedDelivery2)xmlSerializer.Deserialize(memoryStream);

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

            _logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: leaving DeserializeXmlToSignedDeliveryV3"));
            return signedDelivery;
        }

        /// <summary>
        /// Read the xmldocument and deserialize it to a SealedDelivery2 object. Important to use the default namespace.
        /// </summary>
        public SealedDelivery2 DeserializeXmlToSealedDeliveryV3(XmlDocument xmlDocument, string defaultNameSpaceV3)
        {
            _logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: incoming DeserializeXmlToSealedDeliveryV3"));

            SealedDelivery2 sealedDelivery;
            using (var memoryStream = new MemoryStream(UTF8Encoding.UTF8.GetBytes(xmlDocument.OuterXml)))
            {
                var xmlSerializer = new XmlSerializer(typeof(SealedDelivery2), defaultNameSpaceV3);
                sealedDelivery = (SealedDelivery2)xmlSerializer.Deserialize(memoryStream);

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

            _logger.LogTrace(string.Format("SE.GOV.MM.Integration.Signing.Helper.SerializeHelper: leaving DeserializeXmlToSealedDeliveryV3"));
            return sealedDelivery;
        }
    }
}
