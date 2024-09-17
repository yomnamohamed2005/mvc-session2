using Microsoft.AspNetCore.Mvc;

namespace mvc_session2.NewFolder
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            // return $"yomna ={id}";
            return View();
        }
        public IActionResult aboutus(int id)
        {
            // return $"yomna ={id}";
            return View();
        }
        public IActionResult contactus(int id)
        {
            // return $"yomna ={id}";
            return View();
        }
    }
}
