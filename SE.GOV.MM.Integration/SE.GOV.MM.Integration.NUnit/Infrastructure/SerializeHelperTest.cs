﻿using EnumsNET;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.EventLog;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using SE.GOV.MM.Integration.Core.Interface;
using SE.GOV.MM.Integration.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static SE.GOV.MM.Integration.Core.Model.Enums;

namespace SE.GOV.MM.Integration.NUnit.Infrastructure
{
    [TestFixture]
    public class SerializeHelperTest
    {
        public SignedDelivery2 signedDelivery2 { get; set; }
        public SealedDelivery2 sealedDelivery2 { get; set; }
        public SerializeHelper serializeHelper { get; set; }
       

        [SetUp]
        public void Setup()
        {
            signedDelivery2 = SetupSignedDelivery2();
            sealedDelivery2 = SetupSealedDelivery2();
            var logger= SetupLogging();
            serializeHelper = new SerializeHelper(logger);
        }

        [Test]
        public void DeserializeXmlToSignedDeliveryV3_SignedDeliveryWithSignature()
        {
            //Arrange
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(TestContext.CurrentContext.TestDirectory + @"\\TestSets\\SignedDeliveryWithSignature.xml");
            string defaultNamespace = DefaultNamespace.v3.AsString(EnumFormat.Description);

            //Act
            var response = serializeHelper.DeserializeXmlToSignedDeliveryV3(xmlDocument, defaultNamespace);

            //Assert
            Assert.IsTrue(response!=null);
            Assert.IsTrue(response.Signature!=null);
        }

   
        [Test]
        public void DeserializeXmlToSealedDeliveryV3_SealedDeliveryWithSignature()
        {
            //Arrange
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(TestContext.CurrentContext.TestDirectory + @"\\TestSets\\SealedDeliveryWithSignature.xml");
            string defaultNamespace = DefaultNamespace.v3.AsString(EnumFormat.Description);

            //Act
            var response = serializeHelper.DeserializeXmlToSealedDeliveryV3(xmlDocument, defaultNamespace);

            //Assert
            Assert.IsTrue(response != null);
            Assert.IsTrue(response.Signature != null);
        }

        #region Setup

        private static SignedDelivery2 SetupSignedDelivery2()
        {
          return new SignedDelivery2()
            {
                Delivery = new SecureDelivery2()
                {
                    Header = new SecureDeliveryHeader() { Sender = new Sender() { Id = "162021004748", Name = "Kommun A" }, Recipient = "198101052382" },
                    Message = new SecureMessage1[] { new SecureMessage1()
                    {
                        Header= new MessageHeader1()
                        {
                            Id="198101052382",
                            Subject="Säkert Meddelande - deliverSecure v3_03.1 - Ett meddelande - en mottagare - privat - bilaga PDF",
                            Supportinfo=new SupportInfo1(){Text="suppinfo" },
                            OfficialMatter= new OfficialMatter()
                            {
                                Item= new OfficialMatterExtension()
                                {
                                    Timestamp=DateTime.Now,
                                    MatterStatus=OfficialMatterExtensionMatterStatus.closed,
                                    EventType="Test",
                                    MatterSubject="Test",
                                    Identity= new OfficialMatterExtensionIdentity()
                                    {
                                        EventId="2344",
                                        OfficialMatterId="2344",
                                        PrecedingEventId="234243"
                                    }
                                }
                            },
                            Metadata=new MetaData[]{new MetaData()
                            {
                                Tag="1",
                                Value="3465436"
                            }},
                            Language="svSE"


                        },
                        Body= new MessageBody()
                        {
                            ContentType="text/html",
                            Body=UTF8Encoding.UTF8.GetBytes(@"PHA+RXR0IG1lZGRlbGFuZGUgdGlsbCAxOTgxMDEwNTIzODIgaSB0ZXN0IG1lZCBlbiBQREYgc29tIGJpbGFnYS4gRGV0dGEgbWVkZGVsYW5kZSBza2Ega29tbWEgZnJhbTxicj48c3Ryb25nPkFubmFycyDDpHIgZGV0IGZlbCE8L3N0cm9uZz48L3A+")
                        },
                        Attachment= new Attachment[] { new Attachment()
                        {
                            ContentType="application/pdf",
                            Body=UTF8Encoding.UTF8.GetBytes(@"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NTEgMDAwMDAgbg0KMDAwMDAwMDczMiAwMDAwMCBuDQowMDAwMDAwOTAxIDAwMDAwIG4NCjAwMDAwMDExNDEgMDAwMDAgbg0KMDAwMDAwMTE5NCAwMDAwMCBuDQowMDAwMDAxMjQ3IDAwMDAwIG4NCjAwMDAwMDAwMTEgNjU1MzUgZg0KMDAwMDAwMDAxMiA2NTUzNSBmDQowMDAwMDAwMDEzIDY1NTM1IGYNCjAwMDAwMDAwMTQgNjU1MzUgZg0KMDAwMDAwMDAxNSA2NTUzNSBmDQowMDAwMDAwMDE2IDY1NTM1IGYNCjAwMDAwMDAwMTcgNjU1MzUgZg0KMDAwMDAwMDAwMCA2NTUzNSBmDQowMDAwMDAxODczIDAwMDAwIG4NCjAwMDAwMDIzNTQgMDAwMDAgbg0KMDAwMDAxOTQyMCAwMDAwMCBuDQp0cmFpbGVyDQo8PC9TaXplIDIxL1Jvb3QgMSAwIFIvSW5mbyA5IDAgUi9JRFs8M0ZEMUY5ODZCODI5QTY0REI4ODIwRjNERDVDMzE0OTI+PDNGRDFGOTg2QjgyOUE2NERCODgyMEYzREQ1QzMxNDkyPl0gPj4NCnN0YXJ0eHJlZg0KMTk3MDANCiUlRU9GDQp4cmVmDQowIDANCnRyYWlsZXINCjw8L1NpemUgMjEvUm9vdCAxIDAgUi9JbmZvIDkgMCBSL0lEWzwzRkQxRjk4NkI4MjlBNjREQjg4MjBGM0RENUMzMTQ5Mj48M0ZEMUY5ODZCODI5QTY0REI4ODIwRjNERDVDMzE0OTI+XSAvUHJldiAxOTcwMC9YUmVmU3RtIDE5NDIwPj4NCnN0YXJ0eHJlZg0KMjAyNzYNCiUlRU9G"),
                            Checksum="2111066685",
                            Filename="test.pdf"
                        } }
                    } }
                }
            };
        }
        private static SealedDelivery2 SetupSealedDelivery2()
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


        private static ILogger SetupLogging()
        {
            var logSettings = new EventLogSettings() { SourceName = "MM", LogName = "MM" };

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddEventLog(logSettings);
            });
            return loggerFactory.CreateLogger<Program>();
        }
        #endregion
    }
}
