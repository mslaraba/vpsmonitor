using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          

             ViewData["Drives"]=DriveInfo.GetDrives().Where(X=>X.IsReady).Select(X=>X.Name+" :: "+X.TotalFreeSpace).ToArray();
            return View();
        }
 
        public IActionResult Error()
        {
            return View();
        }
    }
}
