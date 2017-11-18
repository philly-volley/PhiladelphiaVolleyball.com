using Microsoft.AspNetCore.Mvc;

namespace PhiladelphiaVolleyball.com.Controllers
{
    public class EventsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string id)
		{
			return Redirect("//meetup.com/PhiladelphiaVolleyball/events/" + id);
        }
    }
}
