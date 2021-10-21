using RestAPIDDD.Domain.Core.Interfaces.Repositories;
using RestAPIDDD.Domain.Core.Interfaces.Services;
using RestAPIDDD.Domain.Entities;

namespace RestAPIDDD.Domain.Services {

    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente {
        private readonly IRepositoryCliente repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente) {
            this.repositoryCliente = repositoryCliente;
        }
    }
}