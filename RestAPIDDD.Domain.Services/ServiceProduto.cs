using RestAPIDDD.Domain.Core.Interfaces.Repositories;
using RestAPIDDD.Domain.Core.Interfaces.Services;
using RestAPIDDD.Domain.Entities;

namespace RestAPIDDD.Domain.Services {

    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto) {
            this.repositoryProduto = repositoryProduto;
        }
    }
}