﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kerry.ITS.JobFactoryServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JobFactoryServiceReference.JobFactorySoap")]
    public interface JobFactorySoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 HelloWorldResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Kerry.ITS.JobFactoryServiceReference.HelloWorldResponse HelloWorld(Kerry.ITS.JobFactoryServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Kerry.ITS.JobFactoryServiceReference.HelloWorldResponse> HelloWorldAsync(Kerry.ITS.JobFactoryServiceReference.HelloWorldRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 GetJobNOResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetJobNO", ReplyAction="*")]
        Kerry.ITS.JobFactoryServiceReference.GetJobNOResponse GetJobNO(Kerry.ITS.JobFactoryServiceReference.GetJobNORequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetJobNO", ReplyAction="*")]
        System.Threading.Tasks.Task<Kerry.ITS.JobFactoryServiceReference.GetJobNOResponse> GetJobNOAsync(Kerry.ITS.JobFactoryServiceReference.GetJobNORequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 shpNO 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCreateDateViaShpNO", ReplyAction="*")]
        Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNOResponse UpdateCreateDateViaShpNO(Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNORequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCreateDateViaShpNO", ReplyAction="*")]
        System.Threading.Tasks.Task<Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNOResponse> UpdateCreateDateViaShpNOAsync(Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNORequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Kerry.ITS.JobFactoryServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Kerry.ITS.JobFactoryServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Kerry.ITS.JobFactoryServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Kerry.ITS.JobFactoryServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetJobNORequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetJobNO", Namespace="http://tempuri.org/", Order=0)]
        public Kerry.ITS.JobFactoryServiceReference.GetJobNORequestBody Body;
        
        public GetJobNORequest() {
        }
        
        public GetJobNORequest(Kerry.ITS.JobFactoryServiceReference.GetJobNORequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetJobNORequestBody {
        
        public GetJobNORequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetJobNOResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetJobNOResponse", Namespace="http://tempuri.org/", Order=0)]
        public Kerry.ITS.JobFactoryServiceReference.GetJobNOResponseBody Body;
        
        public GetJobNOResponse() {
        }
        
        public GetJobNOResponse(Kerry.ITS.JobFactoryServiceReference.GetJobNOResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetJobNOResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetJobNOResult;
        
        public GetJobNOResponseBody() {
        }
        
        public GetJobNOResponseBody(string GetJobNOResult) {
            this.GetJobNOResult = GetJobNOResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateCreateDateViaShpNORequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateCreateDateViaShpNO", Namespace="http://tempuri.org/", Order=0)]
        public Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNORequestBody Body;
        
        public UpdateCreateDateViaShpNORequest() {
        }
        
        public UpdateCreateDateViaShpNORequest(Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNORequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateCreateDateViaShpNORequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string shpNO;
        
        public UpdateCreateDateViaShpNORequestBody() {
        }
        
        public UpdateCreateDateViaShpNORequestBody(string shpNO) {
            this.shpNO = shpNO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateCreateDateViaShpNOResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateCreateDateViaShpNOResponse", Namespace="http://tempuri.org/", Order=0)]
        public Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNOResponseBody Body;
        
        public UpdateCreateDateViaShpNOResponse() {
        }
        
        public UpdateCreateDateViaShpNOResponse(Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNOResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateCreateDateViaShpNOResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int UpdateCreateDateViaShpNOResult;
        
        public UpdateCreateDateViaShpNOResponseBody() {
        }
        
        public UpdateCreateDateViaShpNOResponseBody(int UpdateCreateDateViaShpNOResult) {
            this.UpdateCreateDateViaShpNOResult = UpdateCreateDateViaShpNOResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface JobFactorySoapChannel : Kerry.ITS.JobFactoryServiceReference.JobFactorySoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JobFactorySoapClient : System.ServiceModel.ClientBase<Kerry.ITS.JobFactoryServiceReference.JobFactorySoap>, Kerry.ITS.JobFactoryServiceReference.JobFactorySoap {
        
        public JobFactorySoapClient() {
        }
        
        public JobFactorySoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JobFactorySoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobFactorySoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobFactorySoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Kerry.ITS.JobFactoryServiceReference.HelloWorldResponse Kerry.ITS.JobFactoryServiceReference.JobFactorySoap.HelloWorld(Kerry.ITS.JobFactoryServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Kerry.ITS.JobFactoryServiceReference.HelloWorldRequest inValue = new Kerry.ITS.JobFactoryServiceReference.HelloWorldRequest();
            inValue.Body = new Kerry.ITS.JobFactoryServiceReference.HelloWorldRequestBody();
            Kerry.ITS.JobFactoryServiceReference.HelloWorldResponse retVal = ((Kerry.ITS.JobFactoryServiceReference.JobFactorySoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Kerry.ITS.JobFactoryServiceReference.HelloWorldResponse> Kerry.ITS.JobFactoryServiceReference.JobFactorySoap.HelloWorldAsync(Kerry.ITS.JobFactoryServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Kerry.ITS.JobFactoryServiceReference.HelloWorldResponse> HelloWorldAsync() {
            Kerry.ITS.JobFactoryServiceReference.HelloWorldRequest inValue = new Kerry.ITS.JobFactoryServiceReference.HelloWorldRequest();
            inValue.Body = new Kerry.ITS.JobFactoryServiceReference.HelloWorldRequestBody();
            return ((Kerry.ITS.JobFactoryServiceReference.JobFactorySoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Kerry.ITS.JobFactoryServiceReference.GetJobNOResponse Kerry.ITS.JobFactoryServiceReference.JobFactorySoap.GetJobNO(Kerry.ITS.JobFactoryServiceReference.GetJobNORequest request) {
            return base.Channel.GetJobNO(request);
        }
        
        public string GetJobNO() {
            Kerry.ITS.JobFactoryServiceReference.GetJobNORequest inValue = new Kerry.ITS.JobFactoryServiceReference.GetJobNORequest();
            inValue.Body = new Kerry.ITS.JobFactoryServiceReference.GetJobNORequestBody();
            Kerry.ITS.JobFactoryServiceReference.GetJobNOResponse retVal = ((Kerry.ITS.JobFactoryServiceReference.JobFactorySoap)(this)).GetJobNO(inValue);
            return retVal.Body.GetJobNOResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Kerry.ITS.JobFactoryServiceReference.GetJobNOResponse> Kerry.ITS.JobFactoryServiceReference.JobFactorySoap.GetJobNOAsync(Kerry.ITS.JobFactoryServiceReference.GetJobNORequest request) {
            return base.Channel.GetJobNOAsync(request);
        }
        
        public System.Threading.Tasks.Task<Kerry.ITS.JobFactoryServiceReference.GetJobNOResponse> GetJobNOAsync() {
            Kerry.ITS.JobFactoryServiceReference.GetJobNORequest inValue = new Kerry.ITS.JobFactoryServiceReference.GetJobNORequest();
            inValue.Body = new Kerry.ITS.JobFactoryServiceReference.GetJobNORequestBody();
            return ((Kerry.ITS.JobFactoryServiceReference.JobFactorySoap)(this)).GetJobNOAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNOResponse Kerry.ITS.JobFactoryServiceReference.JobFactorySoap.UpdateCreateDateViaShpNO(Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNORequest request) {
            return base.Channel.UpdateCreateDateViaShpNO(request);
        }
        
        public int UpdateCreateDateViaShpNO(string shpNO) {
            Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNORequest inValue = new Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNORequest();
            inValue.Body = new Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNORequestBody();
            inValue.Body.shpNO = shpNO;
            Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNOResponse retVal = ((Kerry.ITS.JobFactoryServiceReference.JobFactorySoap)(this)).UpdateCreateDateViaShpNO(inValue);
            return retVal.Body.UpdateCreateDateViaShpNOResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNOResponse> Kerry.ITS.JobFactoryServiceReference.JobFactorySoap.UpdateCreateDateViaShpNOAsync(Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNORequest request) {
            return base.Channel.UpdateCreateDateViaShpNOAsync(request);
        }
        
        public System.Threading.Tasks.Task<Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNOResponse> UpdateCreateDateViaShpNOAsync(string shpNO) {
            Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNORequest inValue = new Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNORequest();
            inValue.Body = new Kerry.ITS.JobFactoryServiceReference.UpdateCreateDateViaShpNORequestBody();
            inValue.Body.shpNO = shpNO;
            return ((Kerry.ITS.JobFactoryServiceReference.JobFactorySoap)(this)).UpdateCreateDateViaShpNOAsync(inValue);
        }
    }
}
