using System.Data.SqlClient;
using TreyResearch.Data;
using TreyResearch.Models;
using TreyResearch.ViewModels;

namespace TreyResearch.Services
{
    public class AdoNetMessageRepository : IMessageRepository
    {
        private readonly TreyResearchContext _context;
        public AdoNetMessageRepository(TreyResearchContext context)
        {
            _context = context;
        }

        public IEnumerable<Message> GetRoomMessages(int roomId)
        {
            return _context.Message.Where(m => m.RoomId == roomId).ToList();
        }
    }
}
