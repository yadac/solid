using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9.WPF.Domain
{
    public interface ITaskService
    {
        IEnumerable<MyTask> GetAllTasks();
    }
}
