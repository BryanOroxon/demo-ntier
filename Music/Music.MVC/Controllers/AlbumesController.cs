using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Music.DAL.Repositories;
using Music.Entities;

namespace Music.MVC.Controllers
{
    public class AlbumesController : Controller
    {
        private readonly IAlbumServiceRepository _albumRepository;

        public AlbumesController(IAlbumServiceRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public IActionResult Index()
        {
            var albumes = _albumRepository.Get();
            return View(albumes);
        }
    }
}