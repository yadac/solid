using AutoMapper;
using TreyResearch.Models;
using TreyResearch.ViewModels;

namespace TreyResearch.Configurations
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<Room, RoomCreateViewModel>()
                .ForMember(dst => dst.Name, src => src.MapFrom(s => s.Name + "_create"))
                .ReverseMap();
            CreateMap<Room, RoomListViewModel>()
                .ForMember(dst => dst.DisplayName, src => src.MapFrom(s => s.Name + "_display"))
                .ReverseMap();
        }
    }
}
