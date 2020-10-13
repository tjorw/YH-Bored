using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bored.Services.Times
{
    public class TimesMediumDTO
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("approved_for_syndication")]
        public int ApprovedForSyndication { get; set; }

        [JsonProperty("media-metadata")]
        public IList<TimesMediaMetadataDTO> MediaMetadata { get; set; }
    }
}

