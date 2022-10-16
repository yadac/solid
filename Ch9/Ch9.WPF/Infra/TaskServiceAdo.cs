using Ch9.WPF.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
            var settings = ConfigurationManager.ConnectionStrings["Ch9.WPF.Properties.Settings.Ch9ConnectionString"];
            using (var connection = 
                //new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ch9.mdf;Integrated Security=True"))
                new SqlConnection(settings.ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    var command = connection.CreateCommand();
                    command.Transaction = transaction;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "select Id, Description, Priority, DueDate, Complete from MyTask;";
                    using (var reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
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
                                // 完全コンストラクタを定義しているとオブジェクト初期化子でエラーになる
                                //allTasks.Add(new MyTask 
                                //{
                                //    Id = reader.GetInt32(0)
                                //    , Description = reader.GetString(1)
                                //    , Priority = (PriorityLevel)reader.GetInt32(2)
                                //    , DueDate = reader.GetDateTime(3)
                                //    , Completed = reader.GetBoolean(4)
                                //});
                            }
                        }
                    }
                }
            }
            // Dummy
            //allTasks.Add(new MyTask(0, "Clean the house", MyTask.PriorityLevel.LOW, DateTime.Now, false));
            //allTasks.Add(new MyTask(1, "Pay the bills", MyTask.PriorityLevel.HIGH, DateTime.Now.AddDays(1), true));
            //allTasks.Add(new MyTask(2, "Wash the dog", MyTask.PriorityLevel.MEDIUM, DateTime.Now.AddDays(2), false));
            return allTasks;
        }
    }
}
