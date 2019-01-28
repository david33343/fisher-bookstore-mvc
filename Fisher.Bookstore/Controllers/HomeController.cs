using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World");
        }
    }

    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the About controller’s Index action");
        }

        public IActionResult History()
        {
            return Content("This is the About controller’s History action");
        }

        public IActionResult Location()
        {
            return Content("This is the About controller’s Location action");
        }
    }

    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Books controller’s Index action");
        }

        public IActionResult New()
        {
            return Content("This is the Books controller’s New action");
        }

        public IActionResult Best()
        {
            return Content("This is the Books controller’s Best action");
        }
    }

    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Authors controller’s Index action");
        }

        public IActionResult Featured()
        {
            return Content("This is the Authors controller’s Featured action");
        }
    }
}