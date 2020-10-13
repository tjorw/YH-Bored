using Bored.Mocks.Times;
using Bored.Services.Bored;
using Bored.Services.Navigation;
using Bored.Services.Times;
using Xamarin.Forms;

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
            DependencyService.Register<IBoredApiService, BoredApiService>();
            DependencyService.Register<ITimesApiService, TimesApiServiceMock>();
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
