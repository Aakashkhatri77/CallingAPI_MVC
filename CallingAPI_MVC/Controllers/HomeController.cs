using CallingAPI_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CallingAPI_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public async Task<IActionResult> Index()
        {
            var URL = "https://www.tipsnepal.com/wp-json/zooktirest/v2/posts/3/1";
            var httpClient = new HttpClient();
            var response = await httpClient.GetFromJsonAsync<List<Post>>(URL);
            return View(response);
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
    }
}