# Conference.Management project structure
Test project for DDD practices

## Files structure
#### Project skeleton
The skeleton of the project has the following files structure:
```
├── Conf.Management.Domain
|   ├── CommandHandlers
|   |   └── ConferenceCommandHandler.cs
|   ├── Commands
|   |   └── CreateConferenceCommand.cs
|   ├── Dao
|   |   ├── Models
|   |   |   └── ConferenceDetails.cs
|   |	└── ConferenceDao.cs
|   ├── Entities
|   |   ├── Address.cs
|   |   ├── Conference.cs
|   |   └── ConferenceOrganizer.cs
|   ├── Interfaces
|   |   ├── Commands
|   |   |   └── ICommand.cs
|   |   ├── Dao
|   |   |   └── IConferenceDao.cs
|   |   ├── Handlers
|   |   |   └── ICommandHander.cs
|   |   ├── Providers
|   |   |   └── IAccessCodeProvider.cs
|   |   ├── Repositories
|   |   |	├── IConferenceRepository.cs
|   |   |   └── IRepository.cs
|   |   └── IAggregateRoot.cs
|   ├── Providers
|   |   └── AccessCodeProvider.cs
|   └── Repositories
|   |   ├── ConferenceRepository.cs
|   |   └── FakeConferenceData.cs
├── DomainAutofacModule.cs
└────────────────────────────────────────
|
├── Conf.Management.Infrastructure
|
└────────────────────────────────────────
|
├── Conf.Management.WebApi
|   ├── Controllers
|   |   └── ConferenceController.cs
|   └── Models
|   |   └── CreateRequestModel.cs
├── ConferencesAutoMapperProfile.cs
├── Program.cs
├── Startup.cs
└── WebApiAutofacModule.cs

