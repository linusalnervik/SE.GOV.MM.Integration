using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SE.GOV.MM.Integration.Core.Interface
{
   public interface ISigningHandler
    {
         bool IsValidSignature(XmlDocument xmlDoc);
    }
}
