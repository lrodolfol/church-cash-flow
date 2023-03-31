using Autofac;

namespace Registration.Infrastructure.IOC;
public class ModuleIOC : Module
{
    protected void Loader(ContainerBuilder builder)
    {
        ConfigureIOC.Load(builder);
    }
}