using Autofac;
using Conf.Management.Domain.CommandHandlers;
using Conf.Management.Domain.Commands;
using Conf.Management.Domain.Interfaces.Handlers;
using Conf.Management.Domain.Interfaces.Providers;
using Conf.Management.Domain.Providers;

namespace Conf.Management.Domain
{
    public class DomainAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterProviders(builder);
            RegisterCommandHandlers(builder);
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
    }
}
