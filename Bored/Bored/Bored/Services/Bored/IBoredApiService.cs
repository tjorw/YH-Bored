using System.Threading.Tasks;

namespace Bored.Services.Bored
{
    public interface IBoredApiService
    {
        Task<BoredActivityDTO> GetRandom();
    }
}
