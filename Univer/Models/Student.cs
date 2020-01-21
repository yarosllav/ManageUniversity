using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Univer.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
        public int CourseId { get; set; }
        public virtual Group Group { get; set; }
    }
}