using Conf.Management.Domain.Entities;

namespace Conf.Management.Domain.Interfaces.Services
{
    public interface IConferenceService
    {
        Conference Get(string email, string accessCode);
        Conference Create(Conference conference);
    }
}