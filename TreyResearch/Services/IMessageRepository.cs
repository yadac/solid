using TreyResearch.Models;

namespace TreyResearch.Services
{
    public interface IMessageRepository
    {
        IEnumerable<Message> GetRoomMessages(int roomId);
    }
}