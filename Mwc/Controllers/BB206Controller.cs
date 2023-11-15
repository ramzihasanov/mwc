using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class BB206Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public JsonResult JsonResult()
        {
            return new JsonResult("age : 19 ");
        }


        public ContentResult Content()
        {
            return Content("Hello World");
        }

        

        


       
    }
}
