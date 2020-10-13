using System.Threading.Tasks;

namespace Bored.Services.Navigation
{
    public interface INavigationService
    {
        Task GoBack();
        Task GoToAbout(string about);
        Task GoToTimes();
    }
}
