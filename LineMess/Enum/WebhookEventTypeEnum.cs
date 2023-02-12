namespace LineMess.Enum
{
    public class WebhookEventTypeEnum//handle 不同 event 接受時的事件    events/type(json)
    {
        public const string Message = "message";
        public const string Unsend = "unsend";
        public const string Follow = "follow";
        public const string Unfollow = "unfollow";
        public const string Join = "join";
        public const string Leave = "leave";
        public const string MemberJoined = "memberJoined";
        public const string MemberLeft = "memberLeft";
        public const string Postback = "postback";
        public const string VideoPlayComplete = "videoPlayComplete";
    }
}


//{
//    "destination": "xxxxxxxxxx",
//  "events": [                                              
//    {
//        "replyToken": "nHuyWiB7yP5Zw52FIkcQobQuGDXCTA",
//      "type": "videoPlayComplete",       <---------------------------------------this one
//      "mode": "active",
//      "timestamp": 1462629479859,
//      "source": {
//            "type": "user",
//        "userId": "U4af4980629..."
//      },
//      "webhookEventId": "01FZ74A0TDDPYRVKNK77XKC3ZR",
//      "deliveryContext": {
//            "isRedelivery": false
//      },
//      "videoPlayComplete": {
//            "trackingId": "track-id"
//      }
//    }
//  ]
//}