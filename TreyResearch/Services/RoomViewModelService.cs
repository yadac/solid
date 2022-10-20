using AutoMapper;
using TreyResearch.Models;
using TreyResearch.ViewModels;

namespace TreyResearch.Services
{
    /// <summary>
    /// Controller⇔Infraの橋渡し
    /// </summary>
    public class RoomViewModelService : 
        IRoomViewModelReader, IRoomViewModelWriter
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMessageRepository _messageRepository;
        private readonly IMapper _mapper;
        public RoomViewModelService(
            IRoomRepository roomRepository, 
            IMessageRepository messageRepository,
            IMapper mapper)
        {
            _roomRepository = roomRepository;
            _messageRepository = messageRepository;
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

        public IEnumerable<RoomMessagesViewModel> GetRoomMessages(int roomId)
        {
            var messages = _messageRepository.GetRoomMessages(roomId);
            return _mapper.Map<List<RoomMessagesViewModel>>(messages);
        }
    }
}
