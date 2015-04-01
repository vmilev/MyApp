using MyApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        private string title;

        public string Title
        {
            get { return this.title; }
            set { SetProperty(ref title, value); }
        }

        public SecondPageViewModel()
        {
            this.Title = "You have arrived at your destination!";
        }
    }
}
