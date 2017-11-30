using System;

namespace Conf.Management.Domain.Interfaces
{
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
}