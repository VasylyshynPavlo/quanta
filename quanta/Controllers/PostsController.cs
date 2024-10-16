using Microsoft.AspNetCore.Mvc;

namespace quanta.Controllers
{
    public class PostsController : Controller
    {
        // GET: PostsController
        public ActionResult Index()
        {
            return View();
        }

    }
}
