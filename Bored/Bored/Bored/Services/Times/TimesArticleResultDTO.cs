using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bored.Services.Times
{
    public class TimesArticleResultDTO
    {

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("results")]
        public IList<TimesArticleDTO> Results { get; set; }
    }
}

