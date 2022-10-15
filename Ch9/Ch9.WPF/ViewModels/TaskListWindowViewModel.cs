using Ch9.WPF.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9.WPF.ViewModels
{
    public class TaskListWindowViewModel
    {
        // notify機能付きcollectionなのでバインドしておくだけ
        private ObservableCollection<MyTask> _myTasks;
        public TaskListWindowViewModel()
        {
            _myTasks = new ObservableCollection<MyTask>
            {
                new MyTask(0, "Clean the house", MyTask.PriorityLevel.LOW, DateTime.Now, false),
                new MyTask(1, "Pay the bills", MyTask.PriorityLevel.HIGH, DateTime.Now.AddDays(1), false),
                new MyTask(2, "Wash the dog", MyTask.PriorityLevel.MEDIUM, DateTime.Now.AddDays(2), false),
            };
        }

        public ObservableCollection<MyTask> MyTasks
        {
            get { return _myTasks; }
        }
    }
}
