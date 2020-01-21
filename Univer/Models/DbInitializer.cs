using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Univer.Models
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<UniverContext>
    {
        protected override void Seed(UniverContext db)
        {
            db.Courses.Add(new Course { CourseId = 4, Specialization = "Automation" });
            db.Courses.Add(new Course { CourseId = 3, Specialization = "Nuclear Engineering" });
            db.Courses.Add(new Course { CourseId = 2, Specialization = "Software Engineering" });
            db.Courses.Add(new Course { CourseId = 1, Specialization = "Managment" });

            db.Groups.Add(new Group { GroupId = 4, CourseId = 4, Name = "ET-91" });
            db.Groups.Add(new Group { GroupId = 3, CourseId = 3, Name = "LA-81" });
            db.Groups.Add(new Group { GroupId = 2, CourseId = 2, Name = "AR-71" });
            db.Groups.Add(new Group { GroupId = 1, CourseId = 1, Name = "TM-61" });

            db.Students.Add(new Student { StudentId = 1, FirstName = "Имя1", LastName = "Фамилия1", GroupId = 1, CourseId = 1 });
            db.Students.Add(new Student { StudentId = 2, FirstName = "Имя2", LastName = "Фамилия2", GroupId = 1, CourseId = 1 });
            db.Students.Add(new Student { StudentId = 3, FirstName = "Имя3", LastName = "Фамилия3", GroupId = 2, CourseId = 2 });
            db.Students.Add(new Student { StudentId = 4, FirstName = "Имя4", LastName = "Фамилия4", GroupId = 2, CourseId = 2 });
            db.Students.Add(new Student { StudentId = 5, FirstName = "Имя5", LastName = "Фамилия5", GroupId = 3, CourseId = 3 });
            db.Students.Add(new Student { StudentId = 6, FirstName = "Имя6", LastName = "Фамилия6", GroupId = 3, CourseId = 3 });

            base.Seed(db);
        }
    }
}