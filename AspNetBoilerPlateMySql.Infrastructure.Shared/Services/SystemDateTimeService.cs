using AspNetBoilerPlateMySql.Application.Interfaces.Shared;
using System;

namespace AspNetBoilerPlateMySql.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}