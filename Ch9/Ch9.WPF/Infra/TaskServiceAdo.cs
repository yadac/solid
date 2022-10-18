using Ch9.WPF.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9.WPF.Infra
{
    public class TaskServiceAdo : ITaskService
    {
        private readonly IConnectionFactory _connectionFactory;
        public TaskServiceAdo(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public IEnumerable<MyTask> GetAllTasks()
        {
            var allTasks = new List<MyTask>();
            using (var conncetion = _connectionFactory.CreateConnection())
            {
                conncetion.Open();
                using (var transaction = conncetion.BeginTransaction())
                {
                    var command = conncetion.CreateCommand();
                    command.Transaction = transaction;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select Id, Description, Priority, DueDate, Complete from MyTask;";
                    using (var reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            var t = new MyTask(
                                reader.GetInt32(0)
                                , reader.GetString(1)
                                , (PriorityLevel)reader.GetInt32(2)
                                , reader.GetDateTime(3)
                                , reader.GetBoolean(4));
                            allTasks.Add(t);
                        }
                    }
                }
            }
            return allTasks;
        }
    }
}
