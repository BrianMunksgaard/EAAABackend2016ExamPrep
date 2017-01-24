using CodeFirst.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        /// Student zip code.
        /// </summary>
        public int ZipCode { get; set; }

        /// <summary>
        /// Student city.
        /// </summary>
        public string City { get; set; }

        [Remote("ValidateCPR", "Students")] // Client side.
        [CPRAttribute(ErrorMessage = "Please enter a valid CPR number")] // Server side.
        public string CPR { get; set; }
   
    }
}