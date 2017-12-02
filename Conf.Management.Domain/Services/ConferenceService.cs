using System;
using System.Linq;
using Conf.Management.Domain.Entities;
using Conf.Management.Domain.Interfaces.Repositories;
using Conf.Management.Domain.Interfaces.Services;

namespace Conf.Management.Domain.Services
{
    internal class ConferenceService : IConferenceService
    {
        private readonly IConferenceRepository conferenceRepository;

        public ConferenceService(IConferenceRepository conferenceRepository)
        {
            this.conferenceRepository = conferenceRepository;
        }

        public Conference Get(string email, string accessCode)
        {
            return conferenceRepository
                .Get(conf => conf.Organizer.Email == email && conf.AccessCode == accessCode)
                .FirstOrDefault();
        }

        public Conference Create(Conference conference)
        {
            throw new NotImplementedException();
        }
    }
}