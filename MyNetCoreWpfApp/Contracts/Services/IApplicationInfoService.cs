using System;

namespace MyNetCoreWpfApp.Contracts.Services
{
    public interface IApplicationInfoService
    {
        Version GetVersion();
    }
}
