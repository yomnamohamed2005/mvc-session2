using Microsoft.AspNetCore.Mvc;

namespace mvc_session2.controllers
{
    public class accountController1 : Controller
    {
        public IActionResult login()
        {
            return View();
        }
        public IActionResult register()
        {
            return View();
        }
    }
}
