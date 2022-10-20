using TreyResearch.Models;
using TreyResearch.ViewModels;

namespace TreyResearch.Services
{
    public interface IRoomRepository
    {
        void Create(Room room);
        IEnumerable<Room> GetAll();
    }
}