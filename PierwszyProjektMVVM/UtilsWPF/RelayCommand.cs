using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UtilsWPF
{
    class RelayCommand<T>:ICommand
    {
        private Action<T> execute;
        private Func<T, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add
            {
                
            }
        }

        public RelayCommand(Action<T> execute, Func<T, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public bool CanExecute (object parameter)
        {
            return canExecute == null || canExecute((T)parameter);
        }
        public void Execute (object parameter)
        {
            execute((T)parameter);
        }
    }
}
