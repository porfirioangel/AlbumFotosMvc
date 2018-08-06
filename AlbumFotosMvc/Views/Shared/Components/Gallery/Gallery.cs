using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumFotosMvc.Views.Shared.Components.Gallery
{
    public class Gallery: ViewComponent
    {
        private readonly IAlbumService albumService;

        public Gallery(IAlbumService albumService)
        {
            this.albumService = albumService;
        }

        public IViewComponentResult Invoke()
        {
            return View(albumService.GetAll());
        }
    }
}
