using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bored.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string activity;
        private int participants;
        private decimal price;
        public ICommand LoadCommand { get; }
        public ICommand GoToAboutCommand { get; }

        public MainPageViewModel()
        {
            LoadCommand = new Command(async () => await Load());
            GoToAboutCommand = new Command(async () => await NavigationService.GoToAbout());
        }

        public async Task Load()
        {
            var activity = await ApiService.GetRandom();
            Activity = activity.activity;
            Participants = activity.participants;
            Price = activity.price;

        }


        public string Activity
        {
            get => activity;
            set
            {
                if(activity != value)
                {
                    activity = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Participants
        {
            get => participants;
            set
            {
                if (participants != value)
                {
                    participants = value;
                    OnPropertyChanged();
                }
            }
        }

        public decimal Price { 
            get => price;
            set
            {
                if (price != value)
                {
                    price = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
