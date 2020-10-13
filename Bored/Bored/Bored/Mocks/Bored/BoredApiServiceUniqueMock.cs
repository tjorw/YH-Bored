using Bored.Services.Bored;
using System;
using System.Threading.Tasks;

namespace Bored.Mocks.Bored
{
    public class BoredApiServiceUniqueMock : IBoredApiService
    {

        public async Task<BoredActivityDTO> GetRandom()
        {
            await Task.Run(() => { });

            var key = Guid.NewGuid().ToString();

            return new BoredActivityDTO()
            {
                activity = key,
                price = 0,
                key = key,
                type = "",
                link = "http://missmess.se"
            };

        }

    }
}
