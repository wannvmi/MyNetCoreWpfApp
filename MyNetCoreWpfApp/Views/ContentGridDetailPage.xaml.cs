using System.Windows.Controls;

using MyNetCoreWpfApp.ViewModels;

namespace MyNetCoreWpfApp.Views
{
    public partial class ContentGridDetailPage : Page
    {
        public ContentGridDetailPage(ContentGridDetailViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
