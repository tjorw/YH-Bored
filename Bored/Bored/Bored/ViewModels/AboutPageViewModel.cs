using System.Windows.Input;
using Xamarin.Forms;

namespace Bored.ViewModels
{
    public class AboutPageViewModel : BaseViewModel
    {
        private string about;

        public AboutPageViewModel()
        {
            About = "BLA BLA BLA..";
        }

        public string About
        {
            get => about;
            set
            {
                if (about != value)
                {
                    about = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
