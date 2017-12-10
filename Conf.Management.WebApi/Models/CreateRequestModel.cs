using System;

namespace Conf.Management.WebApi.Models
{
    public class CreateRequestModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public string OwnerName { get; set; }

        public string OwnerEmail { get; set; }

        public string Venue { get; set; }
    }
}
