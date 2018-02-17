﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileSharing_FTP_Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IDBService")]
    public interface IDBService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/DoWork", ReplyAction="http://tempuri.org/IDBService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/DoWork", ReplyAction="http://tempuri.org/IDBService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/checkAuthentication", ReplyAction="http://tempuri.org/IDBService/checkAuthenticationResponse")]
        bool checkAuthentication(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/checkAuthentication", ReplyAction="http://tempuri.org/IDBService/checkAuthenticationResponse")]
        System.Threading.Tasks.Task<bool> checkAuthenticationAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/addUserToOnlineUsersTable", ReplyAction="http://tempuri.org/IDBService/addUserToOnlineUsersTableResponse")]
        void addUserToOnlineUsersTable(string userName, int port, string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/addUserToOnlineUsersTable", ReplyAction="http://tempuri.org/IDBService/addUserToOnlineUsersTableResponse")]
        System.Threading.Tasks.Task addUserToOnlineUsersTableAsync(string userName, int port, string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/removeUserFromOnlineUsersTable", ReplyAction="http://tempuri.org/IDBService/removeUserFromOnlineUsersTableResponse")]
        void removeUserFromOnlineUsersTable(string userName, int port, string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/removeUserFromOnlineUsersTable", ReplyAction="http://tempuri.org/IDBService/removeUserFromOnlineUsersTableResponse")]
        System.Threading.Tasks.Task removeUserFromOnlineUsersTableAsync(string userName, int port, string ip);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDBServiceChannel : FileSharing_FTP_Client.ServiceReference1.IDBService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBServiceClient : System.ServiceModel.ClientBase<FileSharing_FTP_Client.ServiceReference1.IDBService>, FileSharing_FTP_Client.ServiceReference1.IDBService {
        
        public DBServiceClient() {
        }
        
        public DBServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DBServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public bool checkAuthentication(string userName, string password) {
            return base.Channel.checkAuthentication(userName, password);
        }
        
        public System.Threading.Tasks.Task<bool> checkAuthenticationAsync(string userName, string password) {
            return base.Channel.checkAuthenticationAsync(userName, password);
        }
        
        public void addUserToOnlineUsersTable(string userName, int port, string ip) {
            base.Channel.addUserToOnlineUsersTable(userName, port, ip);
        }
        
        public System.Threading.Tasks.Task addUserToOnlineUsersTableAsync(string userName, int port, string ip) {
            return base.Channel.addUserToOnlineUsersTableAsync(userName, port, ip);
        }
        
        public void removeUserFromOnlineUsersTable(string userName, int port, string ip) {
            base.Channel.removeUserFromOnlineUsersTable(userName, port, ip);
        }
        
        public System.Threading.Tasks.Task removeUserFromOnlineUsersTableAsync(string userName, int port, string ip) {
            return base.Channel.removeUserFromOnlineUsersTableAsync(userName, port, ip);
        }
    }
}
