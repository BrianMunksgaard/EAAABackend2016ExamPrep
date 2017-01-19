namespace CodeFirst.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.DAL.ExamContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst.DAL.ExamContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            List<Student> students = new List<Student>
            {
                new Student
                {
                    StudentId = 1,
                    StudentName = "Brian Munksgaard",
                    StudentBirthday = new DateTime(1969, 9, 18)
                },
                new Student
                {
                    StudentId = 2,
                    StudentName = "Jens Christian Rasch",
                    StudentBirthday = new DateTime(1972, 9, 18)
                }
            };

            students.ForEach(s => context.Students.AddOrUpdate(s));
            context.SaveChanges();

            List<Course> courses = new List<Course>
            {
                new Course
                {
                    CourseId = 1,
                    CourseName = "Backend"
                },
                new Course
                {
                    CourseId = 2,
                    CourseName = "Frontend"
                },
                new Course
                {
                    CourseId = 3,
                    CourseName = "Interfacedesign"
                }
            };

            courses.ForEach(c => context.Courses.AddOrUpdate(c));
            context.SaveChanges();
        }
    }
}
