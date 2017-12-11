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
            // Repositories
            RegisterRepositories(builder);
            // Providers
            RegisterProviders(builder);
            // Command handlers
            RegisterCommandHandlers(builder);
            // Dao
            RegisterDaos(builder);
        }

        private void RegisterRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<ConferenceRepository>().As<IConferenceRepository>();
        }

        private void RegisterProviders(ContainerBuilder builder)
        {
            builder.RegisterType<AccessCodeProvider>().As<IAccessCodeProvider>();
            builder.RegisterType<GuidProvider>().As<IGuidProvider>();
        }

        private void RegisterCommandHandlers(ContainerBuilder builder)
        {
            builder.RegisterType<ConferenceCommandHandler>().As<ICommandHandler<CreateConferenceCommand>>();
        }

        private void RegisterDaos(ContainerBuilder builder)
        {
            builder.RegisterType<ConferenceDao>().As<IConferenceDao>();
        }
    }
}
