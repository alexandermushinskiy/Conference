using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Conf.Management.Domain.Interfaces.Repositories;
using Conf.Management.Domain.Entities;
using Conf.Management.WebApi.Models;
using Conf.Management.Domain.Commands;
using Conf.Management.Domain.Interfaces.Handlers;
using Conf.Management.Domain.Interfaces.Providers;
using Conf.Management.Domain.Interfaces.Dao;
using Conf.Management.Domain.Dao.Models;

namespace Conf.Management.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ConferencesController : Controller
    {
        private readonly ICommandHandler<CreateConferenceCommand> createConferenceCommandHandler;
        private readonly IAccessCodeProvider accessCodeProvider;
        private readonly IConferenceDao conferenceDao;
        private readonly IConferenceRepository conferenceRepository;

        public ConferencesController(
            ICommandHandler<CreateConferenceCommand> createConferenceCommandHandler,
            IAccessCodeProvider accessCodeProvider,
            IConferenceDao conferenceDao,
            IConferenceRepository conferenceRepository)
        {
            this.createConferenceCommandHandler = createConferenceCommandHandler;
            this.accessCodeProvider = accessCodeProvider;
            this.conferenceDao = conferenceDao;

            this.conferenceRepository = conferenceRepository;
        }

        [HttpGet]
        public IEnumerable<Conference> Get()
        {
            return conferenceRepository.GetAll();
        }

        [HttpGet("details")]
        public IActionResult GetConferenceDetails(string conferenceCode)
        {
            ConferenceDetails conferenceDetails = conferenceDao.GetConferenceDetails(conferenceCode);
            if (conferenceDetails == null)
            {
                return NotFound($"Conference with code {conferenceCode} is not found");
            }
            return Ok(conferenceDetails);
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody]CreateRequestModel createRequestModel)
        {
            string conferenceCode = accessCodeProvider.Generate();
            Guid conferenceId = Guid.NewGuid();

            var command = new CreateConferenceCommand
            {
                Id = conferenceId,
                AccessCode = conferenceCode,
                Name = createRequestModel.Name,
                Description = createRequestModel.Description,
                StartDate = createRequestModel.StartDate,
                FinishDate = createRequestModel.FinishDate,
                OwnerName = createRequestModel.OwnerName,
                OwnerEmail = createRequestModel.OwnerEmail,
                Venue = createRequestModel.Venue
            };
            createConferenceCommandHandler.Handle(command);

            return Created($"api/details/{conferenceCode}", conferenceId);
        }
    }
}