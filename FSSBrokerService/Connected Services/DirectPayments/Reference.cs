//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service.DirectPayments {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UploadResult", Namespace="http://schemas.datacontract.org/2004/07/AS.FSS.Gateway.ExtService.Model")]
    [System.SerializableAttribute()]
    public partial class UploadResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExtIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegNumField;
        
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
        public string ExtID {
            get {
                return this.ExtIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ExtIDField, value) != true)) {
                    this.ExtIDField = value;
                    this.RaisePropertyChanged("ExtID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RegNum {
            get {
                return this.RegNumField;
            }
            set {
                if ((object.ReferenceEquals(this.RegNumField, value) != true)) {
                    this.RegNumField = value;
                    this.RaisePropertyChanged("RegNum");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GeneralFault", Namespace="http://schemas.datacontract.org/2004/07/AS.FSS.Gateway.ExtService.Model")]
    [System.SerializableAttribute()]
    public partial class GeneralFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
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
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DateFilter", Namespace="http://schemas.datacontract.org/2004/07/AS.FSS.Gateway.DataAccess.Model")]
    public enum DateFilter : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Day = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TwoDays = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Week = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Month = 31,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Year = 365,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TwoYear = 730,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ThreeYear = 1095,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UPLOADS", Namespace="http://schemas.datacontract.org/2004/07/AS.FSS.Gateway.DataAccess.Model")]
    [System.SerializableAttribute()]
    public partial class UPLOADS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] CERT_DATAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> CNT_LN_PROCEEDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> CNT_LN_VALIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CR_DATEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EXT_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] FILE_DATA_SIGNEDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FILE_FILENAMEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] FILE_TICKETField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] FILE_TICKET_ENCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> FSS_ERRORField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] LAST_EXCEPTIONField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> MD_DATEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string STATEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> STATE_IDField;
        
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
        public byte[] CERT_DATA {
            get {
                return this.CERT_DATAField;
            }
            set {
                if ((object.ReferenceEquals(this.CERT_DATAField, value) != true)) {
                    this.CERT_DATAField = value;
                    this.RaisePropertyChanged("CERT_DATA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> CNT_LN_PROCEED {
            get {
                return this.CNT_LN_PROCEEDField;
            }
            set {
                if ((this.CNT_LN_PROCEEDField.Equals(value) != true)) {
                    this.CNT_LN_PROCEEDField = value;
                    this.RaisePropertyChanged("CNT_LN_PROCEED");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> CNT_LN_VALID {
            get {
                return this.CNT_LN_VALIDField;
            }
            set {
                if ((this.CNT_LN_VALIDField.Equals(value) != true)) {
                    this.CNT_LN_VALIDField = value;
                    this.RaisePropertyChanged("CNT_LN_VALID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CR_DATE {
            get {
                return this.CR_DATEField;
            }
            set {
                if ((this.CR_DATEField.Equals(value) != true)) {
                    this.CR_DATEField = value;
                    this.RaisePropertyChanged("CR_DATE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EXT_ID {
            get {
                return this.EXT_IDField;
            }
            set {
                if ((object.ReferenceEquals(this.EXT_IDField, value) != true)) {
                    this.EXT_IDField = value;
                    this.RaisePropertyChanged("EXT_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] FILE_DATA_SIGNED {
            get {
                return this.FILE_DATA_SIGNEDField;
            }
            set {
                if ((object.ReferenceEquals(this.FILE_DATA_SIGNEDField, value) != true)) {
                    this.FILE_DATA_SIGNEDField = value;
                    this.RaisePropertyChanged("FILE_DATA_SIGNED");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FILE_FILENAME {
            get {
                return this.FILE_FILENAMEField;
            }
            set {
                if ((object.ReferenceEquals(this.FILE_FILENAMEField, value) != true)) {
                    this.FILE_FILENAMEField = value;
                    this.RaisePropertyChanged("FILE_FILENAME");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public byte[] FILE_TICKET {
            get {
                return this.FILE_TICKETField;
            }
            set {
                if ((object.ReferenceEquals(this.FILE_TICKETField, value) != true)) {
                    this.FILE_TICKETField = value;
                    this.RaisePropertyChanged("FILE_TICKET");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public byte[] FILE_TICKET_ENC {
            get {
                return this.FILE_TICKET_ENCField;
            }
            set {
                if ((object.ReferenceEquals(this.FILE_TICKET_ENCField, value) != true)) {
                    this.FILE_TICKET_ENCField = value;
                    this.RaisePropertyChanged("FILE_TICKET_ENC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> FSS_ERROR {
            get {
                return this.FSS_ERRORField;
            }
            set {
                if ((this.FSS_ERRORField.Equals(value) != true)) {
                    this.FSS_ERRORField = value;
                    this.RaisePropertyChanged("FSS_ERROR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public byte[] LAST_EXCEPTION {
            get {
                return this.LAST_EXCEPTIONField;
            }
            set {
                if ((object.ReferenceEquals(this.LAST_EXCEPTIONField, value) != true)) {
                    this.LAST_EXCEPTIONField = value;
                    this.RaisePropertyChanged("LAST_EXCEPTION");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> MD_DATE {
            get {
                return this.MD_DATEField;
            }
            set {
                if ((this.MD_DATEField.Equals(value) != true)) {
                    this.MD_DATEField = value;
                    this.RaisePropertyChanged("MD_DATE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string STATE {
            get {
                return this.STATEField;
            }
            set {
                if ((object.ReferenceEquals(this.STATEField, value) != true)) {
                    this.STATEField = value;
                    this.RaisePropertyChanged("STATE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> STATE_ID {
            get {
                return this.STATE_IDField;
            }
            set {
                if ((this.STATE_IDField.Equals(value) != true)) {
                    this.STATE_IDField = value;
                    this.RaisePropertyChanged("STATE_ID");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://asystems.fss", ConfigurationName="DirectPayments.IGatewayService")]
    public interface IGatewayService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://asystems.fss/IGatewayService/SendFile", ReplyAction="http://asystems.fss/IGatewayService/SendFileResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Service.DirectPayments.GeneralFault), Action="http://asystems.fss/IGatewayService/SendFileGeneralFaultFault", Name="GeneralFault", Namespace="http://schemas.datacontract.org/2004/07/AS.FSS.Gateway.ExtService.Model")]
        Service.DirectPayments.UploadResult SendFile(byte[] data, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://asystems.fss/IGatewayService/UploadsGet", ReplyAction="http://asystems.fss/IGatewayService/UploadsGetResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Service.DirectPayments.GeneralFault), Action="http://asystems.fss/IGatewayService/UploadsGetGeneralFaultFault", Name="GeneralFault", Namespace="http://schemas.datacontract.org/2004/07/AS.FSS.Gateway.ExtService.Model")]
        Service.DirectPayments.UPLOADS[] UploadsGet(string regNum, Service.DirectPayments.DateFilter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://asystems.fss/IGatewayService/UploadGetByExtID", ReplyAction="http://asystems.fss/IGatewayService/UploadGetByExtIDResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Service.DirectPayments.GeneralFault), Action="http://asystems.fss/IGatewayService/UploadGetByExtIDGeneralFaultFault", Name="GeneralFault", Namespace="http://schemas.datacontract.org/2004/07/AS.FSS.Gateway.ExtService.Model")]
        Service.DirectPayments.UPLOADS UploadGetByExtID(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://asystems.fss/IGatewayService/GetDocStates", ReplyAction="http://asystems.fss/IGatewayService/GetDocStatesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Service.DirectPayments.GeneralFault), Action="http://asystems.fss/IGatewayService/GetDocStatesGeneralFaultFault", Name="GeneralFault", Namespace="http://schemas.datacontract.org/2004/07/AS.FSS.Gateway.ExtService.Model")]
        byte[] GetDocStates(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGatewayServiceChannel : Service.DirectPayments.IGatewayService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GatewayServiceClient : System.ServiceModel.ClientBase<Service.DirectPayments.IGatewayService>, Service.DirectPayments.IGatewayService {
        
        public GatewayServiceClient() {
        }
        
        public GatewayServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GatewayServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GatewayServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GatewayServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Service.DirectPayments.UploadResult SendFile(byte[] data, string fileName) {
            return base.Channel.SendFile(data, fileName);
        }
        
        public Service.DirectPayments.UPLOADS[] UploadsGet(string regNum, Service.DirectPayments.DateFilter filter) {
            return base.Channel.UploadsGet(regNum, filter);
        }
        
        public Service.DirectPayments.UPLOADS UploadGetByExtID(string id) {
            return base.Channel.UploadGetByExtID(id);
        }
        
        public byte[] GetDocStates(string id) {
            return base.Channel.GetDocStates(id);
        }
    }
}
