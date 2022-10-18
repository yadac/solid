using Ch9.WPF.Domain;
using Ch9.WPF.Infra;
using Ch9.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Ch9.WPF
{
    public class IocConfiguration
    {
        private static readonly IUnityContainer _container;

        static IocConfiguration()
        {
            _container = new UnityContainer();
            // register
            _container.RegisterType<TaskListWindow>();
            _container.RegisterType<TaskListWindowViewModel>();
            _container.RegisterType<ITaskService, TaskServiceAdo>();
            _container.RegisterType<IConnectionFactory, ConnectionFactory>();
        }

        public static T Resolve<T>() 
        {
            return _container.Resolve<T>();
        }
    }
}
