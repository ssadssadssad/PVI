//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinForm.WcfService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary.Models")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDict", ReplyAction="http://tempuri.org/IService/GetDictResponse")]
        WinForm.WcfService.Person[] GetDict();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDict", ReplyAction="http://tempuri.org/IService/GetDictResponse")]
        System.Threading.Tasks.Task<WinForm.WcfService.Person[]> GetDictAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddDict", ReplyAction="http://tempuri.org/IService/AddDictResponse")]
        void AddDict(WinForm.WcfService.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddDict", ReplyAction="http://tempuri.org/IService/AddDictResponse")]
        System.Threading.Tasks.Task AddDictAsync(WinForm.WcfService.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdDict", ReplyAction="http://tempuri.org/IService/UpdDictResponse")]
        void UpdDict(WinForm.WcfService.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdDict", ReplyAction="http://tempuri.org/IService/UpdDictResponse")]
        System.Threading.Tasks.Task UpdDictAsync(WinForm.WcfService.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DelDict", ReplyAction="http://tempuri.org/IService/DelDictResponse")]
        void DelDict(WinForm.WcfService.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DelDict", ReplyAction="http://tempuri.org/IService/DelDictResponse")]
        System.Threading.Tasks.Task DelDictAsync(WinForm.WcfService.Person person);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WinForm.WcfService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WinForm.WcfService.IService>, WinForm.WcfService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WinForm.WcfService.Person[] GetDict() {
            return base.Channel.GetDict();
        }
        
        public System.Threading.Tasks.Task<WinForm.WcfService.Person[]> GetDictAsync() {
            return base.Channel.GetDictAsync();
        }
        
        public void AddDict(WinForm.WcfService.Person person) {
            base.Channel.AddDict(person);
        }
        
        public System.Threading.Tasks.Task AddDictAsync(WinForm.WcfService.Person person) {
            return base.Channel.AddDictAsync(person);
        }
        
        public void UpdDict(WinForm.WcfService.Person person) {
            base.Channel.UpdDict(person);
        }
        
        public System.Threading.Tasks.Task UpdDictAsync(WinForm.WcfService.Person person) {
            return base.Channel.UpdDictAsync(person);
        }
        
        public void DelDict(WinForm.WcfService.Person person) {
            base.Channel.DelDict(person);
        }
        
        public System.Threading.Tasks.Task DelDictAsync(WinForm.WcfService.Person person) {
            return base.Channel.DelDictAsync(person);
        }
    }
}
