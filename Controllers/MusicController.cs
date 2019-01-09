using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApplication.Models;
using FirstApplication.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FirstApplication.Controllers
{
    public class MusicController : Controller
    {

        private readonly IBandRepository _bandRepository;

        public MusicController (IBandRepository repository)
        {
            _bandRepository = repository;
        }
        // GET: Music
        public ActionResult Index()
        {
            return View(_bandRepository.GetBands());
        }

        // GET: Music/Details/5
        public ActionResult Details(int id)
        {
            var band = new Band()
            {
                Title = "Scorpions",
                Biography = "Banda veia da porra",
                Genre = "Rock",
                Origin = "USA"
            };

            return View(band);
        }

        // GET: Music/Details/5
        public JsonResult TestGetBand(int id)
        {
            var band = new Band()
            {
                Title = "New Band",
                Biography = "Banda veia da porra",
                Genre = "Rock",
                Origin = "USA"
            };

            return Json(JsonConvert.SerializeObject(band));
        }

        // GET: Music/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Music/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Band band)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Console.Write("hello");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Music/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Music/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Music/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Music/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}