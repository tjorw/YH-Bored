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

            MainPage = new MainPage();
        }

        private static void registerServices()
        {
            DependencyService.Register<IApiService, ApiService>();
            //DependencyService.Register<IApiService, ApiServiceMock>();
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
