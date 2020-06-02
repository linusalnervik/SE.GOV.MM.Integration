using EnumsNET;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.EventLog;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using SE.GOV.MM.Integration.Infrastructure;
using SE.GOV.MM.Integration.Infrastructure.Services;
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
    public class SigningHandlerTest
    {
        public MessageService messageService { get; set; }

        [SetUp]
        public void Setup()
        {
            var logger = SetupLogging();
            messageService = new MessageService(logger);
        }

    
        [Test]
        public async Task IsValidSignature_SignedDelivery()
        {
            //Arrange
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(TestContext.CurrentContext.TestDirectory + @"\\TestSets\\SignedDeliveryWithSignature.xml");

            //Act
            var isValid = await messageService.IsValidSignature(xmlDocument);

            //Assert
            Assert.IsTrue(isValid);
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
    }
}
