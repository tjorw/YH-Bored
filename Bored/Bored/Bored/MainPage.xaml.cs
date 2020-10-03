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
            LoadingFrame.IsVisible = true;
            DetailsFrame.IsVisible = false;

            BindingContext = await apiService.GetRandom();

            LoadingFrame.IsVisible = false;
            DetailsFrame.IsVisible = true;

        }

        private async void NewButton_Clicked(object sender, EventArgs e)
        {
            await load();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoundPage());
        }
    }

    
}
