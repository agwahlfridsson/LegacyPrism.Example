using LegacyPrism.ViewModule.ContextView;
using LegacyPrism.ViewModule.MenuView;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;

namespace LegacyPrism.ViewModule
{
    //[Module(ModuleName = "ViewModuleInfo")]
    //[ModuleDependency("LegacyPrism.ServiceModule.ServiceModuleInfo")]
    public class ViewModuleInfo : IModule
    {
        private readonly IUnityContainer unityContainer;
        private readonly IRegionManager regionManager;

        public ViewModuleInfo(IUnityContainer unityContainer, IRegionManager regionManager)
        {
            this.unityContainer = unityContainer;
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            ViewModelLocationProvider.Register(typeof(Menu).ToString(), typeof(MenuViewModel));
            ViewModelLocationProvider.Register(typeof(Context).ToString(), typeof(ContextViewModel));
            regionManager.RegisterViewWithRegion("MenuRegion", typeof(Menu));
            regionManager.RegisterViewWithRegion("ContextRegion", typeof(Context));
        }
    }
}
