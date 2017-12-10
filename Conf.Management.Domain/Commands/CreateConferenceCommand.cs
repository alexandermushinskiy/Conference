using System;
using Conf.Management.Domain.Interfaces.Commands;

namespace Conf.Management.Domain.Commands
{
    public class CreateConferenceCommand : ICommand
    {
        public Guid Id { get; set; }
        public string AccessCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string OwnerName { get; set; }
        public string OwnerEmail { get; set; }
        public string Venue { get; set; }
    }
}
