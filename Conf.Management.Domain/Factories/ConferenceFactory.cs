using System;
using Conf.Management.Domain.Entities;
using Conf.Management.Domain.Interfaces.Providers;

namespace Conf.Management.Domain.Factories
{
    internal class ConferenceFactory
    {
        private readonly IAccessCodeProvider accessCodeProvider;

        public ConferenceFactory(IAccessCodeProvider accessCodeProvider)
        {
            this.accessCodeProvider = accessCodeProvider;
        }

        public Conference Create(string name, string description, DateTime startDate, DateTime finishDate, string ownerName, string ownerEmail)
        {
            Guid conferenceId = Guid.NewGuid();
            string accessCode = accessCodeProvider.Generate();

            return new Conference(
                conferenceId,
                accessCode,
                name,
                description,
                startDate,
                finishDate,
                new ConferenceOrganizer(ownerName, ownerEmail),
                new Address()
            );
        }
    }
}