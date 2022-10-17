using Ch9.WPF.Domain;
using Ch9.WPF.Infra;
using Ch9.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace Ch9.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var vm = DI.Resolve<ViewModels.TaskListWindowViewModel>();
            var view = new TaskListWindow()
            {
                DataContext = vm,
            };
            view.Show();
        }

        private IUnityContainer _container;
        private void OnApplicationStartup(object sender, StartupEventArgs e)
        {
            // AutoMapper導入前
            //CreateMappings();
            _container = new UnityContainer();
            _container.RegisterType<ITaskService, TaskServiceAdo>();
            _container.RegisterType<TaskListWindow>();
            _container.RegisterType<TaskListWindowViewModel>();
            MainWindow = _container.Resolve<TaskListWindow>();
            MainWindow.DataContext = _container.Resolve<TaskListWindowViewModel>();
            MainWindow.Show();
        }

    }
}
