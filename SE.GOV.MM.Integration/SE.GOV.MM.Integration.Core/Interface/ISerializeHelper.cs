using SE.GOV.MM.Integration.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SE.GOV.MM.Integration.Core.Interface
{
    public interface ISerializeHelper
    {
        SignedDelivery DeserializeXmlToSignedDeliveryV3(XmlDocument xmlDocument, string defaultNameSpaceV3);
        SealedDelivery DeserializeXmlToSealedDeliveryV3(XmlDocument xmlDocument, string defaultNameSpaceV3);
    }
}
