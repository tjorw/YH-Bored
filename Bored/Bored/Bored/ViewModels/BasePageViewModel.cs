
using Bored.Services.Bored;
using Bored.Services.Navigation;
using Bored.Services.Times;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Bored.ViewModels
{

    public abstract class BasePageViewModel : INotifyPropertyChanged
    {

        public IBoredApiService BoredApiService { get; set; }
        public INavigationService NavigationService { get; set; }
        public ITimesApiService TimesApiService { get; set; }

        public BasePageViewModel()
        {
            try
            {
                BoredApiService = DependencyService.Get<IBoredApiService>();
                NavigationService = DependencyService.Get<INavigationService>();
                TimesApiService = DependencyService.Get<ITimesApiService>();
            }
            catch
            {

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

