using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bored.Services.Bored
{

    public class BoredApiService : IBoredApiService
    {

        public async Task<BoredActivityDTO> GetRandom()
        {
            return await get<BoredActivityDTO>("https://www.boredapi.com/api/activity/");
        }

        private async Task<T> get<T>(string url)
        {
            var data = await get(url);
            return JsonConvert.DeserializeObject<T>(data);
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
