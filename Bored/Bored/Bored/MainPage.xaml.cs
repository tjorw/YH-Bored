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

        public MainPage()
        {
            InitializeComponent();
            apiService = DependencyService.Get<IApiService>();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await load();
        }

        private async Task load()
        {
            var activity = await apiService.GetRandom();

            ActivityLabel.Text = activity.activity;
            ParticipantsLabel.Text = activity.participants.ToString();
            PriceLabel.Text = activity.price.ToString();

        }

        private async void NewButton_Clicked(object sender, EventArgs e)
        {
            await load();
        }
    }
}
