using System.Collections.Generic;
using Learning.Data.Enums;

namespace Learning.Data.Entities
{
    public class Tutor
    {
        public Tutor()
        {
            Courses = new List<Course>();
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }

        public ICollection<Course> Courses;
    }
}
