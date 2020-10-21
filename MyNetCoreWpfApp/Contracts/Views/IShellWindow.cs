﻿using System.Windows.Controls;

namespace MyNetCoreWpfApp.Contracts.Views
{
    public interface IShellWindow
    {
        Frame GetNavigationFrame();

        void ShowWindow();

        void CloseWindow();
    }
}
