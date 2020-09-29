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


            return new Activity()
            {
                activity = "Go fish! " + DateTime.Now.ToString(),
                price = 1,
                participants = 1,
                key = "123",
                type = "",
                link = "http://missmess.se"
            };

        }

    }
}
