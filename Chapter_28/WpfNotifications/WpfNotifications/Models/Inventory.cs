using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfNotifications.Models
{
    public class Inventory : INotifyPropertyChanged
    {
        public bool IsChanged { get; set; }
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
        public string PetName { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class InventoryManual //: INotifyPropertyChanged
    {
        private int _carId;
        private string _make;
        private string _color;
        private string _petName;
        private bool _isChanged;
        public bool IsChanged
        {
            get => _isChanged;
            set
            {
                if (value == _isChanged) return;
                _isChanged = value;
                OnPropertyChanged();
            }
        }

        public int CarId
        {
            get => _carId;
            set
            {
                if (value == _carId) return;
                _carId = value;
                OnPropertyChanged();
            }
        }

        public string Make
        {
            get => _make;
            set
            {
                if (value == _make) return;
                _make = value;
                OnPropertyChanged();
            }
        }

        public string Color
        {
            get => _color;
            set
            {
                if (value == _color) return;
                _color = value;
                OnPropertyChanged(nameof(Color));
            }
        }

        public string PetName
        {
            get => _petName;
            set
            {
                if (value == _petName) return;
                _petName = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (propertyName != nameof(IsChanged))
            {
                IsChanged = true;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
