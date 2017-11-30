﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Conf.Management.Domain.Entities;
using Conf.Management.Domain.Interfaces.Repositories;

namespace Conf.Management.Domain.Repositories
{
    internal class ConferenceRepository : IConferenceRepository
    {
        private static readonly List<Conference> ConferenceStore = new List<Conference>();

        public ConferenceRepository()
        {   
        }

        public IEnumerable<Conference> Get(Expression<Func<Conference, bool>> predicate)
        {
            return ConferenceStore.Where(predicate.Compile());
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