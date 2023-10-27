using System.Windows;

namespace LegacyPrism.MainApp
{
    public partial class App : Application
    {   private readonly LegacyBootstrapper bootstrapper;
        public App() 
        {
            bootstrapper = new LegacyBootstrapper();
            bootstrapper.Run();
        }
    }
}
