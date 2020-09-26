using System.Threading.Tasks;

namespace Bored.Services
{
    public interface IApiService
    {
        Task<Activity> GetRandom();
    }
}
