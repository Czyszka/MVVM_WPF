using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KoloryWPF.ModelWidoku
{

    public class ResetujCommand : ICommand
    {
        private readonly EdycjaKoloru modelWidoku;

        public ResetujCommand(EdycjaKoloru modelWidoku)
        {
            if (modelWidoku == null) throw new ArgumentNullException("modelWidoku");
            this.modelWidoku = modelWidoku;
        }

        public event EventHandler? CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object? parameter)
        {
            return (modelWidoku.R != 0) || (modelWidoku.G !=0)|| (modelWidoku.B != 0);
        }

        public void Execute(object? parameter)
        {
            //EdycjaKoloru modelWidoku = parameter as EdycjaKoloru;
            //if(modelWidoku != null)
            //{
            modelWidoku.R = 0;
            modelWidoku.G = 0;
            modelWidoku.B = 0;
            //}
        }
    }
    public class RelayCommand : ICommand
    {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            if (execute is null) throw new ArgumentNullException(nameof(execute));
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged
        {
            add
            {
                if (_canExecute != null) CommandManager.RequerySuggested += value;
            }
            remove
            {
                if(_canExecute != null) CommandManager.RequerySuggested -= value;
            }
        }
        [DebuggerStepThrough]
        public bool CanExecute(object? parameter)
        {
            return _canExecute == null ? true: _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
