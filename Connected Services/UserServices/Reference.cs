﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserServices
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WS.DataServices.Model")]
    public partial class User : object
    {
        
        private string EmailField;
        
        private string FirstNameField;
        
        private int IdField;
        
        private string LastNameField;
        
        private string UserNameField;
        
        private string passwordField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName
        {
            get
            {
                return this.UserNameField;
            }
            set
            {
                this.UserNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.agencytravel/user/", ConfigurationName="UserServices.IUserServices")]
    public interface IUserServices
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.agencytravel/user/IUserServices/GetUsers", ReplyAction="http://ws.agencytravel/user/IUserServices/GetUsersResponse")]
        System.Threading.Tasks.Task<UserServices.User[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.agencytravel/user/IUserServices/GetUser", ReplyAction="http://ws.agencytravel/user/IUserServices/GetUserResponse")]
        System.Threading.Tasks.Task<UserServices.User> GetUserAsync(string email, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.agencytravel/user/IUserServices/CreateUser", ReplyAction="http://ws.agencytravel/user/IUserServices/CreateUserResponse")]
        System.Threading.Tasks.Task CreateUserAsync(UserServices.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.agencytravel/user/IUserServices/UpdateUser", ReplyAction="http://ws.agencytravel/user/IUserServices/UpdateUserResponse")]
        System.Threading.Tasks.Task UpdateUserAsync(UserServices.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IUserServicesChannel : UserServices.IUserServices, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class UserServicesClient : System.ServiceModel.ClientBase<UserServices.IUserServices>, UserServices.IUserServices
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UserServicesClient() : 
                base(UserServicesClient.GetDefaultBinding(), UserServicesClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IUserServices.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServicesClient(EndpointConfiguration endpointConfiguration) : 
                base(UserServicesClient.GetBindingForEndpoint(endpointConfiguration), UserServicesClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServicesClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UserServicesClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServicesClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UserServicesClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<UserServices.User[]> GetUsersAsync()
        {
            return base.Channel.GetUsersAsync();
        }
        
        public System.Threading.Tasks.Task<UserServices.User> GetUserAsync(string email, string username)
        {
            return base.Channel.GetUserAsync(email, username);
        }
        
        public System.Threading.Tasks.Task CreateUserAsync(UserServices.User user)
        {
            return base.Channel.CreateUserAsync(user);
        }
        
        public System.Threading.Tasks.Task UpdateUserAsync(UserServices.User user)
        {
            return base.Channel.UpdateUserAsync(user);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUserServices))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUserServices))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:9090/UserServices.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UserServicesClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IUserServices);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UserServicesClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IUserServices);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IUserServices,
        }
    }
}
