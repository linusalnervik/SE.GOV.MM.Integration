using System;
using System.Collections.Generic;
using System.Text;

namespace SE.GOV.MM.Integration.Core.Model
{
   
        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient")]
        public partial class AccountPreferences
        {

            private string idField;

            private Sender[] acceptedSendersField;

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
            [System.Xml.Serialization.XmlElementAttribute("AcceptedSenders", Order = 1)]
            public Sender[] AcceptedSenders
            {
                get
                {
                    return this.acceptedSendersField;
                }
                set
                {
                    this.acceptedSendersField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "getAccountPreferences", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class getAccountPreferencesRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 0)]
            public string RecipientId;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 1)]
            public string UserIdentity;

            public getAccountPreferencesRequest()
            {
            }

            public getAccountPreferencesRequest(string RecipientId, string UserIdentity)
            {
                this.RecipientId = RecipientId;
                this.UserIdentity = UserIdentity;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "getAccountPreferencesResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class getAccountPreferencesResponse
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 0)]
            public AccountPreferences @return;

            public getAccountPreferencesResponse()
            {
            }

            public getAccountPreferencesResponse(AccountPreferences @return)
            {
                this.@return = @return;
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2")]
        public partial class PendingAccountPreferences
        {

            private AccountPreferences accountPreferencesField;

            private SignatureAuthorizationResult pendingSignaturesField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
            public AccountPreferences AccountPreferences
            {
                get
                {
                    return this.accountPreferencesField;
                }
                set
                {
                    this.accountPreferencesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
            public SignatureAuthorizationResult PendingSignatures
            {
                get
                {
                    return this.pendingSignaturesField;
                }
                set
                {
                    this.pendingSignaturesField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Authority")]
        public partial class SignatureAuthorizationResult
        {

            private string idField;

            private Person[] signedByField;

            private AuthorizationStatus statusField;

            private bool statusFieldSpecified;

            private System.DateTime timestampField;

            private bool timestampFieldSpecified;

            private string textField;

            private Person[] possibleSignersField;

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
            [System.Xml.Serialization.XmlElementAttribute("SignedBy", Order = 1)]
            public Person[] SignedBy
            {
                get
                {
                    return this.signedByField;
                }
                set
                {
                    this.signedByField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
            public AuthorizationStatus Status
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

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool StatusSpecified
            {
                get
                {
                    return this.statusFieldSpecified;
                }
                set
                {
                    this.statusFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool TimestampSpecified
            {
                get
                {
                    return this.timestampFieldSpecified;
                }
                set
                {
                    this.timestampFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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
            [System.Xml.Serialization.XmlElementAttribute("PossibleSigners", Order = 5)]
            public Person[] PossibleSigners
            {
                get
                {
                    return this.possibleSignersField;
                }
                set
                {
                    this.possibleSignersField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Authority")]
        public partial class Person
        {

            private string idField;

            private string nameField;

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
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Authority")]
        public enum AuthorizationStatus
        {

            /// <remarks/>
            Complete,

            /// <remarks/>
            Incomplete,

            /// <remarks/>
            RulesNotSupported,
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "getPendingAccountPreferences", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class getPendingAccountPreferencesRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public string Id;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 1)]
            public string UserIdentity;

            public getPendingAccountPreferencesRequest()
            {
            }

            public getPendingAccountPreferencesRequest(string Id, string UserIdentity)
            {
                this.Id = Id;
                this.UserIdentity = UserIdentity;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "getPendingAccountPreferencesResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class getPendingAccountPreferencesResponse
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public PendingAccountPreferences @return;

            public getPendingAccountPreferencesResponse()
            {
            }

            public getPendingAccountPreferencesResponse(PendingAccountPreferences @return)
            {
                this.@return = @return;
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2")]
        public partial class OrganizationIdentity
        {

            private string idField;

            private string userIdentityField;

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
            public string UserIdentity
            {
                get
                {
                    return this.userIdentityField;
                }
                set
                {
                    this.userIdentityField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "deletePendingAccountPreferences", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class deletePendingAccountPreferencesRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public OrganizationIdentity organizationIdentity;

            public deletePendingAccountPreferencesRequest()
            {
            }

            public deletePendingAccountPreferencesRequest(OrganizationIdentity organizationIdentity)
            {
                this.organizationIdentity = organizationIdentity;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "deletePendingAccountPreferencesResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class deletePendingAccountPreferencesResponse
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public OrganizationIdentity @return;

            public deletePendingAccountPreferencesResponse()
            {
            }

            public deletePendingAccountPreferencesResponse(OrganizationIdentity @return)
            {
                this.@return = @return;
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Common")]
        public partial class SignatureData
        {

            private byte[] signatureField;

            private string certificateField;

            private string nonceField;

            private string encodingOfSignedTextField;

            public SignatureData()
            {
                this.encodingOfSignedTextField = "UTF-8";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 0)]
            public byte[] Signature
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
            [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
            public string Certificate
            {
                get
                {
                    return this.certificateField;
                }
                set
                {
                    this.certificateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
            public string Nonce
            {
                get
                {
                    return this.nonceField;
                }
                set
                {
                    this.nonceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
            [System.ComponentModel.DefaultValueAttribute("UTF-8")]
            public string EncodingOfSignedText
            {
                get
                {
                    return this.encodingOfSignedTextField;
                }
                set
                {
                    this.encodingOfSignedTextField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "storeAccountPreferences", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class storeAccountPreferencesRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public string Id;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 1)]
            public string UserIdentity;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 2)]
            public AccountPreferences preferences;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 3)]
            public string AgreementText;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 4)]
            [System.Xml.Serialization.XmlElementAttribute("SignatureData")]
            public SignatureData[] SignatureData;

            public storeAccountPreferencesRequest()
            {
            }

            public storeAccountPreferencesRequest(string Id, string UserIdentity, AccountPreferences preferences, string AgreementText, SignatureData[] SignatureData)
            {
                this.Id = Id;
                this.UserIdentity = UserIdentity;
                this.preferences = preferences;
                this.AgreementText = AgreementText;
                this.SignatureData = SignatureData;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "storeAccountPreferencesResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class storeAccountPreferencesResponse
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public SignatureAuthorizationResult @return;

            public storeAccountPreferencesResponse()
            {
            }

            public storeAccountPreferencesResponse(SignatureAuthorizationResult @return)
            {
                this.@return = @return;
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient")]
        public partial class ReachabilityStatus
        {

            private AccountStatus accountStatusField;

            private bool senderAcceptedField;

            private System.DateTime lastSenderAcceptChangeField;

            private bool lastSenderAcceptChangeFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
            public AccountStatus AccountStatus
            {
                get
                {
                    return this.accountStatusField;
                }
                set
                {
                    this.accountStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
            public bool SenderAccepted
            {
                get
                {
                    return this.senderAcceptedField;
                }
                set
                {
                    this.senderAcceptedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
            public System.DateTime LastSenderAcceptChange
            {
                get
                {
                    return this.lastSenderAcceptChangeField;
                }
                set
                {
                    this.lastSenderAcceptChangeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool LastSenderAcceptChangeSpecified
            {
                get
                {
                    return this.lastSenderAcceptChangeFieldSpecified;
                }
                set
                {
                    this.lastSenderAcceptChangeFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient")]
        public partial class AccountStatus
        {

            private string recipientIdField;

            private AccountTypes typeField;

            private bool pendingField;

            private ServiceSupplier serviceSupplierField;

            private System.DateTime lastRegistrationField;

            private bool lastRegistrationFieldSpecified;

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
            public AccountTypes Type
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

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
            public bool Pending
            {
                get
                {
                    return this.pendingField;
                }
                set
                {
                    this.pendingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
            public ServiceSupplier ServiceSupplier
            {
                get
                {
                    return this.serviceSupplierField;
                }
                set
                {
                    this.serviceSupplierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
            public System.DateTime LastRegistration
            {
                get
                {
                    return this.lastRegistrationField;
                }
                set
                {
                    this.lastRegistrationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool LastRegistrationSpecified
            {
                get
                {
                    return this.lastRegistrationFieldSpecified;
                }
                set
                {
                    this.lastRegistrationFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient")]
        public enum AccountTypes
        {

            /// <remarks/>
            Secure,

            /// <remarks/>
            Anonymous,

            /// <remarks/>
            Not,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient")]
        public partial class ServiceSupplier
        {

            private string idField;

            private string nameField;

            private string logoField;

            private string serviceAdressField;

            private string uIAdressField;

            private string internalServiceAdressField;

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
            [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI", Order = 2)]
            public string Logo
            {
                get
                {
                    return this.logoField;
                }
                set
                {
                    this.logoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI", Order = 3)]
            public string ServiceAdress
            {
                get
                {
                    return this.serviceAdressField;
                }
                set
                {
                    this.serviceAdressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI", Order = 4)]
            public string UIAdress
            {
                get
                {
                    return this.uIAdressField;
                }
                set
                {
                    this.uIAdressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI", Order = 5)]
            public string InternalServiceAdress
            {
                get
                {
                    return this.internalServiceAdressField;
                }
                set
                {
                    this.internalServiceAdressField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "isReachable", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class isReachableRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 0)]
            public string senderOrgNr;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 1)]
            [System.Xml.Serialization.XmlElementAttribute("recipientId")]
            public string[] recipientId;

            public isReachableRequest()
            {
            }

            public isReachableRequest(string senderOrgNr, string[] recipientId)
            {
                this.senderOrgNr = senderOrgNr;
                this.recipientId = recipientId;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "isReachableResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class isReachableResponse
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 0)]
            [System.Xml.Serialization.XmlElementAttribute("return")]
            public ReachabilityStatus[] @return;

            public isReachableResponse()
            {
            }

            public isReachableResponse(ReachabilityStatus[] @return)
            {
                this.@return = @return;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "isRegistered", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class isRegisteredRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 0)]
            [System.Xml.Serialization.XmlElementAttribute("recipientId")]
            public string[] recipientId;

            public isRegisteredRequest()
            {
            }

            public isRegisteredRequest(string[] recipientId)
            {
                this.recipientId = recipientId;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "isRegisteredResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class isRegisteredResponse
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 0)]
            [System.Xml.Serialization.XmlElementAttribute("return")]
            public AccountStatus[] @return;

            public isRegisteredResponse()
            {
            }

            public isRegisteredResponse(AccountStatus[] @return)
            {
                this.@return = @return;
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient")]
        public partial class AccountRequest
        {

            private string idField;

            private AccountRequestTypes typeField;

            private string agreementTextField;

            private System.DateTime timestampField;

            private string serviceSupplierField;

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
            public AccountRequestTypes Type
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

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
            public string AgreementText
            {
                get
                {
                    return this.agreementTextField;
                }
                set
                {
                    this.agreementTextField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 3)]
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
            [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
            public string ServiceSupplier
            {
                get
                {
                    return this.serviceSupplierField;
                }
                set
                {
                    this.serviceSupplierField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient")]
        public enum AccountRequestTypes
        {

            /// <remarks/>
            Create,

            /// <remarks/>
            Delete,
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "register", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class registerRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 0)]
            public AccountRequest accountRequest;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 1)]
            public AccountTypes accountType;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 2)]
            [System.Xml.Serialization.XmlElementAttribute("signature")]
            public SignatureData[] signature;

            public registerRequest()
            {
            }

            public registerRequest(AccountRequest accountRequest, AccountTypes accountType, SignatureData[] signature)
            {
                this.accountRequest = accountRequest;
                this.accountType = accountType;
                this.signature = signature;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "registerResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class registerResponse
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 0)]
            public SignatureAuthorizationResult @return;

            public registerResponse()
            {
            }

            public registerResponse(SignatureAuthorizationResult @return)
            {
                this.@return = @return;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "deregister", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class deregisterRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 0)]
            public AccountRequest deregisterAccount;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 1)]
            [System.Xml.Serialization.XmlElementAttribute("signature")]
            public SignatureData[] signature;

            public deregisterRequest()
            {
            }

            public deregisterRequest(AccountRequest deregisterAccount, SignatureData[] signature)
            {
                this.deregisterAccount = deregisterAccount;
                this.signature = signature;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "deregisterResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class deregisterResponse
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 0)]
            public SignatureAuthorizationResult @return;

            public deregisterResponse()
            {
            }

            public deregisterResponse(SignatureAuthorizationResult @return)
            {
                this.@return = @return;
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient")]
        public partial class PendingAccountRequest
        {

            private AccountRequest accountRequestField;

            private SignatureAuthorizationResult signatureStatusField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
            public AccountRequest AccountRequest
            {
                get
                {
                    return this.accountRequestField;
                }
                set
                {
                    this.accountRequestField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
            public SignatureAuthorizationResult SignatureStatus
            {
                get
                {
                    return this.signatureStatusField;
                }
                set
                {
                    this.signatureStatusField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "getPendingAccountRequest", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class getPendingAccountRequestRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 0)]
            [System.Xml.Serialization.XmlElementAttribute("recipientId")]
            public string[] recipientId;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 1)]
            public string userIdentity;

            public getPendingAccountRequestRequest()
            {
            }

            public getPendingAccountRequestRequest(string[] recipientId, string userIdentity)
            {
                this.recipientId = recipientId;
                this.userIdentity = userIdentity;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "getPendingAccountRequestResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class getPendingAccountRequestResponse
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 0)]
            [System.Xml.Serialization.XmlElementAttribute("return")]
            public PendingAccountRequest[] @return;

            public getPendingAccountRequestResponse()
            {
            }

            public getPendingAccountRequestResponse(PendingAccountRequest[] @return)
            {
                this.@return = @return;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "deletePendingAccountRequest", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class deletePendingAccountRequestRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 0)]
            public string recipientId;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v3", Order = 1)]
            public string userIdentity;

            public deletePendingAccountRequestRequest()
            {
            }

            public deletePendingAccountRequestRequest(string recipientId, string userIdentity)
            {
                this.recipientId = recipientId;
                this.userIdentity = userIdentity;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "deletePendingAccountRequestResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v3", IsWrapped = true)]
        public partial class deletePendingAccountRequestResponse
        {

            public deletePendingAccountRequestResponse()
            {
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "changeServiceSupplier", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class changeServiceSupplierRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public string Id;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 1)]
            public string UserIdentity;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 2)]
            public string ServiceSupplier;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 3)]
            public string AgreementText;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 4)]
            [System.Xml.Serialization.XmlElementAttribute("SignatureData")]
            public SignatureData[] SignatureData;

            public changeServiceSupplierRequest()
            {
            }

            public changeServiceSupplierRequest(string Id, string UserIdentity, string ServiceSupplier, string AgreementText, SignatureData[] SignatureData)
            {
                this.Id = Id;
                this.UserIdentity = UserIdentity;
                this.ServiceSupplier = ServiceSupplier;
                this.AgreementText = AgreementText;
                this.SignatureData = SignatureData;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "changeServiceSupplierResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class changeServiceSupplierResponse
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public SignatureAuthorizationResult signatureAuthorizationResult;

            public changeServiceSupplierResponse()
            {
            }

            public changeServiceSupplierResponse(SignatureAuthorizationResult signatureAuthorizationResult)
            {
                this.signatureAuthorizationResult = signatureAuthorizationResult;
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2")]
        public partial class PendingChangeServiceSupplier
        {

            private ServiceSupplier serviceSupplierField;

            private SignatureAuthorizationResult pendingSignaturesField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
            public ServiceSupplier serviceSupplier
            {
                get
                {
                    return this.serviceSupplierField;
                }
                set
                {
                    this.serviceSupplierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
            public SignatureAuthorizationResult pendingSignatures
            {
                get
                {
                    return this.pendingSignaturesField;
                }
                set
                {
                    this.pendingSignaturesField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "getPendingChangeServiceSupplier", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class getPendingChangeServiceSupplierRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public string Id;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 1)]
            public string UserIdentity;

            public getPendingChangeServiceSupplierRequest()
            {
            }

            public getPendingChangeServiceSupplierRequest(string Id, string UserIdentity)
            {
                this.Id = Id;
                this.UserIdentity = UserIdentity;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "getPendingChangeServiceSupplierResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class getPendingChangeServiceSupplierResponse
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public PendingChangeServiceSupplier @return;

            public getPendingChangeServiceSupplierResponse()
            {
            }

            public getPendingChangeServiceSupplierResponse(PendingChangeServiceSupplier @return)
            {
                this.@return = @return;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "deletePendingChangeServiceSupplier", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class deletePendingChangeServiceSupplierRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public OrganizationIdentity organizationIdentity;

            public deletePendingChangeServiceSupplierRequest()
            {
            }

            public deletePendingChangeServiceSupplierRequest(OrganizationIdentity organizationIdentity)
            {
                this.organizationIdentity = organizationIdentity;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "deletePendingChangeServiceSupplierResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class deletePendingChangeServiceSupplierResponse
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public ServiceSupplier serviceSupplier;

            public deletePendingChangeServiceSupplierResponse()
            {
            }

            public deletePendingChangeServiceSupplierResponse(ServiceSupplier serviceSupplier)
            {
                this.serviceSupplier = serviceSupplier;
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2")]
        public partial class AuthorizedAccount
        {

            private bool isAccountAuthorizedSignerField;

            private string userIdentityField;

            private string companyIdField;

            private string companyNameField;

            private string companySignatureRuleTextField;

            private Person[] possibleSignersField;

            private AccountInformation accountInformationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
            public bool isAccountAuthorizedSigner
            {
                get
                {
                    return this.isAccountAuthorizedSignerField;
                }
                set
                {
                    this.isAccountAuthorizedSignerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
            public string UserIdentity
            {
                get
                {
                    return this.userIdentityField;
                }
                set
                {
                    this.userIdentityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
            public string CompanyId
            {
                get
                {
                    return this.companyIdField;
                }
                set
                {
                    this.companyIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
            public string CompanyName
            {
                get
                {
                    return this.companyNameField;
                }
                set
                {
                    this.companyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
            public string CompanySignatureRuleText
            {
                get
                {
                    return this.companySignatureRuleTextField;
                }
                set
                {
                    this.companySignatureRuleTextField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("PossibleSigners", Order = 5)]
            public Person[] PossibleSigners
            {
                get
                {
                    return this.possibleSignersField;
                }
                set
                {
                    this.possibleSignersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
            public AccountInformation AccountInformation
            {
                get
                {
                    return this.accountInformationField;
                }
                set
                {
                    this.accountInformationField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2")]
        public partial class AccountInformation
        {

            private AccountStatus1 accountStatusField;

            private Person[] signedByField;

            private AuthorizationStatus signatureStatusField;

            private string serviceSupplierField;

            private string agreementTextField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
            public AccountStatus1 AccountStatus
            {
                get
                {
                    return this.accountStatusField;
                }
                set
                {
                    this.accountStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SignedBy", Order = 1)]
            public Person[] SignedBy
            {
                get
                {
                    return this.signedByField;
                }
                set
                {
                    this.signedByField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
            public AuthorizationStatus SignatureStatus
            {
                get
                {
                    return this.signatureStatusField;
                }
                set
                {
                    this.signatureStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
            public string serviceSupplier
            {
                get
                {
                    return this.serviceSupplierField;
                }
                set
                {
                    this.serviceSupplierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
            public string AgreementText
            {
                get
                {
                    return this.agreementTextField;
                }
                set
                {
                    this.agreementTextField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AccountStatus", Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2")]
        public enum AccountStatus1
        {

            /// <remarks/>
            Active,

            /// <remarks/>
            Pending,
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "isAuthorizedSigner", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class isAuthorizedSignerRequest
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public string CompanyId;

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 1)]
            public string UserIdentity;

            public isAuthorizedSignerRequest()
            {
            }

            public isAuthorizedSignerRequest(string CompanyId, string UserIdentity)
            {
                this.CompanyId = CompanyId;
                this.UserIdentity = UserIdentity;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ServiceModel.MessageContractAttribute(WrapperName = "isAuthorizedSignerResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Recipient/v2", IsWrapped = true)]
        public partial class isAuthorizedSignerResponse
        {

            [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Recipient/v2", Order = 0)]
            public AuthorizedAccount @return;

            public isAuthorizedSignerResponse()
            {
            }

            public isAuthorizedSignerResponse(AuthorizedAccount @return)
            {
                this.@return = @return;
            }
        }
    }

