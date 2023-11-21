using System.ComponentModel.DataAnnotations;

namespace Student_web_Application.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public List<Attendance> Attendances { get; set; }
    }
}
