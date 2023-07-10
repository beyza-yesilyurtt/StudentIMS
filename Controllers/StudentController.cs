using Microsoft.AspNetCore.Mvc;
using Student_IMS.Data;
using Student_IMS.Models;

namespace Student_IMS.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _db;

        public StudentController(StudentDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentList()
        {
            List<Student> studentList = _db.Students.ToList();


            return View(studentList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student obj)
        {
            if(obj.Name==obj.Surname)
            {
                ModelState.AddModelError("Name" , "Name and surname must be different!");
            }

            if(ModelState.IsValid)
            {
                _db.Students.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "New record added successfully";
                return RedirectToAction("StudentList", "Student");
            }
            return View();
          
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
