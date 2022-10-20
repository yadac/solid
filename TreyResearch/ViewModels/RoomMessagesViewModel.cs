using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using TreyResearch.Models;

namespace TreyResearch.ViewModels
{
    public class RoomMessagesViewModel
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}
