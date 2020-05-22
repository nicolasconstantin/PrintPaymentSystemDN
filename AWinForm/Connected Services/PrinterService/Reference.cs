﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AWinForm.PrinterService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PrinterService.IPrinter")]
    public interface IPrinter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/ReturnQuotaToQuantity", ReplyAction="http://tempuri.org/IPrinter/ReturnQuotaToQuantityResponse")]
        int ReturnQuotaToQuantity(decimal quota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/ReturnQuotaToQuantity", ReplyAction="http://tempuri.org/IPrinter/ReturnQuotaToQuantityResponse")]
        System.Threading.Tasks.Task<int> ReturnQuotaToQuantityAsync(decimal quota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/GetUserAccount", ReplyAction="http://tempuri.org/IPrinter/GetUserAccountResponse")]
        bool GetUserAccount(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/GetUserAccount", ReplyAction="http://tempuri.org/IPrinter/GetUserAccountResponse")]
        System.Threading.Tasks.Task<bool> GetUserAccountAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/CreateUser", ReplyAction="http://tempuri.org/IPrinter/CreateUserResponse")]
        DTO.AD CreateUser(DTO.AD User);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/CreateUser", ReplyAction="http://tempuri.org/IPrinter/CreateUserResponse")]
        System.Threading.Tasks.Task<DTO.AD> CreateUserAsync(DTO.AD User);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/GetIdByUsername", ReplyAction="http://tempuri.org/IPrinter/GetIdByUsernameResponse")]
        int GetIdByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/GetIdByUsername", ReplyAction="http://tempuri.org/IPrinter/GetIdByUsernameResponse")]
        System.Threading.Tasks.Task<int> GetIdByUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/GetQuotaById", ReplyAction="http://tempuri.org/IPrinter/GetQuotaByIdResponse")]
        decimal GetQuotaById(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/GetQuotaById", ReplyAction="http://tempuri.org/IPrinter/GetQuotaByIdResponse")]
        System.Threading.Tasks.Task<decimal> GetQuotaByIdAsync(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/ModifyQuotaById", ReplyAction="http://tempuri.org/IPrinter/ModifyQuotaByIdResponse")]
        void ModifyQuotaById(int userID, decimal quota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/ModifyQuotaById", ReplyAction="http://tempuri.org/IPrinter/ModifyQuotaByIdResponse")]
        System.Threading.Tasks.Task ModifyQuotaByIdAsync(int userID, decimal quota);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPrinterChannel : AWinForm.PrinterService.IPrinter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PrinterClient : System.ServiceModel.ClientBase<AWinForm.PrinterService.IPrinter>, AWinForm.PrinterService.IPrinter {
        
        public PrinterClient() {
        }
        
        public PrinterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PrinterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrinterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrinterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int ReturnQuotaToQuantity(decimal quota) {
            return base.Channel.ReturnQuotaToQuantity(quota);
        }
        
        public System.Threading.Tasks.Task<int> ReturnQuotaToQuantityAsync(decimal quota) {
            return base.Channel.ReturnQuotaToQuantityAsync(quota);
        }
        
        public bool GetUserAccount(string username, string password) {
            return base.Channel.GetUserAccount(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> GetUserAccountAsync(string username, string password) {
            return base.Channel.GetUserAccountAsync(username, password);
        }
        
        public DTO.AD CreateUser(DTO.AD User) {
            return base.Channel.CreateUser(User);
        }
        
        public System.Threading.Tasks.Task<DTO.AD> CreateUserAsync(DTO.AD User) {
            return base.Channel.CreateUserAsync(User);
        }
        
        public int GetIdByUsername(string username) {
            return base.Channel.GetIdByUsername(username);
        }
        
        public System.Threading.Tasks.Task<int> GetIdByUsernameAsync(string username) {
            return base.Channel.GetIdByUsernameAsync(username);
        }
        
        public decimal GetQuotaById(int userID) {
            return base.Channel.GetQuotaById(userID);
        }
        
        public System.Threading.Tasks.Task<decimal> GetQuotaByIdAsync(int userID) {
            return base.Channel.GetQuotaByIdAsync(userID);
        }
        
        public void ModifyQuotaById(int userID, decimal quota) {
            base.Channel.ModifyQuotaById(userID, quota);
        }
        
        public System.Threading.Tasks.Task ModifyQuotaByIdAsync(int userID, decimal quota) {
            return base.Channel.ModifyQuotaByIdAsync(userID, quota);
        }
    }
}