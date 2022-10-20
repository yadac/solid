using TreyResearch.ViewModels;

namespace TreyResearch.Services
{
    public interface IRoomViewModelReader
    {
        IEnumerable<RoomListViewModel> GetAll();
    }
}