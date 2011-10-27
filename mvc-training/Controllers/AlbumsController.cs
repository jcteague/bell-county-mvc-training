using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTraining.Models;
using MvcTraining.Services;
using mvc_training.Domain;

namespace MvcTraining.Controllers
{
    public class AlbumsController : Controller
    {
        //
        // GET: /Albums/
        public IRepository<Album> albumRepository;
        public AlbumsController()
        {
            albumRepository = new AlbumRepository();
        }
        public ActionResult Index()
        {
            var model = albumRepository.Get().Select(a => new AlbumView {Name = a.Name, ArtistName = a.Artist.Name});
            return View(model);
        }

    }
}
