﻿using Bored.Services;
using System.Threading.Tasks;

namespace Bored.Mocks
{
    public class ApiServiceMock : IApiService
    {

        public async Task<Activity> GetRandom()
        {
            await Task.Run(() => { });


            return new Activity() {
                activity = "Go fish!",
                price = 0,
                key = "123",
                type = "",
                link = "http://missmess.se"
            };

        }

    }
}
