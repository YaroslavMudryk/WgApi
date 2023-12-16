using System.Text.Json.Serialization;

namespace WgApi.Models.ApiContracts
{
    public class Response
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class Response<TData> : Response
    {
        [JsonPropertyName("data")]
        public TData Data { get; set; }
    }
}
