﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp_Desktop.PersonReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonDTO", Namespace="http://schemas.datacontract.org/2004/07/ServiceApp_Client")]
    [System.SerializableAttribute()]
    public partial class PersonDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonReference.IPerson")]
    public interface IPerson {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPerson/GetPersonList", ReplyAction="http://tempuri.org/IPerson/GetPersonListResponse")]
        WebApp_Desktop.PersonReference.PersonDTO[] GetPersonList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPerson/GetPersonList", ReplyAction="http://tempuri.org/IPerson/GetPersonListResponse")]
        System.Threading.Tasks.Task<WebApp_Desktop.PersonReference.PersonDTO[]> GetPersonListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPerson/CheckPersonName", ReplyAction="http://tempuri.org/IPerson/CheckPersonNameResponse")]
        bool CheckPersonName(string f, string l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPerson/CheckPersonName", ReplyAction="http://tempuri.org/IPerson/CheckPersonNameResponse")]
        System.Threading.Tasks.Task<bool> CheckPersonNameAsync(string f, string l);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonChannel : WebApp_Desktop.PersonReference.IPerson, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonClient : System.ServiceModel.ClientBase<WebApp_Desktop.PersonReference.IPerson>, WebApp_Desktop.PersonReference.IPerson {
        
        public PersonClient() {
        }
        
        public PersonClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApp_Desktop.PersonReference.PersonDTO[] GetPersonList() {
            return base.Channel.GetPersonList();
        }
        
        public System.Threading.Tasks.Task<WebApp_Desktop.PersonReference.PersonDTO[]> GetPersonListAsync() {
            return base.Channel.GetPersonListAsync();
        }
        
        public bool CheckPersonName(string f, string l) {
            return base.Channel.CheckPersonName(f, l);
        }
        
        public System.Threading.Tasks.Task<bool> CheckPersonNameAsync(string f, string l) {
            return base.Channel.CheckPersonNameAsync(f, l);
        }
    }
}