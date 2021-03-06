﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SE.GOV.MM.Integration.Core.Model
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Common/v3")]
    public partial class ExceptionInformation
    {

        private int errorCodeField;

        private string descriptionField;

        private string callIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string CallId
        {
            get
            {
                return this.callIdField;
            }
            set
            {
                this.callIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Notification/v3")]
    public partial class DeliveryStatus
    {

        private bool deliveredFlagField;

        private NotificationTypes[] notifiedByChannelField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public bool DeliveredFlag
        {
            get
            {
                return this.deliveredFlagField;
            }
            set
            {
                this.deliveredFlagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotifiedByChannel", Order = 1)]
        public NotificationTypes[] NotifiedByChannel
        {
            get
            {
                return this.notifiedByChannelField;
            }
            set
            {
                this.notifiedByChannelField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Notification/v3")]
    public enum NotificationTypes
    {

        /// <remarks/>
        SMS,

        /// <remarks/>
        EMail,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Notification/v3")]
    public partial class NotificationStatus
    {

        private string recipientIdField;

        private DeliveryStatus deliveryStatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string RecipientId
        {
            get
            {
                return this.recipientIdField;
            }
            set
            {
                this.recipientIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public DeliveryStatus DeliveryStatus
        {
            get
            {
                return this.deliveryStatusField;
            }
            set
            {
                this.deliveryStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Notification/v3")]
    public partial class NotifyResult
    {

        private string transIdField;

        private NotificationStatus[] statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string TransId
        {
            get
            {
                return this.transIdField;
            }
            set
            {
                this.transIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Status", Order = 1)]
        public NotificationStatus[] Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Notification/v2")]
    public partial class SmsMessage
    {

        private SmsMessageHeader headerField;

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public SmsMessageHeader header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://minameddelanden.gov.se/schema/Notification/v2")]
    public partial class SmsMessageHeader
    {

        private string fromField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string From
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Notification/v2")]
    public partial class EmailMessage
    {

        private EmailMessageHeader headerField;

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public EmailMessageHeader header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://minameddelanden.gov.se/schema/Notification/v2")]
    public partial class EmailMessageHeader
    {

        private string fromField;

        private string subjectField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string From
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message")]
    public partial class MessageBody
    {

        private string contentTypeField;

        private byte[] bodyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ContentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 1)]
        public byte[] Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message")]
    public partial class MetaData
    {

        private string tagField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Tag
        {
            get
            {
                return this.tagField;
            }
            set
            {
                this.tagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/OfficialMatter/v3")]
    public partial class OfficialMatterExtension
    {

        private System.DateTime timestampField;

        private System.Xml.XmlElement[] anyField;

        private OfficialMatterExtensionIdentity identityField;

        private string matterSubjectField;

        private string eventTypeField;

        private OfficialMatterExtensionMatterStatus matterStatusField;

        private bool matterStatusFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 0)]
        public System.DateTime Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 1)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public OfficialMatterExtensionIdentity Identity
        {
            get
            {
                return this.identityField;
            }
            set
            {
                this.identityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string MatterSubject
        {
            get
            {
                return this.matterSubjectField;
            }
            set
            {
                this.matterSubjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string EventType
        {
            get
            {
                return this.eventTypeField;
            }
            set
            {
                this.eventTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public OfficialMatterExtensionMatterStatus MatterStatus
        {
            get
            {
                return this.matterStatusField;
            }
            set
            {
                this.matterStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MatterStatusSpecified
        {
            get
            {
                return this.matterStatusFieldSpecified;
            }
            set
            {
                this.matterStatusFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://minameddelanden.gov.se/schema/OfficialMatter/v3")]
    public partial class OfficialMatterExtensionIdentity
    {

        private string eventIdField;

        private string officialMatterIdField;

        private string precedingEventIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string EventId
        {
            get
            {
                return this.eventIdField;
            }
            set
            {
                this.eventIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string OfficialMatterId
        {
            get
            {
                return this.officialMatterIdField;
            }
            set
            {
                this.officialMatterIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string PrecedingEventId
        {
            get
            {
                return this.precedingEventIdField;
            }
            set
            {
                this.precedingEventIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://minameddelanden.gov.se/schema/OfficialMatter/v3")]
    public enum OfficialMatterExtensionMatterStatus
    {

        /// <remarks/>
        senderinitiative,

        /// <remarks/>
        recipientinitiative,

        /// <remarks/>
        closed,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message/v3")]
    public partial class OfficialMatter
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("OfficialMatterExtension", typeof(OfficialMatterExtension), Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message/v3")]
    public partial class SupportInfo
    {

        private string textField;

        private string uRLField;

        private string phoneNumberField;

        private string emailAdressField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI", Order = 1)]
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string EmailAdress
        {
            get
            {
                return this.emailAdressField;
            }
            set
            {
                this.emailAdressField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message/v3")]
    public partial class MessageHeader
    {

        private string idField;

        private string subjectField;

        private SupportInfo supportinfoField;

        private OfficialMatter officialMatterField;

        private MetaData[] metadataField;

        private string languageField;

        private ReplyOptions replyField;

        private bool replyFieldSpecified;

        private ReceiptOptions receiptRequestField;

        private bool receiptRequestFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public SupportInfo Supportinfo
        {
            get
            {
                return this.supportinfoField;
            }
            set
            {
                this.supportinfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public OfficialMatter OfficialMatter
        {
            get
            {
                return this.officialMatterField;
            }
            set
            {
                this.officialMatterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Metadata", Order = 4)]
        public MetaData[] Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "language", Order = 5)]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public ReplyOptions Reply
        {
            get
            {
                return this.replyField;
            }
            set
            {
                this.replyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReplySpecified
        {
            get
            {
                return this.replyFieldSpecified;
            }
            set
            {
                this.replyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public ReceiptOptions ReceiptRequest
        {
            get
            {
                return this.receiptRequestField;
            }
            set
            {
                this.receiptRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceiptRequestSpecified
        {
            get
            {
                return this.receiptRequestFieldSpecified;
            }
            set
            {
                this.receiptRequestFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Reply")]
    public enum ReplyOptions
    {

        /// <remarks/>
        REQUESTED,

        /// <remarks/>
        ACCEPTED,

        /// <remarks/>
        NOT_ALLOWED,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Receipt")]
    public enum ReceiptOptions
    {

        /// <remarks/>
        NOT,

        /// <remarks/>
        SIMPLE,

        /// <remarks/>
        SIGNED,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Notification/v3")]
    public partial class NotificationMessage
    {

        private MessageHeader headerField;

        private MessageBody bodyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public MessageHeader header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public MessageBody body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Sender")]
    public partial class Sender
    {

        private string idField;

        private string nameField;

        private string attentionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Attention
        {
            get
            {
                return this.attentionField;
            }
            set
            {
                this.attentionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message")]
    public partial class DeliveryHeader
    {

        private Sender senderField;

        private string[] recipientField;

        private string referenceField;

        private string correlationIdField;

        private string attentionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Sender Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Recipient", Order = 1)]
        public string[] Recipient
        {
            get
            {
                return this.recipientField;
            }
            set
            {
                this.recipientField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string CorrelationId
        {
            get
            {
                return this.correlationIdField;
            }
            set
            {
                this.correlationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Attention
        {
            get
            {
                return this.attentionField;
            }
            set
            {
                this.attentionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Notification/v3")]
    public partial class NotificationDelivery
    {

        private DeliveryHeader headerField;

        private NotificationMessage messageField;

        private EmailMessage emailMessageField;

        private SmsMessage smsMessageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public DeliveryHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public NotificationMessage Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public EmailMessage EmailMessage
        {
            get
            {
                return this.emailMessageField;
            }
            set
            {
                this.emailMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public SmsMessage SmsMessage
        {
            get
            {
                return this.smsMessageField;
            }
            set
            {
                this.smsMessageField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "notify", WrapperNamespace = "http://minameddelanden.gov.se/schema/Service/v3", IsWrapped = true)]
    public partial class notifyRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service/v3", Order = 0)]
        public NotificationDelivery notify;

        public notifyRequest()
        {
        }

        public notifyRequest(NotificationDelivery notify)
        {
            this.notify = notify;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "notifyResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Service/v3", IsWrapped = true)]
    public partial class notifyResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service/v3", Order = 0)]
        public NotifyResult @return;

        public notifyResponse()
        {
        }

        public notifyResponse(NotifyResult @return)
        {
            this.@return = @return;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message/v3")]
    public partial class SealedDelivery
    {

        private SignedDelivery signedDeliveryField;

        private Seal sealField;

        private SignatureType signatureField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public SignedDelivery SignedDelivery
        {
            get
            {
                return this.signedDeliveryField;
            }
            set
            {
                this.signedDeliveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public Seal Seal
        {
            get
            {
                return this.sealField;
            }
            set
            {
                this.sealField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", Order = 2)]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message/v3")]
    public partial class SignedDelivery
    {

        private SecureDelivery deliveryField;

        private SignatureType signatureField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public SecureDelivery Delivery
        {
            get
            {
                return this.deliveryField;
            }
            set
            {
                this.deliveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", Order = 1)]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message/v3")]
    public partial class SecureDelivery
    {

        private SecureDeliveryHeader headerField;

        private SecureMessage[] messageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public SecureDeliveryHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Message", Order = 1)]
        public SecureMessage[] Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message/v2")]
    public partial class SecureDeliveryHeader
    {

        private Sender senderField;

        private string recipientField;

        private string referenceField;

        private string correlationIdField;

        private string attentionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Sender Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Recipient
        {
            get
            {
                return this.recipientField;
            }
            set
            {
                this.recipientField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string CorrelationId
        {
            get
            {
                return this.correlationIdField;
            }
            set
            {
                this.correlationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Attention
        {
            get
            {
                return this.attentionField;
            }
            set
            {
                this.attentionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message/v3")]
    public partial class SecureMessage
    {

        private MessageHeader headerField;

        private MessageBody bodyField;

        private Attachment[] attachmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public MessageHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public MessageBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attachment", Order = 2)]
        public Attachment[] Attachment
        {
            get
            {
                return this.attachmentField;
            }
            set
            {
                this.attachmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message")]
    public partial class Attachment
    {

        private string contentTypeField;

        private byte[] bodyField;

        private string checksumField;

        private string filenameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ContentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 1)]
        public byte[] Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Checksum
        {
            get
            {
                return this.checksumField;
            }
            set
            {
                this.checksumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureType
    {

        private SignedInfoType signedInfoField;

        private SignatureValueType signatureValueField;

        private KeyInfoType keyInfoField;

        private ObjectType[] objectField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public SignedInfoType SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public SignatureValueType SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public KeyInfoType KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Object", Order = 3)]
        public ObjectType[] Object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType
    {

        private CanonicalizationMethodType canonicalizationMethodField;

        private SignatureMethodType signatureMethodField;

        private ReferenceType[] referenceField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CanonicalizationMethodType CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public SignatureMethodType SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference", Order = 2)]
        public ReferenceType[] Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class CanonicalizationMethodType
    {

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureMethodType
    {

        private string hMACOutputLengthField;

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 0)]
        public string HMACOutputLength
        {
            get
            {
                return this.hMACOutputLengthField;
            }
            set
            {
                this.hMACOutputLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 1)]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceType
    {

        private TransformType[] transformsField;

        private DigestMethodType digestMethodField;

        private byte[] digestValueField;

        private string idField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public DigestMethodType DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 2)]
        public byte[] DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType
    {

        private object[] itemsField;

        private string[] textField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("XPath", typeof(string), Order = 0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class DigestMethodType
    {

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType
    {

        private string idField;

        private byte[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType
    {

        private object[] itemsField;

        private ItemsChoiceType2[] itemsElementNameField;

        private string[] textField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("KeyName", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("KeyValue", typeof(KeyValueType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("MgmtData", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("PGPData", typeof(PGPDataType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("RetrievalMethod", typeof(RetrievalMethodType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("SPKIData", typeof(SPKIDataType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("X509Data", typeof(X509DataType), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyValueType
    {

        private object itemField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("DSAKeyValue", typeof(DSAKeyValueType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("RSAKeyValue", typeof(RSAKeyValueType), Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class DSAKeyValueType
    {

        private byte[] pField;

        private byte[] qField;

        private byte[] gField;

        private byte[] yField;

        private byte[] jField;

        private byte[] seedField;

        private byte[] pgenCounterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 0)]
        public byte[] P
        {
            get
            {
                return this.pField;
            }
            set
            {
                this.pField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 1)]
        public byte[] Q
        {
            get
            {
                return this.qField;
            }
            set
            {
                this.qField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 2)]
        public byte[] G
        {
            get
            {
                return this.gField;
            }
            set
            {
                this.gField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 3)]
        public byte[] Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 4)]
        public byte[] J
        {
            get
            {
                return this.jField;
            }
            set
            {
                this.jField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 5)]
        public byte[] Seed
        {
            get
            {
                return this.seedField;
            }
            set
            {
                this.seedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 6)]
        public byte[] PgenCounter
        {
            get
            {
                return this.pgenCounterField;
            }
            set
            {
                this.pgenCounterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class RSAKeyValueType
    {

        private byte[] modulusField;

        private byte[] exponentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 0)]
        public byte[] Modulus
        {
            get
            {
                return this.modulusField;
            }
            set
            {
                this.modulusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 1)]
        public byte[] Exponent
        {
            get
            {
                return this.exponentField;
            }
            set
            {
                this.exponentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class PGPDataType
    {

        private object[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyID", typeof(byte[]), DataType = "base64Binary", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyPacket", typeof(byte[]), DataType = "base64Binary", Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,

        /// <remarks/>
        PGPKeyID,

        /// <remarks/>
        PGPKeyPacket,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class RetrievalMethodType
    {

        private TransformType[] transformsField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SPKIDataType
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("SPKISexp", typeof(byte[]), DataType = "base64Binary", Order = 0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("X509CRL", typeof(byte[]), DataType = "base64Binary", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("X509Certificate", typeof(byte[]), DataType = "base64Binary", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("X509IssuerSerial", typeof(X509IssuerSerialType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("X509SKI", typeof(byte[]), DataType = "base64Binary", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("X509SubjectName", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509IssuerSerialType
    {

        private string x509IssuerNameField;

        private string x509SerialNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string X509IssuerName
        {
            get
            {
                return this.x509IssuerNameField;
            }
            set
            {
                this.x509IssuerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 1)]
        public string X509SerialNumber
        {
            get
            {
                return this.x509SerialNumberField;
            }
            set
            {
                this.x509SerialNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,

        /// <remarks/>
        X509CRL,

        /// <remarks/>
        X509Certificate,

        /// <remarks/>
        X509IssuerSerial,

        /// <remarks/>
        X509SKI,

        /// <remarks/>
        X509SubjectName,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,

        /// <remarks/>
        KeyName,

        /// <remarks/>
        KeyValue,

        /// <remarks/>
        MgmtData,

        /// <remarks/>
        PGPData,

        /// <remarks/>
        RetrievalMethod,

        /// <remarks/>
        SPKIData,

        /// <remarks/>
        X509Data,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ObjectType
    {

        private System.Xml.XmlNode[] anyField;

        private string idField;

        private string mimeTypeField;

        private string encodingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message")]
    public partial class Seal
    {

        private System.DateTime receivedTimeField;

        private bool signaturesOKField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 0)]
        public System.DateTime ReceivedTime
        {
            get
            {
                return this.receivedTimeField;
            }
            set
            {
                this.receivedTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public bool SignaturesOK
        {
            get
            {
                return this.signaturesOKField;
            }
            set
            {
                this.signaturesOKField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service")]
    public partial class DeliveryResult
    {

        private string transIdField;

        private DeliveryStatus1[] statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string TransId
        {
            get
            {
                return this.transIdField;
            }
            set
            {
                this.transIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Status", Order = 1)]
        public DeliveryStatus1[] Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DeliveryStatus", Namespace = "http://minameddelanden.gov.se/schema/Service")]
    public partial class DeliveryStatus1
    {

        private string recipientIdField;

        private bool deliveredField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string RecipientId
        {
            get
            {
                return this.recipientIdField;
            }
            set
            {
                this.recipientIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public bool Delivered
        {
            get
            {
                return this.deliveredField;
            }
            set
            {
                this.deliveredField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "deliverSecure", WrapperNamespace = "http://minameddelanden.gov.se/schema/Service/v3", IsWrapped = true)]
    public partial class deliverSecureRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service/v3", Order = 0)]
        public SealedDelivery deliverSecure;

        public deliverSecureRequest()
        {
        }

        public deliverSecureRequest(SealedDelivery deliverSecure)
        {
            this.deliverSecure = deliverSecure;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "deliverSecureResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Service/v3", IsWrapped = true)]
    public partial class deliverSecureResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service/v3", Order = 0)]
        public DeliveryResult @return;

        public deliverSecureResponse()
        {
        }

        public deliverSecureResponse(DeliveryResult @return)
        {
            this.@return = @return;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service/v3")]
    public partial class ForwardDelivery
    {

        private DeliveryHeader headerField;

        private ForwardMessage messageField;

        private SealedDelivery orginalDeliveryField;

        private string messageIdToForwardField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public DeliveryHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ForwardMessage Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public SealedDelivery OrginalDelivery
        {
            get
            {
                return this.orginalDeliveryField;
            }
            set
            {
                this.orginalDeliveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string MessageIdToForward
        {
            get
            {
                return this.messageIdToForwardField;
            }
            set
            {
                this.messageIdToForwardField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Message")]
    public partial class ForwardMessage
    {

        private string subjectField;

        private MessageBody bodyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public MessageBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "deliverForward", WrapperNamespace = "http://minameddelanden.gov.se/schema/Service/v3", IsWrapped = true)]
    public partial class deliverForwardRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service/v3", Order = 0)]
        public ForwardDelivery forwardMessage;

        public deliverForwardRequest()
        {
        }

        public deliverForwardRequest(ForwardDelivery forwardMessage)
        {
            this.forwardMessage = forwardMessage;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "deliverForwardResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Service/v3", IsWrapped = true)]
    public partial class deliverForwardResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service/v3", Order = 0)]
        public DeliveryResult @return;

        public deliverForwardResponse()
        {
        }

        public deliverForwardResponse(DeliveryResult @return)
        {
            this.@return = @return;
        }
    }
}
