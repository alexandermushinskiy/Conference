﻿using System;
using Conf.Management.Domain.Interfaces;
using Conf.Management.Domain.Commands;

namespace Conf.Management.Domain.Entities
{
    public class Conference : IAggregateRoot
    {
        public Guid Id { get; private set; }
        public string AccessCode { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime FinishDate { get; private set; }
        public ConferenceOrganizer Organizer { get; private set; }
        public string Venue { get; private set; }

        public Conference()
        {
        }

        public Conference(
            Guid id,
            string accessCode,
            string name,
            string description,
            DateTime startDate,
            DateTime finishDate,
            ConferenceOrganizer organizer,
            string venue)
        {
            Id = id;
            AccessCode = accessCode;
            Name = name;
            Description = description;
            StartDate = startDate;
            FinishDate = finishDate;
            Organizer = organizer;
            Venue = venue;
        }

        public void Handle(CreateConferenceCommand createConferenceCommand)
        {
            Id = createConferenceCommand.Id;
            AccessCode = createConferenceCommand.AccessCode;
            Name = createConferenceCommand.Name;
            Description = createConferenceCommand.Description;
            StartDate = createConferenceCommand.StartDate;
            FinishDate = createConferenceCommand.FinishDate;
            Organizer = new ConferenceOrganizer(createConferenceCommand.OwnerName, createConferenceCommand.OwnerEmail);
            Venue = createConferenceCommand.Venue;
        }
    }
}
