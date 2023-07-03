using Microsoft.AspNetCore.Mvc;

namespace Student_IMS.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentList()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
