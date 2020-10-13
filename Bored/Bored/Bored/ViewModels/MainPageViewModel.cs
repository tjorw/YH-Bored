using Bored.Models;
using Bored.Services;
using Bored.Services.Bored;
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
    public class MainPageViewModel : BasePageViewModel
    {
        private bool isBusy = false;
        private string welcome = "Welcome to BORED!";
        private string about = "Things to do if you are bored.";
        private string activity = string.Empty;
        private ObservableCollection<ActivityModel> history = new ObservableCollection<ActivityModel>();

        public ICommand SelectFromHistoryCommand { get; }
        public ICommand LoadCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand GoToAboutCommand { get; }
        public ICommand GoToTimesCommand { get; }

        public MainPageViewModel()
        {
            LoadCommand = new Command(async () => await Load(), () => !IsBusy);
            GoToAboutCommand = new Command(async () => await NavigationService.GoToAbout(about), () => !IsBusy);
            GoToTimesCommand = new Command(async () => await NavigationService.GoToTimes(), () => !IsBusy);
            SelectFromHistoryCommand = new Command<ActivityModel>((activity) => Select(activity), (activity) => history.Count() > 0);
            ClearCommand = new Command(() => Clear(), () => !IsBusy && history.Count() > 0);

            MessagingCenter.Subscribe<AboutPageViewModel, string>(this, Messages.AboutChanged, (sender, message) => this.About = message);
        }


        public ObservableCollection<ActivityModel> History { get => history;}

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
                    ((Command)GoToTimesCommand).ChangeCanExecute();
                    ((Command)ClearCommand).ChangeCanExecute();
                    ((Command)SelectFromHistoryCommand).ChangeCanExecute();
                }
            }
        }
        public string Activity
        {
            get => activity;
            set
            {
                if (activity != value)
                {
                    activity = value;
                    OnPropertyChanged();
                }
            }
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

        public string Welcome
        {
            get => welcome;
            set
            {
                if (welcome != value)
                {
                    welcome = value;
                    OnPropertyChanged();
                }
            }
        }


        public async Task Load()
        {
            
            try
            {
                IsBusy = true;
                var response = await BoredApiService.GetRandom();

                var activity = response.ToActivity();

                Activity = activity.Activity;

                if(!history.Any( a => a.Key == activity.Key ))
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

        public void Select(ActivityModel activity)
        {
            Activity = activity.Activity;
        }

        public void Clear()
        {
            Activity = string.Empty;
            history.Clear();
            ((Command)ClearCommand).ChangeCanExecute();
            ((Command)SelectFromHistoryCommand).ChangeCanExecute();
        }

    }
}
