using System;
using LineMess.Dtos;
using LineMess.Dtos.Webhook;
using LineMess.Enum;

namespace LineMess.Domain
{
    public class LineBotService 
    {
        private readonly string channelAccessToken = "CiB9XbeXDnIXgfN8u7zbtIFGkaxP+VXghErm0tE/bntZJ6M9VZrIKvxUoLT2/38sLsDIXthopd+NwlcX/DT+LJKuOMUp9TJ/VlqVlcrsWjp1cjwFDzaL/2KcN3b+vNRgnP83LrM+iA6QYkFt/VqKiAdB04t89/1O/w1cDnyilFU=";
        private readonly string channelSecret = "dd0a693282da9bd4a90aa2c837787648";

        public LineBotService()
        {
        }

        public void ReceiveWebhook(WebhookRequestBodyDto requestBody)
        {
            foreach (var eventObject in requestBody.Events)
            {
                switch (eventObject.Type)
                {
                    case WebhookEventTypeEnum.Message:
                        Console.WriteLine("收到使用者傳送訊息！");
                        Console.WriteLine(eventObject.Message.Text);
                        break;
                    case WebhookEventTypeEnum.Unsend:
                        Console.WriteLine($"使用者{eventObject.Source.UserId}在聊天室收回訊息！");
                        break;
                    case WebhookEventTypeEnum.Follow:
                        Console.WriteLine($"使用者{eventObject.Source.UserId}將我們新增為好友！");
                        break;
                    case WebhookEventTypeEnum.Unfollow:
                        Console.WriteLine($"使用者{eventObject.Source.UserId}封鎖了我們！");
                        break;
                    case WebhookEventTypeEnum.Join:
                        Console.WriteLine("我們被邀請進入聊天室了！");
                        break;
                    case WebhookEventTypeEnum.Leave:
                        Console.WriteLine("我們被聊天室踢出了");
                        break;
                }
            }
        }
    }
}
