using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SE.GOV.MM.Integration.Core.Model
{
   public class Enums
    {
        public enum DefaultNamespace
        {
            [Description("http://minameddelanden.gov.se/schema/Message/v3")]
            v3,
        }

        public  enum TagName
        {
            [Description("Seal")]
            Seal,
            [Description("Delivery")]
            Delivery,
        }
    }
}
