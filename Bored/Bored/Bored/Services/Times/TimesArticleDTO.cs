using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bored.Services.Times
{
    public class TimesArticleDTO
    {

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("asset_id")]
        public object AssetId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("subsection")]
        public string Subsection { get; set; }

        [JsonProperty("nytdsection")]
        public string Nytdsection { get; set; }

        [JsonProperty("adx_keywords")]
        public string AdxKeywords { get; set; }

        [JsonProperty("column")]
        public object Column { get; set; }

        [JsonProperty("byline")]
        public string Byline { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        [JsonProperty("des_facet")]
        public IList<string> DesFacet { get; set; }

        [JsonProperty("org_facet")]
        public IList<string> OrgFacet { get; set; }

        [JsonProperty("per_facet")]
        public IList<string> PerFacet { get; set; }

        [JsonProperty("geo_facet")]
        public IList<string> GeoFacet { get; set; }

        [JsonProperty("media")]
        public IList<TimesMediumDTO> Media { get; set; }

        [JsonProperty("eta_id")]
        public int EtaId { get; set; }
    }
}

