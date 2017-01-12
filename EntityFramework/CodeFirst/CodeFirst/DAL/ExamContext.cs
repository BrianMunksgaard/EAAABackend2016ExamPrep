using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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

        /// <summary>
        /// Customize model creation.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Fluent API model customization.
            /*
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Student>().ToTable("TheStudentsTable"); // Map entity to table.
            */
        }
    }

    /// <summary>
    /// Database initializer.
    /// </summary>
    public class ExamContextInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ExamContext>
    {
        /// <summary>
        /// Add information to the database.
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(ExamContext context)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    StudentName = "Brian Munksgaard"
                },
                new Student
                {
                    StudentName = "Jens Christian Rasch"
                }
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            List<Course> courses = new List<Course>
            {
                new Course
                {
                    CourseName = "Backend"
                },
                new Course
                {
                    CourseName = "Frontend"
                },
                new Course
                {
                    CourseName = "Interfacedesign"
                }
            };

            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();
        }
    }
}