using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SE.GOV.MM.Integration.Core.Interface
{
   public interface ISigningHandler
    {   
            bool IsMessageSigned(XmlDocument xmlDoc);
            bool IsValidSignature(XmlDocument xmlDoc);
            void SignXmlDocument(XmlDocument xmlDoc, string tagName);      
    }
}
