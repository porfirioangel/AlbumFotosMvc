using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlbumFotosMvc.Models;
using Model.Models;
using System.IO;
using Service;

namespace AlbumFotosMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlbumService albumService;

        public HomeController(IAlbumService albumService)
        {
            this.albumService = albumService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(AlbumViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View("Create", model);
            }

            string path = $"wwwroot\\uploads\\{model.Photo.FileName}";

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                model.Photo.CopyTo(stream);
            }

            Album album = new Album
            {
                Name = model.Name,
                Description = model.Description,
                PhotoLink = $"/uploads/{model.Photo.FileName}"
            };

            albumService.Create(album);

            return RedirectToAction("Index");
        }
    }
}
