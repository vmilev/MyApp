using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm.Interfaces;
using MyApp.Infrastructure;
using System.Windows.Input;

namespace MyApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string title;
        private INavigationService navService;
        private readonly ICommand navigateAway;

        public string Title
        {
            get { return this.title; }
            set { SetProperty(ref title, value); }
        }

        public ICommand NavigateAway
        {
            get { return this.navigateAway; }
        }

        public MainPageViewModel(INavigationService navService)
        {
            this.navService = navService;
            this.Title = "Hello, MVVM World!";

            this.navigateAway = new DelegateCommand<int?>(this.TestCommandCallback);
        }

        private void TestCommandCallback(int? obj)
        {
            this.navService.Navigate("SecondPage", null);
        }
    }
}