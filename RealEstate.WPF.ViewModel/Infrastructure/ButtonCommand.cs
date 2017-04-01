using RealEstate.WPF.ViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RealEstate.WPF.ViewModel.Infrastructure
{
    public class ButtonCommand : ICommand
    {
        AccountViewModel Account;
        public ButtonCommand(AccountViewModel _Account)
        {
            Account = _Account;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Account.Authorized();
        }
    }
}
