using System.Text.Json.Serialization;

namespace dyte_middleware.Models
{
    public class Meeting
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }

    }
}
