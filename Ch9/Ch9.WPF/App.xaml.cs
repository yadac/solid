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
        //private IocUnityConfiguration _config;
        private IocMSConfiguration _config;

        protected override void OnStartup(StartupEventArgs e)
        {
            // AutoMapper
            // CreateMappings();

            base.OnStartup(e);

            // Microsoft DI
            _config = new IocMSConfiguration();
            _config.Register();
            MainWindow = _config.Resolve<TaskListWindow>();
            MainWindow.Show();

            // Unity DI
            //_config = new IocConfiguration();
            //_config.Register();
            //MainWindow = _config.Resolve<TaskListWindow>();
            //MainWindow.Show();
        }
    }
}