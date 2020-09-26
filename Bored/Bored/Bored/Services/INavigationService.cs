using System.Threading.Tasks;

namespace Bored.Services
{
    public interface INavigationService
    {
        Task GoBack();
        Task GoToAbout();
    }
}

