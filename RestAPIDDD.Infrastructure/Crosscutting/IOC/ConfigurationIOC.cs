using Autofac;
using RestAPIDDD.Application;
using RestAPIDDD.Application.Interfaces;
using RestAPIDDD.Application.Interfaces.Mapeamento;
using RestAPIDDD.Application.Mapeamento;
using RestAPIDDD.Domain.Core.Interfaces.Repositories;
using RestAPIDDD.Domain.Core.Interfaces.Services;
using RestAPIDDD.Domain.Services;
using RestAPIDDD.Infrastructure.Data.Repositories;

namespace RestAPIDDD.Infrastructure.Crosscutting.IOC {

    public class ConfigurationIOC {

        public static void Load(ContainerBuilder builder) {

            #region IOC

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion IOC
        }
    }
}