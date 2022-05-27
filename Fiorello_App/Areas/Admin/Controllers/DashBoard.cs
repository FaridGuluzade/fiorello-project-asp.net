using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello_App.Areas.Admin.Controllers
{
    public class DashBoard : Controller
    {
        // GET: DashBoard
        public IActionResult Index()
        {
            return View();
        }

 
    }
}
