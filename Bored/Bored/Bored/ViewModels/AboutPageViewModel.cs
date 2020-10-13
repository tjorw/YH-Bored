using System.Windows.Input;
using Xamarin.Forms;

namespace Bored.ViewModels
{
    public class AboutPageViewModel : BasePageViewModel
    {
        private string about = string.Empty;

        public AboutPageViewModel(string about)
        {
            this.about = about;
        }

        public string About
        {
            get => about;
            set
            {
                if (about != value)
                {
                    about = value;
                    MessagingCenter.Send(this, Messages.AboutChanged, about);
                    OnPropertyChanged();
                }
            }
        }
    }
}
