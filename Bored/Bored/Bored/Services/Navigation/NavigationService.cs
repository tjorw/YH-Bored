using Bored.Pages;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bored.Services.Navigation
{
    public class NavigationService : INavigationService
    {
        private Page MainPage => Application.Current.MainPage;

        public async Task GoBack()
        {
            await MainPage.Navigation.PopAsync();
        }

        public async Task GoToAbout(string about)
        {
            await MainPage.Navigation.PushAsync(new AboutPage(about));
        }

        public async Task GoToTimes()
        {
            await MainPage.Navigation.PushAsync(new TimesPage());
        }
    }
}

