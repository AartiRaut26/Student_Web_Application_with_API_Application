using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using Student_web_Application.Models;
using System.Diagnostics;
using Student_web_Application.Services;

namespace Student_web_Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApiService _apiService;

        public HomeController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Students()
        {
            var students = await _apiService.GetStudents();
            return View("Students", students);
        }


        public async Task<IActionResult> Classes()
        {
            var classes = await _apiService.GetClasses();
            return View("Classes", classes);
        }

        public async Task<IActionResult> Attendances()
        {
            var attendances = await _apiService.GetAttendances();
            return View("Attendances", attendances);
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