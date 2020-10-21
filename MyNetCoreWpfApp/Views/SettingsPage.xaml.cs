using System.Windows.Controls;

using MyNetCoreWpfApp.ViewModels;

namespace MyNetCoreWpfApp.Views
{
    public partial class SettingsPage : Page
    {
        public SettingsPage(SettingsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
