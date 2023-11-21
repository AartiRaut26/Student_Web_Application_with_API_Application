using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Student_web_Application.Models;

namespace Student_web_Application.Services
{

    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _httpClient.BaseAddress = new Uri(configuration["ApiBaseUrl"]);

        }

        public async Task<List<Student>> GetStudents()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Student>>("http://localhost:5019/api/students");
            return response;
        }

        public async Task<List<Class>> GetClasses()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Class>>("http://localhost:5019/api/classes");
            return response;
        }

        public async Task<List<Attendance>> GetAttendances()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Attendance>>("http://localhost:5019/api/attendances"); return response;
        }





        // Implement similar methods for other endpoints (GetClasses, GetAttendances, etc.)
    }
}
