using Ch9.WPF.Domain;
using Ch9.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ch9.WPF
{
    internal class AddTaskCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly TaskListWindowViewModel _viewModel;
        public AddTaskCommand(TaskListWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.MyTasks.Add(
                new MyTask(
                    3, 
                    "Book flights", 
                    MyTask.PriorityLevel.HIGH, 
                    DateTime.Now.AddDays(3), 
                    false)
                );
        }
    }
}
