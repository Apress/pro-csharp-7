using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using WpfNotifications.Models;

namespace WpfNotifications
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IList<Inventory> _cars = new ObservableCollection<Inventory>();

        public MainWindow()
        {
            InitializeComponent();
            _cars.Add(
                new Inventory {CarId = 1, Color = "Blue", Make = "Chevy", PetName = "Kit", IsChanged = false});
            _cars.Add(
                new Inventory {CarId = 2, Color = "Red", Make = "Ford", PetName = "Red Rider", IsChanged = false});
            cboCars.ItemsSource = _cars;
        }

        private void BtnChangeColor_OnClick(object sender, RoutedEventArgs e)
        {
            _cars.First(x => x.CarId == ((Inventory) cboCars.SelectedItem)?.CarId).Color = "Pink";
        }

        private void BtnAddCar_OnClick(object sender, RoutedEventArgs e)
        {
            var maxCount = _cars?.Max(x => x.CarId) ?? 0;
            _cars?.Add(new Inventory {CarId = ++maxCount, Color = "Yellow", Make = "VW", PetName = "Birdie"});
        }
    }
}