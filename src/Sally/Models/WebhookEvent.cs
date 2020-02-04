using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sally.Models
{
    public class WebhookEvent
    {
        [Required, JsonPropertyName("type")]
        public string EventType { get; set; }
        
        [Required, JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }
        
        [Required, JsonPropertyName("source")]
        public JsonElement Source { get; set; }
        
        [JsonExtensionData]
        public IDictionary<string, JsonElement> Payload { get; set; }
    }
}