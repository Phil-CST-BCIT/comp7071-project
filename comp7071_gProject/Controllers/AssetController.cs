using Microsoft.AspNetCore.Mvc;

namespace comp7071_gProject.Controllers
{
    public class AssetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
