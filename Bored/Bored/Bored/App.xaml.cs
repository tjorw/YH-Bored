using Bored.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bored
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            RegisterServices();

            MainPage = new NavigationPage(new MainPage());
        }

        private void RegisterServices()
        {
            DependencyService.Register<INavigationService, NavigationService>();
            DependencyService.Register<IApiService, ApiService>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
