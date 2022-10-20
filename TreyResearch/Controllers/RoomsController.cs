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
        private readonly IRoomViewModelReader _reader;
        private readonly IRoomViewModelWriter _writer;

        public RoomsController(IRoomViewModelReader reader, IRoomViewModelWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            return View(new RoomCreateViewModel());
        }

        // GET: Rooms/Create
        public IActionResult List()
        {
            return View(_reader.GetAll());
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
                _writer.Create(model);
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
