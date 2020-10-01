using Bored.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bored
{
    public partial class MainPage : ContentPage
    {
        IApiService apiService;
        ObservableClass SomethingObservable;

        public MainPage()
        {
            InitializeComponent();
            apiService = DependencyService.Get<IApiService>();
            bindStuffWithCode();
        }

        private void bindStuffWithCode()
        {
            SomethingObservable = new ObservableClass();
            SomethingObservable.Name = "Test";
            
            Entry1.SetBinding(Entry.TextProperty, "Name");
            Entry1.BindingContext = SomethingObservable;

            Entry2.SetBinding(Entry.TextProperty, "Name");
            Entry2.BindingContext = SomethingObservable;

        }

    protected override async void OnAppearing()
        {
            base.OnAppearing();

            await load();
        }

        private async Task load()
        {
            LoadingFrame.IsVisible = true;
            DetailsFrame.IsVisible = false;

            BindingContext = await apiService.GetRandom();

            LoadingFrame.IsVisible = false;
            DetailsFrame.IsVisible = true;

            /*
            var activity = await apiService.GetRandom();

            ActivityLabel.Text = activity.activity;
            ParticipantsLabel.Text = activity.participants.ToString();
            PriceLabel.Text = activity.price.ToString();
            */

        }

        private async void NewButton_Clicked(object sender, EventArgs e)
        {
            await load();
        }

    }

    public class ObservableClass : INotifyPropertyChanged
    {
        string name;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            set
            {
                if (name != value)
                {
                    name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
            get
            {
                return name;
            }
        }
    }
}
