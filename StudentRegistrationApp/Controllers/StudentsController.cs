using StudentRegistrationApp.Models;
using System.Linq;
using System.Web.Mvc;

namespace StudentRegistrationApp.Controllers
{
	public class StudentsController : Controller
	{
		private ApplicationDbContext db = new ApplicationDbContext();

		// GET: Students/Register
		public ActionResult Register()
		{
			return View();
		}

		// POST: Students/Register
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Register(Student student)
		{
			if (ModelState.IsValid)
			{
				db.Students.Add(student);
				db.SaveChanges();
				return RedirectToAction("Success");
			}
			return View(student);
		}

		public ActionResult Index()
		{
			var students = db.Students.ToList();  // gets all students from the database
			return View(students);
		}


		public ActionResult Success()
		{
			return View();
		}
	}
}
