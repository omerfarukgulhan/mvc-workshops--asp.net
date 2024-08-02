using WorkingWithDB.Data;

namespace WorkingWithDB.Models
{
    public class CourseViewModel
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int TeacherId { get; set; }
        public ICollection<CourseRegistration> CourseRegistrations { get; set; } = new List<CourseRegistration>();
    }
}
