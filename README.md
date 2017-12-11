# Conference.Management solution structure
Test solution for DDD practices

## Folders and files structure
#### Solytion skeleton
The skeleton of the solution has the following folders and files structure:
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
|   |   |   ├── IConferenceRepository.cs
|   |   |   └── IRepository.cs
|   |   └── IAggregateRoot.cs
|   ├── Providers
|   |   └── AccessCodeProvider.cs
|   ├── Repositories
|   |   ├── ConferenceRepository.cs
|   |   └── FakeConferenceData.cs
|   └──DomainAutofacModule.cs
|
|
|
├── Conf.Management.Infrastructure
|   └── ...
|
|
|
└── Conf.Management.WebApi
    ├── Controllers
    |   └── ConferenceController.cs
    ├── Models
    |   ├── Requests
    |   |   └── CreateRequestModel.cs
    |   └──Responses
    |       └── CreateResponseModel.cs
    └── Resolvers
    |   ├── ConferenceCodeResolver.cs
    |   └── ConferenceIdResolver.cs
    ├── AutoMapperProfile.cs
    ├── ConferencesAutoMapperProfile.cs
    ├── Program.cs
    ├── Startup.cs
    └── WebApiAutofacModule.cs

