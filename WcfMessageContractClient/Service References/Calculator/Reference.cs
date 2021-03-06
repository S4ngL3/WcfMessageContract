﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfMessageContractClient.Calculator {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Calculator.ICalculatorService")]
    public interface ICalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://test/MyMessage_action", ReplyAction="http://test/MyMessage_action")]
        WcfMessageContractClient.Calculator.MyMessage Calculate(WcfMessageContractClient.Calculator.MyMessage request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://test/MyMessage_action", ReplyAction="http://test/MyMessage_action")]
        System.Threading.Tasks.Task<WcfMessageContractClient.Calculator.MyMessage> CalculateAsync(WcfMessageContractClient.Calculator.MyMessage request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MyMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MyMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Operation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public double N1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public double N2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public double Result;
        
        public MyMessage() {
        }
        
        public MyMessage(string Operation, double N1, double N2, double Result) {
            this.Operation = Operation;
            this.N1 = N1;
            this.N2 = N2;
            this.Result = Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceChannel : WcfMessageContractClient.Calculator.ICalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceClient : System.ServiceModel.ClientBase<WcfMessageContractClient.Calculator.ICalculatorService>, WcfMessageContractClient.Calculator.ICalculatorService {
        
        public CalculatorServiceClient() {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfMessageContractClient.Calculator.MyMessage WcfMessageContractClient.Calculator.ICalculatorService.Calculate(WcfMessageContractClient.Calculator.MyMessage request) {
            return base.Channel.Calculate(request);
        }
        
        public void Calculate(ref string Operation, ref double N1, ref double N2, ref double Result) {
            WcfMessageContractClient.Calculator.MyMessage inValue = new WcfMessageContractClient.Calculator.MyMessage();
            inValue.Operation = Operation;
            inValue.N1 = N1;
            inValue.N2 = N2;
            inValue.Result = Result;
            WcfMessageContractClient.Calculator.MyMessage retVal = ((WcfMessageContractClient.Calculator.ICalculatorService)(this)).Calculate(inValue);
            Operation = retVal.Operation;
            N1 = retVal.N1;
            N2 = retVal.N2;
            Result = retVal.Result;
        }
        
        public System.Threading.Tasks.Task<WcfMessageContractClient.Calculator.MyMessage> CalculateAsync(WcfMessageContractClient.Calculator.MyMessage request) {
            return base.Channel.CalculateAsync(request);
        }
    }
}
