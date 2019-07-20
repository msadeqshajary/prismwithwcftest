using Prism.Modularity;
using System;
using System.Diagnostics;
using System.Windows;


namespace SahraShoesPrism.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ModuleManager moduleManager;
        public MainWindow(ModuleManager mm)
        {
            moduleManager = mm;
            moduleManager.LoadModuleCompleted += ModuleManager_LoadModuleCompleted;
            InitializeComponent();
        }

        private void ModuleManager_LoadModuleCompleted(object sender, LoadModuleCompletedEventArgs e)
        {
            Debug.Print("Module loaded : " + e.ModuleInfo.ModuleName);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            moduleManager.LoadModule("TestModule");
            
        }
    }
}
