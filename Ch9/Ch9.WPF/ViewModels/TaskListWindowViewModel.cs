using Ch9.WPF.Domain;
using Ch9.WPF.Infra;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ch9.WPF.ViewModels
{
    public class TaskListWindowViewModel
    {
        private ObservableCollection<MyTask> _myTasks;
        private ICommand _taskCommand;
        private readonly ITaskService _taskService;

        public TaskListWindowViewModel()
            : this(Factories.CreateTaskService())
        {
        }

        public TaskListWindowViewModel(ITaskService taskService)
        {
            _taskService = taskService;
            _taskCommand = new AddTaskCommand(this);
            _myTasks = new ObservableCollection<MyTask>
            {
                new MyTask(0, "Clean the house", MyTask.PriorityLevel.LOW, DateTime.Now, false),
                new MyTask(1, "Pay the bills", MyTask.PriorityLevel.HIGH, DateTime.Now.AddDays(1), true),
                new MyTask(2, "Wash the dog", MyTask.PriorityLevel.MEDIUM, DateTime.Now.AddDays(2), false),
            };
        }

        public ICommand AddTask => _taskCommand;

        public ObservableCollection<MyTask> MyTasks
        {
            get { return _myTasks; }
            set
            {
                _myTasks = value;
                // notify?
            }
        }
    }
}
