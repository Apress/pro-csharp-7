using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;

namespace WpfValidations.Models
{
    public partial class Inventory : INotifyPropertyChanged
    {
        public bool IsChanged { get; set; }
        [Required]
        public int CarId { get; set; }
        [Required, StringLength(50)]
        public string Make { get; set; }
        [Required, StringLength(50)]
        public string Color { get; set; }
        [StringLength(50)]
        public string PetName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (propertyName != nameof(IsChanged))
            {
                IsChanged = true;
            }
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
        }

    }

}
