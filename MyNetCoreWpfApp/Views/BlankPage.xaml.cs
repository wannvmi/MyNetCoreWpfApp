using System.Windows.Controls;

using MyNetCoreWpfApp.ViewModels;

namespace MyNetCoreWpfApp.Views
{
    public partial class BlankPage : Page
    {
        public BlankPage(BlankViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
