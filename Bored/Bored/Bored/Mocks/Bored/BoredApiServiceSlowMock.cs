
using Bored.Services.Bored;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Bored.Mocks.Bored
{
    public class BoredApiServiceSlowMock : IBoredApiService
    {

        public async Task<BoredActivityDTO> GetRandom()
        {
            await Task.Run(() => { Thread.Sleep(5000); });

            var key = Guid.NewGuid().ToString();


            return new BoredActivityDTO()
            {
                activity = key,
                price = 1,
                participants = 1,
                key = key,
                type = "",
                link = "http://missmess.se"
            };

        }

    }
}
