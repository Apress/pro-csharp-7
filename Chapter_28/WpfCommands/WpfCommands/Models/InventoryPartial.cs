using System.ComponentModel;

namespace WpfCommands.Models
{
    public partial class Inventory : EntityBase, IDataErrorInfo
    {
        private string _error;
        public string Error => _error;

        public string this[string columnName]
        {
            get
            {
                //Original implementation
                //switch (columnName)
                //{
                //    case nameof(CarId):
                //        break;
                //    case nameof(Make):
                //        if (Make == "ModelT")
                //        {
                //            return "Too Old";
                //        }
                //        return CheckMakeAndColor();
                //    case nameof(Color):
                //        return CheckMakeAndColor();
                //    case nameof(PetName):
                //        break;
                //}
                //return string.Empty;
                //Updated implementation
                bool hasError = false;
                switch (columnName)
                {
                    case nameof(CarId):
                        AddErrors(nameof(CarId), GetErrorsFromAnnotations(nameof(CarId), CarId));
                        break;
                    case nameof(Make):
                        hasError = CheckMakeAndColor();
                        if (Make == "ModelT")
                        {
                            AddError(nameof(Make), "Too Old");
                            hasError = true;
                        }
                        if (!hasError)
                        {
                            //This is not perfect logic, just illustrative of the pattern
                            ClearErrors(nameof(Make));
                            ClearErrors(nameof(Color));
                        }
                        AddErrors(nameof(Make), GetErrorsFromAnnotations(nameof(Make), Make));
                        break;
                    case nameof(Color):
                        hasError = CheckMakeAndColor();
                        if (!hasError)
                        {
                            ClearErrors(nameof(Make));
                            ClearErrors(nameof(Color));
                        }
                        AddErrors(nameof(Color), GetErrorsFromAnnotations(nameof(Color), Color));
                        break;
                    case nameof(PetName):
                        AddErrors(nameof(PetName), GetErrorsFromAnnotations(nameof(PetName), PetName));
                        break;
                }
                return string.Empty;
            }
        }


        //internal string CheckMakeAndColor()
        //{
        //    if (Make == "Chevy" && Color == "Pink")
        //    {
        //        return $"{Make}'s don't come in {Color}";
        //    }
        //    return string.Empty;
        //}
        internal bool CheckMakeAndColor()
        {
            if (Make != "Chevy" || Color != "Pink") return false;
            AddError(nameof(Make), $"{Make}'s don't come in {Color}");
            AddError(nameof(Color), $"{Make}'s don't come in {Color}");
            return true;
        }
    }
}