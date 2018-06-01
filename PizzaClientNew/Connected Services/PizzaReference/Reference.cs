﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaClientNew.PizzaReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/PizzaDB")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
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
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
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
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/PizzaDB")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PizzaClientNew.PizzaReference.Customer CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime OrderDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PizzaClientNew.PizzaReference.OrderEntry[] OrderEntrySetField;
        
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
        public PizzaClientNew.PizzaReference.Customer Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime OrderDate {
            get {
                return this.OrderDateField;
            }
            set {
                if ((this.OrderDateField.Equals(value) != true)) {
                    this.OrderDateField = value;
                    this.RaisePropertyChanged("OrderDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PizzaClientNew.PizzaReference.OrderEntry[] OrderEntrySet {
            get {
                return this.OrderEntrySetField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderEntrySetField, value) != true)) {
                    this.OrderEntrySetField = value;
                    this.RaisePropertyChanged("OrderEntrySet");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/PizzaDB")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MoneyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PizzaClientNew.PizzaReference.Order[] OrderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Money {
            get {
                return this.MoneyField;
            }
            set {
                if ((this.MoneyField.Equals(value) != true)) {
                    this.MoneyField = value;
                    this.RaisePropertyChanged("Money");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PizzaClientNew.PizzaReference.Order[] Order {
            get {
                return this.OrderField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderField, value) != true)) {
                    this.OrderField = value;
                    this.RaisePropertyChanged("Order");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderEntry", Namespace="http://schemas.datacontract.org/2004/07/PizzaDB")]
    [System.SerializableAttribute()]
    public partial class OrderEntry : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PizzaClientNew.PizzaReference.Order OrderSetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PizzaClientNew.PizzaReference.Product ProductSetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Product_IdField;
        
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
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderId {
            get {
                return this.OrderIdField;
            }
            set {
                if ((this.OrderIdField.Equals(value) != true)) {
                    this.OrderIdField = value;
                    this.RaisePropertyChanged("OrderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PizzaClientNew.PizzaReference.Order OrderSet {
            get {
                return this.OrderSetField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderSetField, value) != true)) {
                    this.OrderSetField = value;
                    this.RaisePropertyChanged("OrderSet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PizzaClientNew.PizzaReference.Product ProductSet {
            get {
                return this.ProductSetField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductSetField, value) != true)) {
                    this.ProductSetField = value;
                    this.RaisePropertyChanged("ProductSet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Product_Id {
            get {
                return this.Product_IdField;
            }
            set {
                if ((this.Product_IdField.Equals(value) != true)) {
                    this.Product_IdField = value;
                    this.RaisePropertyChanged("Product_Id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PizzaReference.IPizzaService")]
    public interface IPizzaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/Register", ReplyAction="http://tempuri.org/IPizzaService/RegisterResponse")]
        string Register(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/Register", ReplyAction="http://tempuri.org/IPizzaService/RegisterResponse")]
        System.Threading.Tasks.Task<string> RegisterAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/Login", ReplyAction="http://tempuri.org/IPizzaService/LoginResponse")]
        bool Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/Login", ReplyAction="http://tempuri.org/IPizzaService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/ProductList", ReplyAction="http://tempuri.org/IPizzaService/ProductListResponse")]
        PizzaClientNew.PizzaReference.Product[] ProductList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/ProductList", ReplyAction="http://tempuri.org/IPizzaService/ProductListResponse")]
        System.Threading.Tasks.Task<PizzaClientNew.PizzaReference.Product[]> ProductListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/GetUserId", ReplyAction="http://tempuri.org/IPizzaService/GetUserIdResponse")]
        int GetUserId(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/GetUserId", ReplyAction="http://tempuri.org/IPizzaService/GetUserIdResponse")]
        System.Threading.Tasks.Task<int> GetUserIdAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/NewOrder", ReplyAction="http://tempuri.org/IPizzaService/NewOrderResponse")]
        PizzaClientNew.PizzaReference.Order NewOrder(int custid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/NewOrder", ReplyAction="http://tempuri.org/IPizzaService/NewOrderResponse")]
        System.Threading.Tasks.Task<PizzaClientNew.PizzaReference.Order> NewOrderAsync(int custid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/GetCustomerById", ReplyAction="http://tempuri.org/IPizzaService/GetCustomerByIdResponse")]
        PizzaClientNew.PizzaReference.Customer GetCustomerById(int custid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/GetCustomerById", ReplyAction="http://tempuri.org/IPizzaService/GetCustomerByIdResponse")]
        System.Threading.Tasks.Task<PizzaClientNew.PizzaReference.Customer> GetCustomerByIdAsync(int custid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/Buy", ReplyAction="http://tempuri.org/IPizzaService/BuyResponse")]
        PizzaClientNew.PizzaReference.OrderEntry Buy(int orderid, int productid, int custid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/Buy", ReplyAction="http://tempuri.org/IPizzaService/BuyResponse")]
        System.Threading.Tasks.Task<PizzaClientNew.PizzaReference.OrderEntry> BuyAsync(int orderid, int productid, int custid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/GetProductById", ReplyAction="http://tempuri.org/IPizzaService/GetProductByIdResponse")]
        PizzaClientNew.PizzaReference.Product GetProductById(int productid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/GetProductById", ReplyAction="http://tempuri.org/IPizzaService/GetProductByIdResponse")]
        System.Threading.Tasks.Task<PizzaClientNew.PizzaReference.Product> GetProductByIdAsync(int productid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPizzaServiceChannel : PizzaClientNew.PizzaReference.IPizzaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PizzaServiceClient : System.ServiceModel.ClientBase<PizzaClientNew.PizzaReference.IPizzaService>, PizzaClientNew.PizzaReference.IPizzaService {
        
        public PizzaServiceClient() {
        }
        
        public PizzaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PizzaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Register(string username) {
            return base.Channel.Register(username);
        }
        
        public System.Threading.Tasks.Task<string> RegisterAsync(string username) {
            return base.Channel.RegisterAsync(username);
        }
        
        public bool Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public PizzaClientNew.PizzaReference.Product[] ProductList() {
            return base.Channel.ProductList();
        }
        
        public System.Threading.Tasks.Task<PizzaClientNew.PizzaReference.Product[]> ProductListAsync() {
            return base.Channel.ProductListAsync();
        }
        
        public int GetUserId(string username) {
            return base.Channel.GetUserId(username);
        }
        
        public System.Threading.Tasks.Task<int> GetUserIdAsync(string username) {
            return base.Channel.GetUserIdAsync(username);
        }
        
        public PizzaClientNew.PizzaReference.Order NewOrder(int custid) {
            return base.Channel.NewOrder(custid);
        }
        
        public System.Threading.Tasks.Task<PizzaClientNew.PizzaReference.Order> NewOrderAsync(int custid) {
            return base.Channel.NewOrderAsync(custid);
        }
        
        public PizzaClientNew.PizzaReference.Customer GetCustomerById(int custid) {
            return base.Channel.GetCustomerById(custid);
        }
        
        public System.Threading.Tasks.Task<PizzaClientNew.PizzaReference.Customer> GetCustomerByIdAsync(int custid) {
            return base.Channel.GetCustomerByIdAsync(custid);
        }
        
        public PizzaClientNew.PizzaReference.OrderEntry Buy(int orderid, int productid, int custid) {
            return base.Channel.Buy(orderid, productid, custid);
        }
        
        public System.Threading.Tasks.Task<PizzaClientNew.PizzaReference.OrderEntry> BuyAsync(int orderid, int productid, int custid) {
            return base.Channel.BuyAsync(orderid, productid, custid);
        }
        
        public PizzaClientNew.PizzaReference.Product GetProductById(int productid) {
            return base.Channel.GetProductById(productid);
        }
        
        public System.Threading.Tasks.Task<PizzaClientNew.PizzaReference.Product> GetProductByIdAsync(int productid) {
            return base.Channel.GetProductByIdAsync(productid);
        }
    }
}
