using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions;
using Ch9.WPF.ViewModels;
using Ch9.WPF.Domain;
using Ch9.WPF.Infra;
using System.Threading;

namespace Ch9.WPF
{
    /// <summary>
    /// Microsoft.Extensions.DependencyInjectionによるDI準備
    /// </summary>
    public class IocMSConfiguration
    {
        private ServiceCollection _container;
        private ServiceProvider _serviceProvider;

        internal IocMSConfiguration()
        {
            _container = new ServiceCollection();
        }

        internal void Register()
        {
            _container.AddTransient<TaskListWindow>();
            _container.AddTransient<TaskListWindowViewModel>();
            _container.AddTransient<ITaskService, TaskServiceAdo>();
            _container.AddTransient<IConnectionFactory, ConnectionFactory>();

            _serviceProvider = _container.BuildServiceProvider();
        }

        internal T Resolve<T>() => _serviceProvider.GetRequiredService<T>();
    }
}
