using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using AutoLotDAL.Models;
using AutoLotDAL.Repos;
using WpfMvvm.Cmds;

namespace WpfMvvm.ViewModels
{
    public class MainWindowViewModel
    {
        public IList<Inventory> Cars { get; }

        public MainWindowViewModel()
        {
            Cars = new ObservableCollection<Inventory>(new InventoryRepo().GetAll());
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
