using System.Collections.Generic;

namespace Learning.Data.Entities
{
    public class Subject
    {
        public Subject()
        {
            Courses = new List<Course>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses;
    }
}
