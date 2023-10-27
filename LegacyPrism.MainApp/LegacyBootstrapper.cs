using Prism.Unity;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Mvvm;
using Prism.Modularity;
using System;

namespace LegacyPrism.MainApp
{
    class LegacyBootstrapper : UnityBootstrapper
    {
        public LegacyBootstrapper()
        {
            ViewModelLocationProvider.Register(typeof(MainWindow).ToString(), typeof(MainWindowViewModel));  
        }
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>(); 
        }
        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
        protected override IModuleCatalog CreateModuleCatalog()
        {
            //return base.CreateModuleCatalog();
            return new ConfigurationModuleCatalog();    // app.config based module definitions
        }
        protected override void InitializeModules()
        {
            try
            { 
                base.InitializeModules();
            }
            catch(Exception ex)
            {
            }
        }

    }
}
 