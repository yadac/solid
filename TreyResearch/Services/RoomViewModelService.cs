using AutoMapper;
using TreyResearch.Models;
using TreyResearch.ViewModels;

namespace TreyResearch.Services
{
    /// <summary>
    /// Controller⇔Infraの橋渡し
    /// </summary>
    public class RoomViewModelService : IRoomViewModelReader, IRoomViewModelWriter
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;
        public RoomViewModelService(IRoomRepository roomRepository, IMapper mapper)
        {
            _roomRepository = roomRepository;
            _mapper = mapper;
        }

        public IEnumerable<RoomListViewModel> GetAll()
        {
            var rooms = _roomRepository.GetAll();
            return _mapper.Map<List<RoomListViewModel>>(rooms);
        }

        public void Create(RoomCreateViewModel model)
        {
            var room = _mapper.Map<Room>(model);
            _roomRepository.Create(room);
        }

    }
}
