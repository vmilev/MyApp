using CCT.Desktop.Infrastructure;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Mvvm.Interfaces;
using Microsoft.Practices.Unity;
using System.Windows;
using System.Windows.Navigation;

namespace MyApp.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static readonly IUnityContainer Container = new UnityContainer();
        public static INavigationService NavigationService { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            this.ConfigureUnityContainer();
            ViewModelLocationProvider.SetDefaultViewModelFactory((type) => Container.Resolve(type));

            base.OnStartup(e);
        }

        private void ConfigureUnityContainer()
        {
        }

        internal static void InitializeNavigationService(NavigationService service)
        {
            NavigationService = new SimpleNavigationService(service);

            Container.RegisterInstance<INavigationService>(NavigationService);
        }
    }
}
