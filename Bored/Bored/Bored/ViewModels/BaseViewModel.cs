using Bored.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Bored.ViewModels
{


	//Canonical base view model
	public class BaseViewModel : INotifyPropertyChanged
	{
		protected IApiService ApiService => DependencyService.Get<IApiService>();
		protected INavigationService NavigationService => DependencyService.Get<INavigationService>();

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
	}
}

