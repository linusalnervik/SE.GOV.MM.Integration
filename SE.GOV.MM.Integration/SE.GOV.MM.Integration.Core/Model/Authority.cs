using System;
using System.Collections.Generic;
using System.Text;

namespace SE.GOV.MM.Integration.Core.Model
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Dispatcher")]
    public partial class Dispatcher
    {

        private string idField;

        private string nameField;

        private string[] sendersField;

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
        [System.Xml.Serialization.XmlElementAttribute("Senders", Order = 2)]
        public string[] Senders
        {
            get
            {
                return this.sendersField;
            }
            set
            {
                this.sendersField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://minameddelanden.gov.se/Authority", ConfigurationName = "AuthorityPort")]
    public interface AuthorityPort
    {

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action = "", Name = "getDispatchersFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getDispatchersResponse> getDispatchersAsync(getDispatchersRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action = "", Name = "getUserAccessRightsFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getUserAccessRightsResponse> getUserAccessRightsAsync(getUserAccessRightsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action = "", Name = "getUserAccessRightsNoConcentFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getUserAccessRightsNoConcentResponse> getUserAccessRightsNoConcentAsync(getUserAccessRightsNoConcentRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action = "", Name = "isSenderAcceptedFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<isSenderAcceptedResponse> isSenderAcceptedAsync(isSenderAcceptedRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action = "", Name = "getSendersFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getSendersResponse> getSendersAsync(getSendersRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action = "", Name = "testNewSignerFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<testNewSignerResponse> testNewSignerAsync(testNewSignerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action = "", Name = "verifyAuthorizedSignaturesFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<verifyAuthorizedSignaturesResponse> verifyAuthorizedSignaturesAsync(verifyAuthorizedSignaturesRequest request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getDispatchers", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class getDispatchersRequest
    {

        public getDispatchersRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getDispatchersResponse", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class getDispatchersResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Dispatcher[] @return;

        public getDispatchersResponse()
        {
        }

        public getDispatchersResponse(Dispatcher[] @return)
        {
            this.@return = @return;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Authority")]
    public partial class UserAccessRightsResult
    {

        private UserAccessRights[] rightsField;

        private UserAccessRightsProblem[] problemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rights", Order = 0)]
        public UserAccessRights[] Rights
        {
            get
            {
                return this.rightsField;
            }
            set
            {
                this.rightsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Problems", Order = 1)]
        public UserAccessRightsProblem[] Problems
        {
            get
            {
                return this.problemsField;
            }
            set
            {
                this.problemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Authority")]
    public partial class UserAccessRights
    {

        private string idField;

        private string organizationNameField;

        private string userIdentityField;

        private UserActivities[] grantedAccessField;

        private GrantTypes grantTypeField;

        private string roleField;

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
        public string OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute("GrantedAccess", Order = 3)]
        public UserActivities[] GrantedAccess
        {
            get
            {
                return this.grantedAccessField;
            }
            set
            {
                this.grantedAccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public GrantTypes GrantType
        {
            get
            {
                return this.grantTypeField;
            }
            set
            {
                this.grantTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Authority")]
    public enum UserActivities
    {

        /// <remarks/>
        View,

        /// <remarks/>
        ForwardMessage,

        /// <remarks/>
        InitiateAccountAction,

        /// <remarks/>
        InitiateConsentReadAction,

        /// <remarks/>
        InitiateConsentManageAction,

        /// <remarks/>
        EditSettings,

        /// <remarks/>
        EditSettingsFrom,

        /// <remarks/>
        EditSettingsForward,

        /// <remarks/>
        EditSettingsContact,

        /// <remarks/>
        EditSettingsConsent,

        /// <remarks/>
        EditSettingsAddressbook,

        /// <remarks/>
        EditSettingsInactivate,

        /// <remarks/>
        InitiateConsentAction,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Authority")]
    public enum GrantTypes
    {

        /// <remarks/>
        AuthorizedSignatory,

        /// <remarks/>
        AuthorizedRole,

        /// <remarks/>
        ConsentManage,

        /// <remarks/>
        ConsentRead,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Authority")]
    public partial class UserAccessRightsProblem
    {

        private UserAccessRightsProblemSource sourceField;

        private UserAccessRightsProblemType typeField;

        private string descriptionField;

        private string objectIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public UserAccessRightsProblemSource Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public UserAccessRightsProblemType Type
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string ObjectId
        {
            get
            {
                return this.objectIdField;
            }
            set
            {
                this.objectIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Authority")]
    public enum UserAccessRightsProblemSource
    {

        /// <remarks/>
        Bolagsverket,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Authority")]
    public enum UserAccessRightsProblemType
    {

        /// <remarks/>
        DataMissing,

        /// <remarks/>
        DataUncertain,

        /// <remarks/>
        DataUnexpected,

        /// <remarks/>
        SourceInaccessible,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getUserAccessRights", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class getUserAccessRightsRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;

        public getUserAccessRightsRequest()
        {
        }

        public getUserAccessRightsRequest(string arg0)
        {
            this.arg0 = arg0;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getUserAccessRightsResponse", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class getUserAccessRightsResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UserAccessRightsResult @return;

        public getUserAccessRightsResponse()
        {
        }

        public getUserAccessRightsResponse(UserAccessRightsResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getUserAccessRightsNoConcent", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class getUserAccessRightsNoConcentRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;

        public getUserAccessRightsNoConcentRequest()
        {
        }

        public getUserAccessRightsNoConcentRequest(string arg0)
        {
            this.arg0 = arg0;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getUserAccessRightsNoConcentResponse", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class getUserAccessRightsNoConcentResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UserAccessRightsResult @return;

        public getUserAccessRightsNoConcentResponse()
        {
        }

        public getUserAccessRightsNoConcentResponse(UserAccessRightsResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "isSenderAccepted", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class isSenderAcceptedRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;

        public isSenderAcceptedRequest()
        {
        }

        public isSenderAcceptedRequest(string arg0)
        {
            this.arg0 = arg0;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "isSenderAcceptedResponse", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class isSenderAcceptedResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;

        public isSenderAcceptedResponse()
        {
        }

        public isSenderAcceptedResponse(bool @return)
        {
            this.@return = @return;
        }
    }


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getSenders", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class getSendersRequest
    {

        public getSendersRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getSendersResponse", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class getSendersResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Sender[] @return;

        public getSendersResponse()
        {
        }

        public getSendersResponse(Sender[] @return)
        {
            this.@return = @return;
        }
    }

   
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://minameddelanden.gov.se/schema/Authority")]
    public enum AccountActions
    {

        /// <remarks/>
        Ownership,

        /// <remarks/>
        CancelConsent,
    }

   

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "testNewSigner", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class testNewSignerRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("arg1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Person[] arg1;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg2;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AccountActions arg3;

        public testNewSignerRequest()
        {
        }

        public testNewSignerRequest(string arg0, Person[] arg1, string arg2, AccountActions arg3)
        {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "testNewSignerResponse", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class testNewSignerResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SignatureAuthorizationResult @return;

        public testNewSignerResponse()
        {
        }

        public testNewSignerResponse(SignatureAuthorizationResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "verifyAuthorizedSignatures", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class verifyAuthorizedSignaturesRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("arg1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SignatureData[] arg1;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
        public byte[] arg2;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AccountActions arg3;

        public verifyAuthorizedSignaturesRequest()
        {
        }

        public verifyAuthorizedSignaturesRequest(string arg0, SignatureData[] arg1, byte[] arg2, AccountActions arg3)
        {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "verifyAuthorizedSignaturesResponse", WrapperNamespace = "http://minameddelanden.gov.se/Authority", IsWrapped = true)]
    public partial class verifyAuthorizedSignaturesResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/Authority", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SignatureAuthorizationResult @return;

        public verifyAuthorizedSignaturesResponse()
        {
        }

        public verifyAuthorizedSignaturesResponse(SignatureAuthorizationResult @return)
        {
            this.@return = @return;
        }
    }
}
