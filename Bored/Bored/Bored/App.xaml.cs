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

            DependencyService.Register<INavigationService, NavigationService>();
            DependencyService.Register<IApiService, ApiService>();

            MainPage = new NavigationPage(new MainPage());
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
