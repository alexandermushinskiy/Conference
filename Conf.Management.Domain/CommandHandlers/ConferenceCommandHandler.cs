using System;
using Conf.Management.Domain.Commands;
using Conf.Management.Domain.Interfaces.Handlers;
using Conf.Management.Domain.Interfaces.Repositories;
using Conf.Management.Domain.Entities;

namespace Conf.Management.Domain.CommandHandlers
{
    public class ConferenceCommandHandler : ICommandHandler<CreateConferenceCommand>
    {
        private readonly IConferenceRepository conferenceRepository;

        public ConferenceCommandHandler(IConferenceRepository conferenceRepository)
        {
            this.conferenceRepository = conferenceRepository;
        }

        public void Handle(CreateConferenceCommand command)
        {
            Conference conference = new Conference();
            conference.Handle(command);

            conferenceRepository.Create(conference);
        }
    }
}
