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
    /// <summary>
    /// UnityによるDI準備
    /// </summary>
    internal class IocUnityConfiguration
    {
        private readonly IUnityContainer _container;

        internal IocUnityConfiguration()
        {
            _container = new UnityContainer();
        }
        internal void Register()
        {
            _container.RegisterType<TaskListWindow>();
            _container.RegisterType<TaskListWindowViewModel>();
            _container.RegisterType<ITaskService, TaskServiceAdo>();
            _container.RegisterType<IConnectionFactory, ConnectionFactory>();
        }

        internal T Resolve<T>() 
        {
            return _container.Resolve<T>();
        }
    }
}
