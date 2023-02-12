
//建立 Broadcast 機制,發送廣播消息
namespace LineMess.Dtos.Messages.Request
{
    public class BroadcastMessageRequestDto<T>
    {
        public string? to { get; set; }//UserID 私訊用的, 其他屬性跟廣播共用
        public List<T> Messages { get; set; } //訊息的屬性非常多種
        public bool? NotificationDisabled { get; set; }
    }
}
