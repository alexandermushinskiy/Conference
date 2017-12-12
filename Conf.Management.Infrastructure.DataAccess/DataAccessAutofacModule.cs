using Autofac;
using Conf.Management.Domain.Interfaces.Dao;
using Conf.Management.Domain.Interfaces.Repositories;
using Conf.Management.Infrastructure.DataAccess.Dao;
using Conf.Management.Infrastructure.DataAccess.Repositories;

namespace Conf.Management.Infrastructure.DataAccess
{
    public class DataAccessAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterRepositories(builder);
            RegisterDaos(builder);
        }

        private void RegisterRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<ConferenceRepository>().As<IConferenceRepository>();
        }

        private void RegisterDaos(ContainerBuilder builder)
        {
            builder.RegisterType<ConferenceDao>().As<IConferenceDao>();
        }
    }
}
