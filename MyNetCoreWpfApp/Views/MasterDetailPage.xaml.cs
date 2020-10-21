using System.Windows.Controls;

using MyNetCoreWpfApp.ViewModels;

namespace MyNetCoreWpfApp.Views
{
    public partial class MasterDetailPage : Page
    {
        public MasterDetailPage(MasterDetailViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
