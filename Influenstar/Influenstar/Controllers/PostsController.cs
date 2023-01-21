using Microsoft.AspNetCore.Mvc;

namespace Influenstar.Controllers
{
    public class PostsController : Controller
    {
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
    }
}
