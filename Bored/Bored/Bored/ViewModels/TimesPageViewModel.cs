using Bored.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bored.ViewModels
{
    public class TimesPageViewModel : BasePageViewModel
    {
        private bool isBusy = false;
        public ObservableCollection<ArticleModel> Articles { get; } = new ObservableCollection<ArticleModel>();

        public ICommand LoadCommand { get; }

        public TimesPageViewModel()
        {
            LoadCommand = new Command(async () => await Load(), () => !IsBusy);
        }


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
                }
            }
        }


        public async Task Load()
        {

            try
            {
                IsBusy = true;
                var response = await TimesApiService.GetArticles();

                Articles.Clear();
                foreach (var article in response.ToArticles())
                {
                    Articles.Add(article);
                }


            }
            catch { }
            finally
            {
                IsBusy = false;
            }


        }


    }
}
