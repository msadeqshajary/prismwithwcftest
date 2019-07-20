using TestModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Diagnostics;
using SharedService;

namespace TestModule
{
    [Module(ModuleName = "TestModule")]
    public class TestModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            Debug.Print("MODULE LOADED SUCCESSFULLY");
            RegionManager regionManager = containerProvider.Resolve<RegionManager>();
            regionManager.RegisterViewWithRegion("testRegion", () => containerProvider.Resolve<ViewA>());
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<Services>();
            //Services services = new Services();
            //Debug.Print(services.Taqeh.GetPofakList()[0].GetRecognizableName + " IS NAMe");
        }
    }
}