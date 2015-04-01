namespace Microsoft.Practices.Prism.Mvvm.Interfaces
{
    public interface INavigationService
    {
        bool CanGoBack();
        void ClearHistory();
        void GoBack();
        bool Navigate(string pageToken, object parameter);
        void RestoreSavedNavigation();
        void Suspending();
    }
}
