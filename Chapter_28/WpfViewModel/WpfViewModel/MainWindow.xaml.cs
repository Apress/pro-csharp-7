using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using WpfViewModel.Cmds;
using WpfViewModel.Models;
using WpfViewModel.ViewModels;

namespace WpfViewModel
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
