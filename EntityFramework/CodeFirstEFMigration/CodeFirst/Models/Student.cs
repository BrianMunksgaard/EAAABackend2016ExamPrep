using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    /// <summary>
    /// This class is used to represent a student. In database the name will
    /// be pluralized by convention so the table name is Students.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Unique student id.
        /// </summary>
        //[Key] // Annotate as key if needed.
        //[DatabaseGenerated(DatabaseGeneratedOption.None) // Avoid auto generated key if needed.
        public int StudentId { get; set; } // Automatically recognized as primary key (Id or classnameId).

        /// <summary>
        /// The name of the student.
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// Student birthday.
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime StudentBirthday { get; set; }
    }
}