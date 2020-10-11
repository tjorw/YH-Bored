using Bored.Services;
using Bored.ViewModels;
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
        MainPageViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new MainPageViewModel();
            viewModel.SelectFromHistoryCommand.CanExecuteChanged += SelectFromHistoryCommand_CanExecuteChanged;
        }

        private void SelectFromHistoryCommand_CanExecuteChanged(object sender, EventArgs e)
        {
            Console.WriteLine("This is just catching the event when SelectFromHistoryCommand raises CanExecuteChanged");
            Console.WriteLine("You could make stuff happen in the UI here.");
            Console.WriteLine("Just for demo.");

            HistoryView.BackgroundColor = viewModel.SelectFromHistoryCommand.CanExecute(null) ? Color.LightBlue : Color.LightGray;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if(viewModel.History.Count == 0)
            {
                await viewModel.Load();
            }
        }

        private void HistoryView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var activity = e.Item as Activity;
            var listView = sender as ListView;

            if(activity != null)
            {
                viewModel.SelectFromHistoryCommand.Execute(activity);
                listView.SelectedItem = null;
            }
        }
    }
}
