using Microsoft.AspNetCore.Mvc;
using Student_web_Application.Services;
using System.Threading.Tasks;

using Student_web_Application.Models;
using System.Diagnostics;

namespace Student_web_Application.Controllers
{

    public class ClassController : Controller
    {
        private readonly ApiService _apiService;

        public ClassController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> GetClasses()
        {
            var classes = await _apiService.GetClasses();
            return View(classes);
        }
    }
}
