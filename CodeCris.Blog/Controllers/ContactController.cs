using Microsoft.AspNetCore.Mvc;

namespace CodeCris.Blog.Controllers
{
    public class ContactController : Controller
    {
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}