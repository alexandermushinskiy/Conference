using Conf.Management.Domain.Dao.Models;

namespace Conf.Management.Domain.Interfaces.Dao
{
    public interface IConferenceDao
    {
        ConferenceDetails GetConferenceDetails(string conferenceCode);
    }
}
