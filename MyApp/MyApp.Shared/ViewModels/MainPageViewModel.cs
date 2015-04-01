using MyApp.Infrastructure;

namespace MyApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string title;

        public string Title
        {
            get { return this.title; }
            set { SetProperty(ref title, value); }
        }

        public MainPageViewModel()
        {
            this.Title = "Hello, MVVM World!";
        }
    }
}
