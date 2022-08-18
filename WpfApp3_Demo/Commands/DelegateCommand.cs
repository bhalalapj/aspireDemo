using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp3_Demo.Commands
{
    public class DelegateCommand : ICommand
    {

        Action<object> action;

        public DelegateCommand(Action<object> obj)
        {
            action = obj;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true; // not going in that depth, we can contro it here
        }

        public void Execute(object parameter)
        {
            action?.Invoke(parameter);
        }
    }
}
