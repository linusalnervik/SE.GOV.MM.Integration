﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SE.GOV.MM.Integration.Core.Model;

namespace Recipient
{
  
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Name="RecipientPort-v3", Namespace="http://minameddelanden.gov.se/Recipient", ConfigurationName="RecipientPortv3")]
    public interface RecipientPortv3
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<getAccountPreferencesResponse> getAccountPreferencesAsync(getAccountPreferencesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<getPendingAccountPreferencesResponse> getPendingAccountPreferencesAsync(getPendingAccountPreferencesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<deletePendingAccountPreferencesResponse> deletePendingAccountPreferencesAsync(deletePendingAccountPreferencesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<storeAccountPreferencesResponse> storeAccountPreferencesAsync(storeAccountPreferencesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<isReachableResponse> isReachableAsync(isReachableRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<isRegisteredResponse> isRegisteredAsync(isRegisteredRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<registerResponse> registerAsync(registerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<deregisterResponse> deregisterAsync(deregisterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<getPendingAccountRequestResponse> getPendingAccountRequestAsync(getPendingAccountRequestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<deletePendingAccountRequestResponse> deletePendingAccountRequestAsync(deletePendingAccountRequestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<changeServiceSupplierResponse> changeServiceSupplierAsync(changeServiceSupplierRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<getPendingChangeServiceSupplierResponse> getPendingChangeServiceSupplierAsync(getPendingChangeServiceSupplierRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<deletePendingChangeServiceSupplierResponse> deletePendingChangeServiceSupplierAsync(deletePendingChangeServiceSupplierRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<isAuthorizedSignerResponse> isAuthorizedSignerAsync(isAuthorizedSignerRequest request);
    }
    
   


    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface RecipientPortv3Channel : RecipientPortv3, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class RecipientPortv3Client : System.ServiceModel.ClientBase<RecipientPortv3>, RecipientPortv3
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public RecipientPortv3Client() : 
                base(RecipientPortv3Client.GetDefaultBinding(), RecipientPortv3Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.RecipientPort_v3.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RecipientPortv3Client(EndpointConfiguration endpointConfiguration) : 
                base(RecipientPortv3Client.GetBindingForEndpoint(endpointConfiguration), RecipientPortv3Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RecipientPortv3Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(RecipientPortv3Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RecipientPortv3Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(RecipientPortv3Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RecipientPortv3Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getAccountPreferencesResponse> RecipientPortv3.getAccountPreferencesAsync(getAccountPreferencesRequest request)
        {
            return base.Channel.getAccountPreferencesAsync(request);
        }
        
        public System.Threading.Tasks.Task<getAccountPreferencesResponse> getAccountPreferencesAsync(string RecipientId, string UserIdentity)
        {
            getAccountPreferencesRequest inValue = new getAccountPreferencesRequest();
            inValue.RecipientId = RecipientId;
            inValue.UserIdentity = UserIdentity;
            return ((RecipientPortv3)(this)).getAccountPreferencesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getPendingAccountPreferencesResponse> RecipientPortv3.getPendingAccountPreferencesAsync(getPendingAccountPreferencesRequest request)
        {
            return base.Channel.getPendingAccountPreferencesAsync(request);
        }
        
        public System.Threading.Tasks.Task<getPendingAccountPreferencesResponse> getPendingAccountPreferencesAsync(string Id, string UserIdentity)
        {
            getPendingAccountPreferencesRequest inValue = new getPendingAccountPreferencesRequest();
            inValue.Id = Id;
            inValue.UserIdentity = UserIdentity;
            return ((RecipientPortv3)(this)).getPendingAccountPreferencesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<deletePendingAccountPreferencesResponse> RecipientPortv3.deletePendingAccountPreferencesAsync(deletePendingAccountPreferencesRequest request)
        {
            return base.Channel.deletePendingAccountPreferencesAsync(request);
        }
        
        public System.Threading.Tasks.Task<deletePendingAccountPreferencesResponse> deletePendingAccountPreferencesAsync(OrganizationIdentity organizationIdentity)
        {
            deletePendingAccountPreferencesRequest inValue = new deletePendingAccountPreferencesRequest();
            inValue.organizationIdentity = organizationIdentity;
            return ((RecipientPortv3)(this)).deletePendingAccountPreferencesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<storeAccountPreferencesResponse> RecipientPortv3.storeAccountPreferencesAsync(storeAccountPreferencesRequest request)
        {
            return base.Channel.storeAccountPreferencesAsync(request);
        }
        
        public System.Threading.Tasks.Task<storeAccountPreferencesResponse> storeAccountPreferencesAsync(string Id, string UserIdentity, AccountPreferences preferences, string AgreementText, SignatureData[] SignatureData)
        {
            storeAccountPreferencesRequest inValue = new storeAccountPreferencesRequest();
            inValue.Id = Id;
            inValue.UserIdentity = UserIdentity;
            inValue.preferences = preferences;
            inValue.AgreementText = AgreementText;
            inValue.SignatureData = SignatureData;
            return ((RecipientPortv3)(this)).storeAccountPreferencesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<isReachableResponse> RecipientPortv3.isReachableAsync(isReachableRequest request)
        {
            return base.Channel.isReachableAsync(request);
        }
        
        public System.Threading.Tasks.Task<isReachableResponse> isReachableAsync(string senderOrgNr, string[] recipientId)
        {
            isReachableRequest inValue = new isReachableRequest();
            inValue.senderOrgNr = senderOrgNr;
            inValue.recipientId = recipientId;
            return ((RecipientPortv3)(this)).isReachableAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<isRegisteredResponse> RecipientPortv3.isRegisteredAsync(isRegisteredRequest request)
        {
            return base.Channel.isRegisteredAsync(request);
        }
        
        public System.Threading.Tasks.Task<isRegisteredResponse> isRegisteredAsync(string[] recipientId)
        {
            isRegisteredRequest inValue = new isRegisteredRequest();
            inValue.recipientId = recipientId;
            return ((RecipientPortv3)(this)).isRegisteredAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<registerResponse> RecipientPortv3.registerAsync(registerRequest request)
        {
            return base.Channel.registerAsync(request);
        }
        
        public System.Threading.Tasks.Task<registerResponse> registerAsync(AccountRequest accountRequest, AccountTypes accountType, SignatureData[] signature)
        {
            registerRequest inValue = new registerRequest();
            inValue.accountRequest = accountRequest;
            inValue.accountType = accountType;
            inValue.signature = signature;
            return ((RecipientPortv3)(this)).registerAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<deregisterResponse> RecipientPortv3.deregisterAsync(deregisterRequest request)
        {
            return base.Channel.deregisterAsync(request);
        }
        
        public System.Threading.Tasks.Task<deregisterResponse> deregisterAsync(AccountRequest deregisterAccount, SignatureData[] signature)
        {
            deregisterRequest inValue = new deregisterRequest();
            inValue.deregisterAccount = deregisterAccount;
            inValue.signature = signature;
            return ((RecipientPortv3)(this)).deregisterAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getPendingAccountRequestResponse> RecipientPortv3.getPendingAccountRequestAsync(getPendingAccountRequestRequest request)
        {
            return base.Channel.getPendingAccountRequestAsync(request);
        }
        
        public System.Threading.Tasks.Task<getPendingAccountRequestResponse> getPendingAccountRequestAsync(string[] recipientId, string userIdentity)
        {
            getPendingAccountRequestRequest inValue = new getPendingAccountRequestRequest();
            inValue.recipientId = recipientId;
            inValue.userIdentity = userIdentity;
            return ((RecipientPortv3)(this)).getPendingAccountRequestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<deletePendingAccountRequestResponse> RecipientPortv3.deletePendingAccountRequestAsync(deletePendingAccountRequestRequest request)
        {
            return base.Channel.deletePendingAccountRequestAsync(request);
        }
        
        public System.Threading.Tasks.Task<deletePendingAccountRequestResponse> deletePendingAccountRequestAsync(string recipientId, string userIdentity)
        {
            deletePendingAccountRequestRequest inValue = new deletePendingAccountRequestRequest();
            inValue.recipientId = recipientId;
            inValue.userIdentity = userIdentity;
            return ((RecipientPortv3)(this)).deletePendingAccountRequestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<changeServiceSupplierResponse> RecipientPortv3.changeServiceSupplierAsync(changeServiceSupplierRequest request)
        {
            return base.Channel.changeServiceSupplierAsync(request);
        }
        
        public System.Threading.Tasks.Task<changeServiceSupplierResponse> changeServiceSupplierAsync(string Id, string UserIdentity, string ServiceSupplier, string AgreementText, SignatureData[] SignatureData)
        {
            changeServiceSupplierRequest inValue = new changeServiceSupplierRequest();
            inValue.Id = Id;
            inValue.UserIdentity = UserIdentity;
            inValue.ServiceSupplier = ServiceSupplier;
            inValue.AgreementText = AgreementText;
            inValue.SignatureData = SignatureData;
            return ((RecipientPortv3)(this)).changeServiceSupplierAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getPendingChangeServiceSupplierResponse> RecipientPortv3.getPendingChangeServiceSupplierAsync(getPendingChangeServiceSupplierRequest request)
        {
            return base.Channel.getPendingChangeServiceSupplierAsync(request);
        }
        
        public System.Threading.Tasks.Task<getPendingChangeServiceSupplierResponse> getPendingChangeServiceSupplierAsync(string Id, string UserIdentity)
        {
            getPendingChangeServiceSupplierRequest inValue = new getPendingChangeServiceSupplierRequest();
            inValue.Id = Id;
            inValue.UserIdentity = UserIdentity;
            return ((RecipientPortv3)(this)).getPendingChangeServiceSupplierAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<deletePendingChangeServiceSupplierResponse> RecipientPortv3.deletePendingChangeServiceSupplierAsync(deletePendingChangeServiceSupplierRequest request)
        {
            return base.Channel.deletePendingChangeServiceSupplierAsync(request);
        }
        
        public System.Threading.Tasks.Task<deletePendingChangeServiceSupplierResponse> deletePendingChangeServiceSupplierAsync(OrganizationIdentity organizationIdentity)
        {
            deletePendingChangeServiceSupplierRequest inValue = new deletePendingChangeServiceSupplierRequest();
            inValue.organizationIdentity = organizationIdentity;
            return ((RecipientPortv3)(this)).deletePendingChangeServiceSupplierAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<isAuthorizedSignerResponse> RecipientPortv3.isAuthorizedSignerAsync(isAuthorizedSignerRequest request)
        {
            return base.Channel.isAuthorizedSignerAsync(request);
        }
        
        public System.Threading.Tasks.Task<isAuthorizedSignerResponse> isAuthorizedSignerAsync(string CompanyId, string UserIdentity)
        {
            isAuthorizedSignerRequest inValue = new isAuthorizedSignerRequest();
            inValue.CompanyId = CompanyId;
            inValue.UserIdentity = UserIdentity;
            return ((RecipientPortv3)(this)).isAuthorizedSignerAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.RecipientPort_v3))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.RecipientPort_v3))
            {
                return new System.ServiceModel.EndpointAddress("http://minameddelanden.gov.se/Recipient/v3");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return RecipientPortv3Client.GetBindingForEndpoint(EndpointConfiguration.RecipientPort_v3);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return RecipientPortv3Client.GetEndpointAddress(EndpointConfiguration.RecipientPort_v3);
        }
        
        public enum EndpointConfiguration
        {
            
            RecipientPort_v3,
        }
    }
}
