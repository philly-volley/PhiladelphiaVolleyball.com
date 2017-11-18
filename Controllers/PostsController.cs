using Microsoft.AspNetCore.Mvc;

namespace PhiladelphiaVolleyball.com.Controllers
{
    public class PostsController : Controller
    {
		// GET: /<controller>/
        public IActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return RedirectToRoute("Home");
            else
                return Redirect("//opensports.net/posts/" + id);
        }
    }
}
