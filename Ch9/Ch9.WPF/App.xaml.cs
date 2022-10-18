using AutoMapper;
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
using System.Xml.Linq;
using Unity;

namespace Ch9.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IocConfiguration _ioc;

        protected override void OnStartup(StartupEventArgs e)
        {
            // AutoMapper
            // CreateMappings();

            // Microsoft DI
            //base.OnStartup(e);
            //var vm = DI.Resolve<ViewModels.TaskListWindowViewModel>();
            //var view = new TaskListWindow()
            //{
            //    DataContext = vm,
            //};
            //view.Show();

            // Unity DI
            //_ioc = new IocConfiguration();
            //_ioc.Register();

            MainWindow = 
                IocConfiguration.Resolve<TaskListWindow>();
            MainWindow.DataContext =
                IocConfiguration.Resolve<TaskListWindowViewModel>();
            MainWindow.Show();
        }
    }
}
