using Conf.Management.Domain.Entities;
using System.Collections.Generic;

namespace Conf.Management.Domain.Interfaces.Repositories
{
    public interface IConferenceRepository : IRepository<Conference>
    {
        IEnumerable<Conference> GetAll();
    }
}