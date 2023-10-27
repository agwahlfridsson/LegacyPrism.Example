using LegacyPrism.ServiceModule.Test;
using LegacyPrism.Test;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace LegacyPrism.ServiceModule
{
    public class ServiceModuleInfo : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer unityContainer;

        public ServiceModuleInfo(IRegionManager regionManager,
                                 IUnityContainer unityContainer)
        {
            this.regionManager = regionManager;
            this.unityContainer = unityContainer;
        }
        public void Initialize()
        {
            unityContainer.RegisterType<ITestInterface, TestService>(new ContainerControlledLifetimeManager());
        }
    }
}
