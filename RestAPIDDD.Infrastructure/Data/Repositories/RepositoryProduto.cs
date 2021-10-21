using RestAPIDDD.Domain.Core.Interfaces.Repositories;
using RestAPIDDD.Domain.Entities;

namespace RestAPIDDD.Infrastructure.Data.Repositories {

    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto {
        private readonly SqlContext sqlContext;

        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext) {
            this.sqlContext = sqlContext;
        }
    }
}