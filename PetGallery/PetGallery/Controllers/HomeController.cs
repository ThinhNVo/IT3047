using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PetGallery.Models;

namespace PetGallery.Controllers

    //Thinh Vo
{
    public class HomeController : Controller
    {
        private GalleryContext context { get; set; }

        public HomeController(GalleryContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var Gallerys = context.Cat.ToList();
            return View(Gallerys);
        }

        [Route("dogs")]
        public IActionResult Dogs()
        {
            var Gallerys = context.Dog.ToList();
            return View(Gallerys);
        }
    }
}
