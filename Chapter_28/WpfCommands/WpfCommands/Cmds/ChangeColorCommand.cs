using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfCommands.Models;

namespace WpfCommands.Cmds
{
    public class ChangeColorCommand : CommandBase
    {
        //public bool CanExecute(object parameter) => (parameter as Inventory) != null;

        //public void Execute(object parameter)
        //{
        //    ((Inventory)parameter).Color = "Pink";
        //}

        //public event EventHandler CanExecuteChanged
        //{
        //    add => CommandManager.RequerySuggested += value;
        //    remove => CommandManager.RequerySuggested -= value;
        //}
        public override bool CanExecute(object parameter) => (parameter as Inventory) != null;

        public override void Execute(object parameter)
        {
            ((Inventory)parameter).Color = "Pink";
        }


    }
}
