using Bored.Mocks;
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

            registerServices();

            MainPage = new NavigationPage(new MainPage());
        }

        private static void registerServices()
        {
            DependencyService.Register<IApiService, ApiServiceSlowMock>();
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
