using System;
using System.Collections.Generic;
using System.Text;

namespace SE.GOV.MM.Integration.Infrastructure
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicePortv3Channel : ServicePortv3, System.ServiceModel.IClientChannel
    {
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Name = "ServicePort-v2", Namespace = "http://minameddelanden.gov.se/Service", ConfigurationName = "ServicePortv2")]
    public interface ServicePortv2
    {

        // CODEGEN: Meddelandekontrakt genereras eftersom omslutningsnamnområde (wrapper) (http://minameddelanden.gov.se/schema/Service/v2) i meddelande notifyRequest inte matchar standardvärdet (http://minameddelanden.gov.se/Service)
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(minameddelanden.gov.se.schema.Common.ExceptionInformation), Action = "", Name = "notifyFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        notifyResponse notify(notifyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        System.Threading.Tasks.Task<notifyResponse> notifyAsync(notifyRequest request);

        // CODEGEN: Meddelandekontrakt genereras eftersom omslutningsnamnområde (wrapper) (http://minameddelanden.gov.se/schema/Service/v2) i meddelande deliverSecureRequest inte matchar standardvärdet (http://minameddelanden.gov.se/Service)
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(minameddelanden.gov.se.schema.Common.ExceptionInformation), Action = "", Name = "deliverSecureFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        deliverSecureResponse deliverSecure(deliverSecureRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        System.Threading.Tasks.Task<deliverSecureResponse> deliverSecureAsync(deliverSecureRequest request);

        // CODEGEN: Parameter return kräver ytterligare schemainformation som inte kan registreras i parameterläge. Det specifika attributet är System.Xml.Serialization.XmlElementAttribute.
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(minameddelanden.gov.se.schema.Common.ExceptionInformation), Action = "", Name = "deliverForwardFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        deliverForwardResponse deliverForward(deliverForwardRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        System.Threading.Tasks.Task<deliverForwardResponse> deliverForwardAsync(deliverForwardRequest request);
    }


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePortv3Client : System.ServiceModel.ClientBase<ServicePortv3>, ServicePortv3
    {

        public ServicePortv3Client()
        {
        }

        public ServicePortv3Client(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public ServicePortv3Client(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public ServicePortv3Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public ServicePortv3Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        notifyResponse1 ServicePortv3.notify(notifyRequest1 request)
        {
            return base.Channel.notify(request);
        }

        public NotifyResult1 notify(NotificationDelivery1 notify1)
        {
            notifyRequest1 inValue = new notifyRequest1();
            inValue.notify = notify1;
            notifyResponse1 retVal = ((ServicePortv3)(this)).notify(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<notifyResponse1> ServicePortv3.notifyAsync(notifyRequest1 request)
        {
            return base.Channel.notifyAsync(request);
        }

        public System.Threading.Tasks.Task<notifyResponse1> notifyAsync(NotificationDelivery1 notify)
        {
            notifyRequest1 inValue = new notifyRequest1();
            inValue.notify = notify;
            return ((ServicePortv3)(this)).notifyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        deliverSecureResponse1 ServicePortv3.deliverSecure(deliverSecureRequest1 request)
        {
            return base.Channel.deliverSecure(request);
        }

        public DeliveryResult deliverSecure(SealedDelivery2 deliverSecure1)
        {
            deliverSecureRequest1 inValue = new deliverSecureRequest1();
            inValue.deliverSecure = deliverSecure1;
            deliverSecureResponse1 retVal = ((ServicePortv3)(this)).deliverSecure(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<deliverSecureResponse1> ServicePortv3.deliverSecureAsync(deliverSecureRequest1 request)
        {
            return base.Channel.deliverSecureAsync(request);
        }

        public System.Threading.Tasks.Task<deliverSecureResponse1> deliverSecureAsync(SealedDelivery2 deliverSecure)
        {
            deliverSecureRequest1 inValue = new deliverSecureRequest1();
            inValue.deliverSecure = deliverSecure;
            return ((ServicePortv3)(this)).deliverSecureAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        deliverForwardResponse1 ServicePortv3.deliverForward(deliverForwardRequest1 request)
        {
            return base.Channel.deliverForward(request);
        }

        public DeliveryResult deliverForward(ForwardDelivery1 forwardMessage)
        {
            deliverForwardRequest1 inValue = new deliverForwardRequest1();
            inValue.forwardMessage = forwardMessage;
            deliverForwardResponse1 retVal = ((ServicePortv3)(this)).deliverForward(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<deliverForwardResponse1> ServicePortv3.deliverForwardAsync(deliverForwardRequest1 request)
        {
            return base.Channel.deliverForwardAsync(request);
        }

        public System.Threading.Tasks.Task<deliverForwardResponse1> deliverForwardAsync(ForwardDelivery1 forwardMessage)
        {
            deliverForwardRequest1 inValue = new deliverForwardRequest1();
            inValue.forwardMessage = forwardMessage;
            return ((ServicePortv3)(this)).deliverForwardAsync(inValue);
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Name = "ServicePort-v3", Namespace = "http://minameddelanden.gov.se/Service", ConfigurationName = "ServicePortv3")]
    public interface ServicePortv3
    {

        // CODEGEN: Meddelandekontrakt genereras eftersom omslutningsnamnområde (wrapper) (http://minameddelanden.gov.se/schema/Service/v3) i meddelande notifyRequest inte matchar standardvärdet (http://minameddelanden.gov.se/Service)
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(minameddelanden.gov.se.schema.Common.v3.ExceptionInformation), Action = "", Name = "applicationFault", Namespace = "http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        notifyResponse1 notify(notifyRequest1 request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        System.Threading.Tasks.Task<notifyResponse1> notifyAsync(notifyRequest1 request);

        // CODEGEN: Meddelandekontrakt genereras eftersom omslutningsnamnområde (wrapper) (http://minameddelanden.gov.se/schema/Service/v3) i meddelande deliverSecureRequest inte matchar standardvärdet (http://minameddelanden.gov.se/Service)
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(minameddelanden.gov.se.schema.Common.v3.ExceptionInformation), Action = "", Name = "applicationFault", Namespace = "http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        deliverSecureResponse1 deliverSecure(deliverSecureRequest1 request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        System.Threading.Tasks.Task<deliverSecureResponse1> deliverSecureAsync(deliverSecureRequest1 request);

        // CODEGEN: Meddelandekontrakt genereras eftersom omslutningsnamnområde (wrapper) (http://minameddelanden.gov.se/schema/Service/v3) i meddelande deliverForwardRequest inte matchar standardvärdet (http://minameddelanden.gov.se/Service)
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(minameddelanden.gov.se.schema.Common.v3.ExceptionInformation), Action = "", Name = "applicationFault", Namespace = "http://minameddelanden.gov.se/schema/Common/v3")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        deliverForwardResponse1 deliverForward(deliverForwardRequest1 request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        System.Threading.Tasks.Task<deliverForwardResponse1> deliverForwardAsync(deliverForwardRequest1 request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "notify", WrapperNamespace = "http://minameddelanden.gov.se/schema/Service/v3", IsWrapped = true)]
    public partial class notifyRequest1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service/v3", Order = 0)]
        public NotificationDelivery1 notify;

        public notifyRequest1()
        {
        }

        public notifyRequest1(NotificationDelivery1 notify)
        {
            this.notify = notify;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "notifyResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Service/v3", IsWrapped = true)]
    public partial class notifyResponse1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service/v3", Order = 0)]
        public NotifyResult1 @return;

        public notifyResponse1()
        {
        }

        public notifyResponse1(NotifyResult1 @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "deliverSecure", WrapperNamespace = "http://minameddelanden.gov.se/schema/Service/v3", IsWrapped = true)]
    public partial class deliverSecureRequest1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service/v3", Order = 0)]
        public SealedDelivery2 deliverSecure;

        public deliverSecureRequest1()
        {
        }

        public deliverSecureRequest1(SealedDelivery2 deliverSecure)
        {
            this.deliverSecure = deliverSecure;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "deliverSecureResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Service/v3", IsWrapped = true)]
    public partial class deliverSecureResponse1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service/v3", Order = 0)]
        public DeliveryResult @return;

        public deliverSecureResponse1()
        {
        }

        public deliverSecureResponse1(DeliveryResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "deliverForward", WrapperNamespace = "http://minameddelanden.gov.se/schema/Service/v3", IsWrapped = true)]
    public partial class deliverForwardRequest1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service/v3", Order = 0)]
        public ForwardDelivery1 forwardMessage;

        public deliverForwardRequest1()
        {
        }

        public deliverForwardRequest1(ForwardDelivery1 forwardMessage)
        {
            this.forwardMessage = forwardMessage;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "deliverForwardResponse", WrapperNamespace = "http://minameddelanden.gov.se/schema/Service/v3", IsWrapped = true)]
    public partial class deliverForwardResponse1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://minameddelanden.gov.se/schema/Service/v3", Order = 0)]
        public DeliveryResult @return;

        public deliverForwardResponse1()
        {
        }

        public deliverForwardResponse1(DeliveryResult @return)
        {
            this.@return = @return;
        }
    }


    namespace minameddelanden.gov.se.schema.Common
    {
        using System.Runtime.Serialization;


        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ExceptionInformation", Namespace = "http://minameddelanden.gov.se/schema/Common")]
        public partial class ExceptionInformation : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private int ErrorCodeField;

            private string DescriptionField;

            private string CallIdField;

            public System.Runtime.Serialization.ExtensionDataObject ExtensionData
            {
                get
                {
                    return this.extensionDataField;
                }
                set
                {
                    this.extensionDataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
            public int ErrorCode
            {
                get
                {
                    return this.ErrorCodeField;
                }
                set
                {
                    this.ErrorCodeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, EmitDefaultValue = false, Order = 1)]
            public string Description
            {
                get
                {
                    return this.DescriptionField;
                }
                set
                {
                    this.DescriptionField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, EmitDefaultValue = false, Order = 2)]
            public string CallId
            {
                get
                {
                    return this.CallIdField;
                }
                set
                {
                    this.CallIdField = value;
                }
            }
        }
    }
    namespace minameddelanden.gov.se.schema.Common.v3
    {
        using System.Runtime.Serialization;


        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ExceptionInformation", Namespace = "http://minameddelanden.gov.se/schema/Common/v3")]
        public partial class ExceptionInformation : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private int ErrorCodeField;

            private string DescriptionField;

            private string CallIdField;

            public System.Runtime.Serialization.ExtensionDataObject ExtensionData
            {
                get
                {
                    return this.extensionDataField;
                }
                set
                {
                    this.extensionDataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
            public int ErrorCode
            {
                get
                {
                    return this.ErrorCodeField;
                }
                set
                {
                    this.ErrorCodeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, EmitDefaultValue = false, Order = 1)]
            public string Description
            {
                get
                {
                    return this.DescriptionField;
                }
                set
                {
                    this.DescriptionField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, EmitDefaultValue = false, Order = 2)]
            public string CallId
            {
                get
                {
                    return this.CallIdField;
                }
                set
                {
                    this.CallIdField = value;
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicePortv2Channel : ServicePortv2, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePortv2Client : System.ServiceModel.ClientBase<ServicePortv2>, ServicePortv2
    {

        public ServicePortv2Client()
        {
        }

        public ServicePortv2Client(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public ServicePortv2Client(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public ServicePortv2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public ServicePortv2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        notifyResponse ServicePortv2.notify(notifyRequest request)
        {
            return base.Channel.notify(request);
        }

        public NotifyResult notify(NotificationDelivery notify1)
        {
            notifyRequest inValue = new notifyRequest();
            inValue.notify = notify1;
            notifyResponse retVal = ((ServicePortv2)(this)).notify(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<notifyResponse> ServicePortv2.notifyAsync(notifyRequest request)
        {
            return base.Channel.notifyAsync(request);
        }

        public System.Threading.Tasks.Task<notifyResponse> notifyAsync(NotificationDelivery notify)
        {
            notifyRequest inValue = new notifyRequest();
            inValue.notify = notify;
            return ((ServicePortv2)(this)).notifyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        deliverSecureResponse ServicePortv2.deliverSecure(deliverSecureRequest request)
        {
            return base.Channel.deliverSecure(request);
        }

        public DeliveryResult deliverSecure(SealedDelivery deliverSecure1)
        {
            deliverSecureRequest inValue = new deliverSecureRequest();
            inValue.deliverSecure = deliverSecure1;
            deliverSecureResponse retVal = ((ServicePortv2)(this)).deliverSecure(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<deliverSecureResponse> ServicePortv2.deliverSecureAsync(deliverSecureRequest request)
        {
            return base.Channel.deliverSecureAsync(request);
        }

        public System.Threading.Tasks.Task<deliverSecureResponse> deliverSecureAsync(SealedDelivery deliverSecure)
        {
            deliverSecureRequest inValue = new deliverSecureRequest();
            inValue.deliverSecure = deliverSecure;
            return ((ServicePortv2)(this)).deliverSecureAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        deliverForwardResponse ServicePortv2.deliverForward(deliverForwardRequest request)
        {
            return base.Channel.deliverForward(request);
        }

        public DeliveryResult deliverForward(ForwardDelivery arg0)
        {
            deliverForwardRequest inValue = new deliverForwardRequest();
            inValue.arg0 = arg0;
            deliverForwardResponse retVal = ((ServicePortv2)(this)).deliverForward(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<deliverForwardResponse> ServicePortv2.deliverForwardAsync(deliverForwardRequest request)
        {
            return base.Channel.deliverForwardAsync(request);
        }

        public System.Threading.Tasks.Task<deliverForwardResponse> deliverForwardAsync(ForwardDelivery arg0)
        {
            deliverForwardRequest inValue = new deliverForwardRequest();
            inValue.arg0 = arg0;
            return ((ServicePortv2)(this)).deliverForwardAsync(inValue);
        }
    }
}
