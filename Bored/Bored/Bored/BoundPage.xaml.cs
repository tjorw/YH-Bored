using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bored
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BoundPage : ContentPage
    {
        ObservableClass SomethingObservable = new ObservableClass();

        public BoundPage()
        {
            InitializeComponent();
            BindingContext = SomethingObservable = new ObservableClass();

            SomethingObservable.PropertyChanged += SomethingObservable_PropertyChanged;
        }

        private void SomethingObservable_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var value = sender.GetType().GetProperty(e.PropertyName).GetValue(sender);
            Console.WriteLine($"{e.PropertyName} Changed to {value}");
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