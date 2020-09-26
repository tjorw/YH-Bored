using Bored.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bored
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        AboutPageViewModel viewModel;

        public AboutPage()
        {

            InitializeComponent();
            BindingContext = viewModel = new AboutPageViewModel();
        }
    }
}