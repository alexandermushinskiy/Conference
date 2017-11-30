using System;
using Conf.Management.Domain.Interfaces;

namespace Conf.Management.Domain.Entities
{
    public class Conference : IAggregateRoot
    {
        public Guid Id { get;}
        public string AccessCode { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime StartDate { get; }
        public DateTime FinishDate { get; }
        public ConferenceOrganizer Organizer { get; }
        public Address Address { get; }

        public Conference(
            Guid id,
            string accessCode,
            string name,
            string description,
            DateTime startDate,
            DateTime finishDate,
            ConferenceOrganizer organizer,
            Address address)
        {
            Id = id;
            AccessCode = accessCode;
            Name = name;
            Description = description;
            StartDate = startDate;
            FinishDate = finishDate;
            Organizer = organizer;
            Address = address;
        }
    }
}
