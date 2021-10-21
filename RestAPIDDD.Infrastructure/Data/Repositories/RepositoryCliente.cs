using RestAPIDDD.Domain.Core.Interfaces.Repositories;
using RestAPIDDD.Domain.Entities;

namespace RestAPIDDD.Infrastructure.Data.Repositories {

    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext) : base(sqlContext) {
            this.sqlContext = sqlContext;
        }
    }
}