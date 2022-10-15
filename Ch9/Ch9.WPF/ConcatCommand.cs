using Ch9.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ch9.WPF
{
    internal class ConcatCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly MainWindowViewModel _viewModel;
        public ConcatCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.ResultValue =
                _viewModel.Value1 + _viewModel.Value2;
        }
    }
}
