using Bored.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bored.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimesPage : ContentPage
    {
        TimesPageViewModel viewModel;


        public TimesPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new TimesPageViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await viewModel.Load();

        }

    }
}