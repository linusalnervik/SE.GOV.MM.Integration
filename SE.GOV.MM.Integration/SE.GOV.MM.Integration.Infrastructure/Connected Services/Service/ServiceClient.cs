﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using SE.GOV.MM.Integration.Core.Model;

namespace Service
{
    
    
    /// <remarks/>
 
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Name="ServicePort-v3", Namespace="http://minameddelanden.gov.se/Service", ConfigurationName="ServicePortv3")]
    public interface ServicePortv3
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<notifyResponse> notifyAsync(notifyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<deliverSecureResponse> deliverSecureAsync(deliverSecureRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionInformation), Action="", Name="applicationFault", Namespace="http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<deliverForwardResponse> deliverForwardAsync(deliverForwardRequest request);
    }
    
   
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ServicePortv3Channel : ServicePortv3, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ServicePortv3Client : System.ServiceModel.ClientBase<ServicePortv3>, ServicePortv3
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServicePortv3Client() : 
                base(ServicePortv3Client.GetDefaultBinding(), ServicePortv3Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ServicePort_v3.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicePortv3Client(EndpointConfiguration endpointConfiguration) : 
                base(ServicePortv3Client.GetBindingForEndpoint(endpointConfiguration), ServicePortv3Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicePortv3Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServicePortv3Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicePortv3Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServicePortv3Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicePortv3Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<notifyResponse> ServicePortv3.notifyAsync(notifyRequest request)
        {
            return base.Channel.notifyAsync(request);
        }
        
        public System.Threading.Tasks.Task<notifyResponse> notifyAsync(NotificationDelivery notify)
        {
            notifyRequest inValue = new notifyRequest();
            inValue.notify = notify;
            return ((ServicePortv3)(this)).notifyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<deliverSecureResponse> ServicePortv3.deliverSecureAsync(deliverSecureRequest request)
        {
            return base.Channel.deliverSecureAsync(request);
        }
        
        public System.Threading.Tasks.Task<deliverSecureResponse> deliverSecureAsync(SealedDelivery deliverSecure)
        {
            deliverSecureRequest inValue = new deliverSecureRequest();
            inValue.deliverSecure = deliverSecure;
            return ((ServicePortv3)(this)).deliverSecureAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<deliverForwardResponse> ServicePortv3.deliverForwardAsync(deliverForwardRequest request)
        {
            return base.Channel.deliverForwardAsync(request);
        }
        
        public System.Threading.Tasks.Task<deliverForwardResponse> deliverForwardAsync(ForwardDelivery forwardMessage)
        {
            deliverForwardRequest inValue = new deliverForwardRequest();
            inValue.forwardMessage = forwardMessage;
            return ((ServicePortv3)(this)).deliverForwardAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.ServicePort_v3))
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
            if ((endpointConfiguration == EndpointConfiguration.ServicePort_v3))
            {
                return new System.ServiceModel.EndpointAddress("http://minameddelanden.gov.se/Service/v3");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServicePortv3Client.GetBindingForEndpoint(EndpointConfiguration.ServicePort_v3);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServicePortv3Client.GetEndpointAddress(EndpointConfiguration.ServicePort_v3);
        }
        
        public enum EndpointConfiguration
        {
            
            ServicePort_v3,
        }
    }
}