using System;

namespace AspNetBoilerPlateMySql.Application.Interfaces.Shared
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}