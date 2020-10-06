using Bored.Services;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Bored.Mocks
{
    public class ApiServiceSlowMock : IApiService
    {

        public async Task<Activity> GetRandom()
        {
            await Task.Run(() => { Thread.Sleep(5000); });

            var key = Guid.NewGuid().ToString();


            return new Activity()
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
