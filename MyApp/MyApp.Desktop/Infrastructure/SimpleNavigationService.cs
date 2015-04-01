using Microsoft.Practices.Prism.Mvvm.Interfaces;
using System;
using System.Windows.Navigation;

namespace CCT.Desktop.Infrastructure
{
    public class SimpleNavigationService : INavigationService
    {
        private NavigationService navigationService;

        public SimpleNavigationService(NavigationService nativeService)
        {
            this.navigationService = nativeService;
        }

        public bool CanGoBack()
        {
            return this.navigationService.CanGoBack;
        }

        public void ClearHistory()
        {
            throw new NotImplementedException();
        }

        public void GoBack()
        {
            this.navigationService.GoBack();
        }

        public bool Navigate(string pageToken, object parameter)
        {
            return this.navigationService.Navigate(new Uri(string.Format("Views/{0}.xaml", pageToken), UriKind.Relative));
        }

        public void RestoreSavedNavigation()
        {
            throw new NotImplementedException();
        }

        public void Suspending()
        {
            throw new NotImplementedException();
        }
    }
}
