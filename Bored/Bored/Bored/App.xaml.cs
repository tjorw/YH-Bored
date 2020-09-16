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

            DependencyService.Register<IApiService, ApiService>();
            //DependencyService.Register<IApiService, ApiServiceMock>();

            MainPage = new MainPage();
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
