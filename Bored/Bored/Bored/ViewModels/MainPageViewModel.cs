using Bored.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bored.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private bool isBusy;
        private string activity;
        private int participants;
        private decimal price;
        public ICommand SelectFromHistoryCommand { get; }
        public ICommand LoadCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand GoToAboutCommand { get; }

        private ObservableCollection<Activity> history = new ObservableCollection<Activity>();

        public MainPageViewModel()
        {
            LoadCommand = new Command(async () => await Load(), () => !IsBusy);
            GoToAboutCommand = new Command(async () => await NavigationService.GoToAbout(), () => !IsBusy);
            SelectFromHistoryCommand = new Command<Activity>((activity) => Select(activity), (activity) => history.Count() > 0);
            ClearCommand = new Command(() => Clear(), () => !IsBusy && history.Count() > 0);
        }

        public ObservableCollection<Activity> History { get => history;}

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (isBusy != value)
                {
                    isBusy = value;
                    OnPropertyChanged();
                    ((Command)LoadCommand).ChangeCanExecute();
                    ((Command)GoToAboutCommand).ChangeCanExecute();
                    ((Command)ClearCommand).ChangeCanExecute();
                    ((Command)SelectFromHistoryCommand).ChangeCanExecute();
                }
            }
        }

        public async Task Load()
        {
            
            try
            {
                IsBusy = true;
                var activity = await ApiService.GetRandom();
                Activity = activity.activity;
                Participants = activity.participants;
                Price = activity.price;

                if(!history.Any( a => a.key == activity.key ))
                {
                    history.Add(activity);
                    ((Command)ClearCommand).ChangeCanExecute();
                    ((Command)SelectFromHistoryCommand).ChangeCanExecute();
                }

            } 
            catch { }
            finally
            {
                IsBusy = false;
            }

            
        }

        public void Select(Activity activity)
        {
            Activity = activity.activity;
            Participants = activity.participants;
            Price = activity.price;
        }


        public void Clear()
        {
            history.Clear();
            ((Command)ClearCommand).ChangeCanExecute();
            ((Command)SelectFromHistoryCommand).ChangeCanExecute();
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
