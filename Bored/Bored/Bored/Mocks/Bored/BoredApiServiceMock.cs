
using Bored.Services.Bored;
using System.Threading.Tasks;

namespace Bored.Mocks.Bored
{
    public class BoredApiServiceMock : IBoredApiService
    {

        public async Task<BoredActivityDTO> GetRandom()
        {
            await Task.Run(() => { });


            return new BoredActivityDTO() {
                activity = "Go fish!",
                price = 0,
                key = "123",
                type = "",
                link = "http://missmess.se"
            };

        }

    }
}
