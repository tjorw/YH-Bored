using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bored.Services
{

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

}
