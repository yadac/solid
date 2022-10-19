using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TreyResearch.Models;
using TreyResearch.Services;

namespace TreyResearch.Controllers
{
    public class RoomController : Controller
    {
        private readonly ILogger<RoomController> _logger;
        private readonly IRoomRepository _roomRepository;

        public RoomController(ILogger<RoomController> logger, IRoomRepository roomService)
        {
            _logger = logger;
            _roomRepository = roomService;
        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateRoomViewModel());
        }

        [HttpPost]
        public ActionResult Create(CreateRoomViewModel model)
        {
            ActionResult result;
            if (ModelState.IsValid)
            {
                _roomRepository.CreateRoom(model.NewRoomName);
                result = RedirectToAction("List");
            }
            else
            {
                result = View("Create", model);
            }
            return result;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}