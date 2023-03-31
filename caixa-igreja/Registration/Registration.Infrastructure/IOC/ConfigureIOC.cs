using Autofac;
using AutoMapper;
using Registration.Mapper.Profiles;
using System.Net.NetworkInformation;

namespace Registration.Infrastructure.IOC;
public class ConfigureIOC
{
    public static void Load(ContainerBuilder builder)
    {
        builder.Register(opt => new MapperConfiguration(mpp =>
        {
            mpp.AddProfile(new UsersProfile());
        }));

        builder.Register(opt =>
            opt.Resolve<MapperConfiguration>()
            .CreateMapper()
        )
        .As<IMapper>()
        .InstancePerLifetimeScope();
    }
}