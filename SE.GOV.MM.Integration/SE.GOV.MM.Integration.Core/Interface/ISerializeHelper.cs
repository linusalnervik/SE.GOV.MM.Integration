using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SE.GOV.MM.Integration.Core.Interface
{
    public interface ISerializeHelper
    {
        SignedDelivery2 DeserializeXmlToSignedDeliveryV3(XmlDocument xmlDocument, string defaultNameSpaceV3);
        SealedDelivery2 DeserializeXmlToSealedDeliveryV3(XmlDocument xmlDocument, string defaultNameSpaceV3);
    }
}
