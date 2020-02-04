using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sally.Models;

namespace Sally.Controllers
{
    [ApiController]
    [Route("channels/{channelId:int}")]
    public class WebhookController : ControllerBase
    {
        private readonly ILogger _logger;

        public WebhookController(ILogger<WebhookController> logger)
        {
            _logger = logger;
        }

        [HttpPost("webhook")]
        public void Post(int channelId, [FromBody] WebhookBody body)
        {
            _logger.LogInformation("Channel {0} received {1} events for {2}",
                channelId, body.Events.Count, body.Destination);
        }
    }
}
