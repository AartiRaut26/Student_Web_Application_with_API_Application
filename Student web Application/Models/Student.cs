using System.ComponentModel.DataAnnotations;

namespace Student_web_Application.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string StudentName { get; set; }
        public List<Attendance> Attendances { get; set; }
    }
}
