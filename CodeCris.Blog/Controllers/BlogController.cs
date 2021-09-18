using CodeCris.Blog.Models.Blog;
using Microsoft.AspNetCore.Mvc;

namespace CodeCris.Blog.Controllers
{
    public class BlogController : Controller
    {
        [Route("{slug}")]
        public IActionResult Article(string slug)
        {
            return View(new ArticleViewModel
            {
                Title = slug,
                Content = "Test Content"
            });
        }
    }
}