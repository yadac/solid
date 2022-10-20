using AutoMapper;
using TreyResearch.Models;
using TreyResearch.ViewModels;

namespace TreyResearch
{
    public static class AutoMapperConfig
    {
        static AutoMapperConfig()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Room, RoomCreateViewModel>());
        }
    }
}
