using System;

namespace KuasCore.Models
{
    public class Course
    {
        public string CourseId { get; set; }

        public string CourseName { get; set; }

        public string CourseDescription { get; set; }

        public override string ToString()
        {
            return "Course: Id = " + CourseId + ", Name = " + CourseName + ", Description = " + CourseDescription + ".";
        }

    }
}
