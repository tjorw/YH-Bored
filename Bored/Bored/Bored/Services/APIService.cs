using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bored.Services
{
    public class SearchResult<T>
    {
        public int total { get; set; }
        public T[] result { get; set; }
    }

    public class Activity
    {
        public string activity { get; set; }
        public decimal accessibility { get; set; }
        public string type { get; set; }
        public int participants { get; set; }
        public decimal price { get; set; }
        public string link { get; set; }
        public string key { get; set; }
    }

    public class ApiServiceMock : IApiService
    {

        public async Task<Activity> GetRandom()
        {
            await Task.Run(() => { });


            return new Activity() {
                activity = "Go fish! " + DateTime.Now.ToString(),
                price = 0,
                key = "123",
                type = "",
                link = "http://missmss.se"
            };

        }

    }

    public class ApiService : IApiService
    {


        public async Task<Activity> GetRandom()
        {
            var data = await get("https://www.boredapi.com/api/activity/");
            return JsonConvert.DeserializeObject<Activity>(data);
        }

        private async Task<string> get(string url)
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return "";

        }
    }

    public interface IApiService
    {
        Task<Activity> GetRandom();
    }

}
