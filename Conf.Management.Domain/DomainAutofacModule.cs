using Autofac;
using Conf.Management.Domain.CommandHandlers;
using Conf.Management.Domain.Commands;
using Conf.Management.Domain.Dao;
using Conf.Management.Domain.Interfaces.Dao;
using Conf.Management.Domain.Interfaces.Handlers;
using Conf.Management.Domain.Interfaces.Providers;
using Conf.Management.Domain.Interfaces.Repositories;
using Conf.Management.Domain.Providers;
using Conf.Management.Domain.Repositories;

namespace Conf.Management.Domain
{
    public class DomainAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConferenceRepository>().As<IConferenceRepository>();
            builder.RegisterType<AccessCodeProvider>().As<IAccessCodeProvider>();

            // Command handlers
            builder.RegisterType<ConferenceCommandHandler>().As<ICommandHandler<CreateConferenceCommand>>();

            // Dao
            builder.RegisterType<ConferenceDao>().As<IConferenceDao>();
        }
    }
}
