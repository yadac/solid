using Ch9.WPF.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9.WPF.Infra
{
    public class TaskServiceAdo : ITaskService
    {
        public IEnumerable<MyTask> GetAllTasks()
        {
            var allTasks = new List<MyTask>();

            // todo: adoで取得する
            allTasks.Add(new MyTask(0, "Clean the house", MyTask.PriorityLevel.LOW, DateTime.Now, false));
            allTasks.Add(new MyTask(1, "Pay the bills", MyTask.PriorityLevel.HIGH, DateTime.Now.AddDays(1), true));
            allTasks.Add(new MyTask(2, "Wash the dog", MyTask.PriorityLevel.MEDIUM, DateTime.Now.AddDays(2), false));

            return allTasks;
        }
    }
}
