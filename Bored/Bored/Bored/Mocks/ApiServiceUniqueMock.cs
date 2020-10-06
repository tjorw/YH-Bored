using Bored.Services;
using System;
using System.Threading.Tasks;

namespace Bored.Mocks
{
    public class ApiServiceUniqueMock : IApiService
    {

        public async Task<Activity> GetRandom()
        {
            await Task.Run(() => { });

            var key = Guid.NewGuid().ToString();

            return new Activity()
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
