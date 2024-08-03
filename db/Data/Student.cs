using System.ComponentModel.DataAnnotations;

namespace WorkingWithDB.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentLastName { get; set; }
        public string FullName
        {
            get
            {
                return this.StudentName + " " + this.StudentLastName;
            }
        }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public ICollection<CourseRegistration> CourseRegistrations { get; set; } = new List<CourseRegistration>();
    }
}
