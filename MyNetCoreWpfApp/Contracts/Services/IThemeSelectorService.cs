using System;

using MyNetCoreWpfApp.Models;

namespace MyNetCoreWpfApp.Contracts.Services
{
    public interface IThemeSelectorService
    {
        bool SetTheme(AppTheme? theme = null);

        AppTheme GetCurrentTheme();
    }
}
