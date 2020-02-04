using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Sally.Models
{
    public class WebhookBody
    {
        [Required, JsonPropertyName("destination")]
        public string Destination { get; set; }

        [Required, JsonPropertyName("events")]
        public IReadOnlyList<WebhookEvent> Events { get; set; }
    }
}