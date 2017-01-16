using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    /// <summary>
    /// This class is used to hold data about a course.
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Unique course id.
        /// </summary>
        public int CourseId { get; set; }

        /// <summary>
        /// The name of the course.
        /// </summary>
        public string CourseName { get; set; }
    }
}