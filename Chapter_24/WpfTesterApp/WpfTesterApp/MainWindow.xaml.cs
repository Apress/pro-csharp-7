using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTesterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closed+=MainWindow_OnClosed;
            this.Closing += MainWindow_Closing;
            this.MouseMove += MainWindow_MouseMove;
            this.KeyDown += MainWindow_KeyDown;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            ClickMe.Content = e.Key.ToString();
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            // Set the title of the window to the current (x,y) of the mouse.
            this.Title = e.GetPosition(this).ToString();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // See if the user really wants to shut down this window.
            string msg = "Do you want to close without saving?";
            MessageBoxResult result = MessageBox.Show(msg,
                "My App", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.No)
            {
                // If user doesn't want to close, cancel closure.
                e.Cancel = true;
            }
        }

        private void MainWindow_OnClosed(object sender, EventArgs eventArgs)
        {
            MessageBox.Show("See ya!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Did user enable /godmode?
            if ((bool) Application.Current.Properties["GodMode"])
            {
                MessageBox.Show("Cheater!");
            }
        }

        private void MyCalendar_OnSelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}