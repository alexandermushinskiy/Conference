using System.Collections.Generic;
using Conf.Infrastructure.Extensibility.Repositories;
using Conf.Management.Entities;

namespace Conf.Management.Extensibility.Repositories
{
    public interface IConferenceRepository : IRepository<Conference>
    {
        IEnumerable<Conference> GetAll();
    }
}