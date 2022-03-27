using CallingAPI_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace CallingAPI_MVC.Controllers
{
    public class TipsNepalController : Controller
    {
        public IActionResult Index(int id)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string json = (new WebClient()).DownloadString("https://www.tipsnepal.com/wp-json/wp/v2/posts");
            var TipsNepalResult = JsonConvert.DeserializeObject(json, typeof(List<TipsNepal>)) as List<TipsNepal>;

            return View(TipsNepalResult);
        }
    }
}
