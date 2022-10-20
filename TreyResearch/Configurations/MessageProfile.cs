using AutoMapper;
using TreyResearch.Models;
using TreyResearch.ViewModels;

namespace TreyResearch.Configurations
{
    public class MessageProfile : Profile
    {
        public MessageProfile()
        {
            CreateMap<Message, RoomMessagesViewModel>()
                .ForMember(dst => dst.Comment, src => src.MapFrom(s => s.Comment + "_create"))
                .ReverseMap();
        }
    }
}
