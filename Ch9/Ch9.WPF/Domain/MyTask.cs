using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9.WPF.Domain
{
    public class MyTask
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public PriorityLevel Priority { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }

        public MyTask(int id, string description
            , PriorityLevel priority, DateTime dueDate, bool completed)
        {
            Id = id;
            Description = description;
            Priority = priority;
            DueDate = dueDate;
            Completed = completed;
        }
    }

    public class MyTaskDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public PriorityLevel Priority { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }
    }

    public enum PriorityLevel
    {
        LOW = 10,
        MEDIUM = 20,
        HIGH = 30
    }

}
