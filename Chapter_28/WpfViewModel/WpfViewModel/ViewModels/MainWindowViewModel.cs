using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfViewModel.Cmds;
using WpfViewModel.Models;

namespace WpfViewModel.ViewModels
{
    public class MainWindowViewModel
    {
        public IList<Inventory> Cars { get; } = new ObservableCollection<Inventory>();

        public MainWindowViewModel()
        {
            Cars.Add(
                new Inventory { CarId = 1, Color = "Blue", Make = "Chevy", PetName = "Kit", IsChanged = false });
            Cars.Add(
                new Inventory { CarId = 2, Color = "Red", Make = "Ford", PetName = "Red Rider", IsChanged = false });
        }

        private ICommand _changeColorCommand = null;
        public ICommand ChangeColorCmd => _changeColorCommand ?? (_changeColorCommand = new ChangeColorCommand());

        private ICommand _addCarCommand = null;
        public ICommand AddCarCmd => _addCarCommand ?? (_addCarCommand = new AddCarCommand());

        private RelayCommand<Inventory> _deleteCarCommand = null;
        public RelayCommand<Inventory> DeleteCarCmd
            => _deleteCarCommand ?? (_deleteCarCommand = new RelayCommand<Inventory>(DeleteCar, CanDeleteCar));
        private bool CanDeleteCar(Inventory car) => car != null;
        private void DeleteCar(Inventory car)
        {
            Cars.Remove(car);
        }

    }
}
