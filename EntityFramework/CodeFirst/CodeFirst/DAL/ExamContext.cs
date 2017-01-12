using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.DAL
{
    /// <summary>
    /// Database context for the application.
    /// </summary>
    public class ExamContext : DbContext
    {
        /// <summary>
        /// Context constructor.
        /// </summary>
        public ExamContext() : base("ExamContext") { } // ExamContext in web.config.

        /// <summary>
        /// Students data.
        /// </summary>
        public DbSet<Student> Students { get; set; }
        
        /// <summary>
        /// Courses data.
        /// </summary>
        public DbSet<Course> Courses { get; set; }
    }
}