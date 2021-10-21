using Autofac;

namespace RestAPIDDD.Infrastructure.Crosscutting.IOC {

    public class ModuleIOC : Module {

        protected override void Load(ContainerBuilder builder) {
            ConfigurationIOC.Load(builder);
        }
    }
}