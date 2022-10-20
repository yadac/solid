using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TreyResearch.Data;
using TreyResearch.Models;
using TreyResearch.Services;
using TreyResearch.ViewModels;

namespace TreyResearch.Controllers
{
    public class RoomsController : Controller
    {
        // todo: delete
        // private readonly TreyResearchContext _context;
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;

        public RoomsController(IRoomRepository roomRepository, IMapper mapper)
        {
            // _context = context;
            _roomRepository = roomRepository;
            _mapper = mapper;
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            return View(new RoomCreateViewModel());
        }

        // GET: Rooms/Create
        public IActionResult List()
        {
            var rooms = _roomRepository.GetAll();
            var roomLists = new List<RoomListViewModel>();
            foreach (var room in rooms)
            {
                roomLists.Add(_mapper.Map<RoomListViewModel>(room));
            }
            return View(roomLists);
        }

        // POST: Rooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RoomCreateViewModel model)
        {
            ActionResult result;
            if (ModelState.IsValid)
            {
                // viewmodelに変換
                var room = new Room { Name = model.Name };
                _roomRepository.Create(room);
                result = RedirectToAction("List");
            }
            else
            {
                result = View("Create", model);
            }
            return result;
        }

        //private bool RoomExists(int id)
        //{
        //  return _context.Room.Any(e => e.Id == id);
        //}
    }
}
