using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bored.Services
{
    public class NavigationService : INavigationService
    {
        private Page MainPage => Application.Current.MainPage;

        public async Task GoBack()
        {
            await MainPage.Navigation.PopAsync();
        }

        public async Task GoToAbout()
        {
            await MainPage.Navigation.PushAsync(new AboutPage());
        }
    }
}

