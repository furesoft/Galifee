using System;
using System.Windows.Input;

namespace Galifrei.Core
{
    public class DelegateCommand : ICommand
    {
        public DelegateCommand(Action<object> handler)
        {
            Handler = handler;
        }

        public Action<object> Handler { get; set; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Handler?.Invoke(parameter);
        }
    }
}