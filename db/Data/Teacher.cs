using System.ComponentModel.DataAnnotations;

namespace WorkingWithDB.Data
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherLastName { get; set; }
        public string FullName
        {
            get
            {
                return this.TeacherName + " " + this.TeacherLastName;
            }
        }
        public string Email { get; set; }
        public string Telephone { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        public DateTime StartingDate { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
