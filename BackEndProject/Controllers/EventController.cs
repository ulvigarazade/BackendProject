using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndProject.DAL;
using BackEndProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackEndProject.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _db;

        public EventController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            EventVM eventVM = new EventVM
            {
                Background = _db.Backgrounds.FirstOrDefault(),
                Event = _db.Events.OrderByDescending(p=>p.Id).Take(6),
                Speakers = _db.Speakers,
                EventSpeakers = _db.EventSpeakers,
                Blogs = _db.Blogs.OrderByDescending(p=>p.Id).Take(3)
            };
            return View(eventVM);
        }
    }
}
