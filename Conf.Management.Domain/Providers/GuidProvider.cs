using System;
using Conf.Management.Domain.Interfaces.Providers;

namespace Conf.Management.Domain.Providers
{
    internal class GuidProvider : IGuidProvider
    {
        public Guid GetGuid()
        {
            return Guid.NewGuid();
        }
    }
}
