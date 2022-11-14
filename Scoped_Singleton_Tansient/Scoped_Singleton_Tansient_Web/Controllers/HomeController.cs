using Microsoft.AspNetCore.Mvc;
using Scoped_Singleton_Tansient_Web.Models;
using Scoped_Singleton_Tansient_Web.Repository.IRepository;
using System.Diagnostics;

namespace Scoped_Singleton_Tansient_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingletonStudentRepository _singletonStudentRepo;
        private readonly IScopedStudentRepository _scopedStudentRepo;
        private readonly ITransientStudentRepository _transientStudentRepo;

        public HomeController(ILogger<HomeController> logger,
            ISingletonStudentRepository singletonStudentRepo,
            IScopedStudentRepository scopedStudentRepo,
            ITransientStudentRepository transientStudentRepo)
        {
            _logger = logger;
            _singletonStudentRepo = singletonStudentRepo;
            _scopedStudentRepo = scopedStudentRepo;
            _transientStudentRepo = transientStudentRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public IActionResult Index_POST(Student student)
        {
            if (ModelState.IsValid)
            {
                _singletonStudentRepo.AddStudent(student);
                _scopedStudentRepo.AddStudent(student);
                _transientStudentRepo.AddStudent(student);
            }
            return View(student);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}