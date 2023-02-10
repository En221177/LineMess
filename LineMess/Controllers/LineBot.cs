using LineMess.Domain;
using LineMess.Dtos.Webhook;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LineMess.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LineBot : ControllerBase
    {

        private readonly string channelAccessToken = "CiB9XbeXDnIXgfN8u7zbtIFGkaxP+VXghErm0tE/bntZJ6M9VZrIKvxUoLT2/38sLsDIXthopd+NwlcX/DT+LJKuOMUp9TJ/VlqVlcrsWjp1cjwFDzaL/2KcN3b+vNRgnP83LrM+iA6QYkFt/VqKiAdB04t89/1O/w1cDnyilFU=";
        private readonly string channelSecret = "dd0a693282da9bd4a90aa2c837787648";

        private readonly LineBotService _lineBotService;
        public LineBot()
        {
            _lineBotService = new LineBotService();
        }


        [HttpPost("Webhook")]
        public IActionResult Webhook(WebhookRequestBodyDto body)
        {
            _lineBotService.ReceiveWebhook(body);
            return Ok();
        }
    }
}
