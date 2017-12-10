using System;
using System.Collections.Generic;
using System.Linq;
using Conf.Management.Domain.Interfaces.Dao;
using Conf.Management.Domain.Dao.Models;
using Conf.Management.Domain.Entities;
using Conf.Management.Domain.Repositories;

namespace Conf.Management.Domain.Dao
{
    internal class ConferenceDao : IConferenceDao
    {
        private static readonly List<Conference> ConferenceStore = FakeConferenceStorage.GetData().ToList();

        public ConferenceDetails GetConferenceDetails(string conferenceCode)
        {
            return ConferenceStore
                .Where(c => c.AccessCode == conferenceCode)
                .Select(ConvertToDaoModel)
                .FirstOrDefault();
        }

        private ConferenceDetails ConvertToDaoModel(Conference conference)
        {
            if (conference == null)
            {
                return null;
            }

            return new ConferenceDetails(
                conference.Id,
                conference.AccessCode,
                conference.Name,
                conference.Description,
                conference.Venue,
                conference.StartDate);
        }
    }
}
