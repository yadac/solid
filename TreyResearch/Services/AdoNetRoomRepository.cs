using System.Data.SqlClient;
using TreyResearch.Data;
using TreyResearch.Models;
using TreyResearch.ViewModels;

namespace TreyResearch.Services
{
    public class AdoNetRoomRepository : IRoomRepository
    {
        private readonly TreyResearchContext _context;
        public AdoNetRoomRepository(TreyResearchContext context)
        {
            _context = context;
        }

        public void Create(Room room)
        {
            _context.Add(room);
            // todo: async/awaitにするとcontextのdisposedエラーが発生するのでsync
            _context.SaveChanges();
        }

        public IEnumerable<Room> GetAll()
        {
            return _context.Room.ToList();
        }
    }
}
