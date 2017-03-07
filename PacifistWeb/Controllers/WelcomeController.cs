using System.Web.Mvc;

namespace PacifistWeb.Controllers
{
    public class WelcomeController : Controller
    {
        [HttpPost]
        public JsonResult CreateUser()
        {
            return new JsonResult();
        }
    }
}