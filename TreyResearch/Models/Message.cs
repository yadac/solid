namespace TreyResearch.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string Comment { get; set; } = String.Empty;
    }
}
