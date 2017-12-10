using System;

namespace Conf.Management.Domain.Dao.Models
{
    public class ConferenceDetails
    {
        public Guid Id { get; }
        public string Code { get; }
        public string Name { get; }
        public string Description { get; }
        public string Location { get; }
        public DateTimeOffset StartDate { get; }

        public ConferenceDetails(Guid id, string code, string name, string description, string location, DateTime startDate)
        {
            Id = id;
            Code = code;
            Name = name;
            Description = description;
            Location = location;
            StartDate = startDate;
        }
    }
}
