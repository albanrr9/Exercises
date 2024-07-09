using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_Ratings.Models;

namespace WebApp_Ratings.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult DrawRating(int rating)
        {
            int fullStars = rating / 10;
            int halfStars = (rating % 10 >= 5) ? 1 : 0;
            int emptyStars = 10 - fullStars - halfStars;

            string result = "";
            for (int i = 0; i < fullStars; i++)
            {
                result += "<img src=\"/images/full-star.png\" />";
            }

            for (int i = 0; i < halfStars; i++)
            {
                result += "<img src=\"/images/half-star.png\" />";
            }

            for (int i = 0; i < emptyStars; i++)
            {
                result += "<img src=\"/images/empty-star.png\" />";
            }

            ViewBag.Stars = result;
            ViewBag.Rating = rating;
            return View("Index");
        }
    }
}
