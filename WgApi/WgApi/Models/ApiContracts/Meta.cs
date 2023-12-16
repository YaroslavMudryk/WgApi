using System.Text.Json.Serialization;

namespace WgApi.Models.ApiContracts
{
    public class Meta
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("page_total")]
        public int PageCount { get; set; }
        [JsonPropertyName("total")]
        public int Total { get; set; }
        [JsonPropertyName("limit")]
        public int Limit { get; set; }
        [JsonPropertyName("page")]
        public int? Page { get; set; }
    }
}
