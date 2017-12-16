using System;
using System.Collections.Generic;
using System.Linq;
using Conf.Management.Domain.Entities;
using Conf.Management.Domain.Interfaces.Repositories;
using Conf.Management.Infrastructure.DataAccess.Dummy;

namespace Conf.Management.Infrastructure.DataAccess.Repositories
{
    internal class ConferenceRepository : IConferenceRepository
    {
        private static readonly List<Conference> ConferenceStore = DummyStorage.GetData().ToList();

        public ConferenceRepository()
        {
        }

        public IEnumerable<Conference> GetAll()
        {
            return ConferenceStore;
        }
        
        public Conference GetById(Guid id)
        {
            return ConferenceStore.Find(conf => conf.Id == id);
        }

        public void Create(Conference conference)
        {
            ConferenceStore.Add(conference);
        }

        public void Update(Conference conference)
        {
            int index = ConferenceStore.FindIndex(conf => conf.Id == conference.Id);
            ConferenceStore[index] = conference;
        }

        public void Delete(Conference conference)
        {
            ConferenceStore.Remove(conference);
        }
    }
}