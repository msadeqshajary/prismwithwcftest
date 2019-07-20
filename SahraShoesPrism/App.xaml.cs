using SahraShoesPrism.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using System;
using Prism.Regions;
using SharedService;

namespace SahraShoesPrism
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        //protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        //{
        //    Type testType = typeof(TestModuleModule);
        //    moduleCatalog.AddModule(
        //        new ModuleInfo()
        //        {
        //            ModuleName = testType.Name,
        //            ModuleType = testType.AssemblyQualifiedName
        //        });
        //}

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return ModuleCatalog.CreateFromXaml(new Uri("pack://application:,,,/SahraShoesPrism;component/ModulesCatalog.xaml", UriKind.RelativeOrAbsolute));
            //return new DirectoryModuleCatalog() { ModulePath = @".\ModulesDirectory" };
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<Services>();
        }
    }
}
