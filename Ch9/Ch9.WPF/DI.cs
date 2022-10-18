using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions;
using Ch9.WPF.ViewModels;

namespace Ch9.WPF
{
    public class DI
    {
        static ServiceCollection _container = new ServiceCollection();
        static ServiceProvider _serviceProvider;

        public static T Resolve<T>() => _serviceProvider.GetRequiredService<T>();

        static DI()
        {
            _container.AddTransient<TaskListWindowViewModel>();
            _serviceProvider = _container.BuildServiceProvider();
        }
    }
}
