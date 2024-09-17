using Microsoft.AspNetCore.Mvc;

namespace mvc_session2.controllers
{
    public class productsController : Controller
    {
        public IActionResult Get(int id,product product)
        {
            //ContentResult contentresult = new ContentResult();
            //contentresult.Content = $"number ={id}";
           // contentresult.ContentType = "object/pdf";
           // contentresult.StatusCode = 200;
            return Content($"number ={id}");
        }
        public IActionResult Redirect()
        {
            // RedirectResult redirectresult = new RedirectResult("https://www.google.com");
            //return redirectresult;
            return Redirect("https://www.google.com");
        }
        public IActionResult RedirectToaction()
        {
            // RedirectToActionResult redirectaction = new RedirectToActionResult("Get", "products", new {id=90});
            //return RedirectToAction("Get", "products", new {id=77});
            return RedirectToAction(nameof(Get));

        }

    }
}
