using CallingAPI_MVC.Models;
using CommandLine.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace CallingAPI_MVC.Controllers
{
    public class BlogController : Controller
    {
  
        public IActionResult Index()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string json = (new WebClient()).DownloadString("https://www.nepalinames.com/blog/wp-json/zooktirest/v2/posts/search/?s=a");
            var blogResult = JsonConvert.DeserializeObject(json, typeof(List<Blog>)) as List<Blog>;


            return View(blogResult);
        }
















        public IActionResult Details(int id)
        {
            return View();
        }


    }
}
