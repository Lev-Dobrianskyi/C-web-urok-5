using Microsoft.AspNetCore.Mvc;
using urok_5.Models;

namespace urok_5.Controllers
{
    public class TimeManagerController : Controller
    {
        public IActionResult TimeManager()
        {
            return View();
        }

        [HttpGet("ShowInfo")]
        public IActionResult ShowInfo(TimeManager obj)
        {
            return Content("Task: " + (String.IsNullOrEmpty(obj.Task) ? "Not provided" : obj.Task) + ", Time limit: " + (String.IsNullOrEmpty(obj.Time) ? "Not provided" : obj.Time));
        }
    }
}
