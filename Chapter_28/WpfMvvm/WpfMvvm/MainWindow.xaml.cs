using System.Windows;
using WpfMvvm.ViewModels;

namespace WpfMvvm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindowViewModel ViewModel { get; set; } = new MainWindowViewModel();

    }
}
