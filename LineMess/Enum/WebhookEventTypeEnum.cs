namespace LineMess.Enum
{
    public class WebhookEventTypeEnum//handle 不同 event 接受時的事件
    {       
            public const string Message = "message";
            public const string Unsend = "unsend";
            public const string Follow = "follow";
            public const string Unfollow = "unfollow";
            public const string Join = "join";
            public const string Leave = "leave";
        
    }
}
