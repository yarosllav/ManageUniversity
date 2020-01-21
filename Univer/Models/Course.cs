using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Univer.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Specialization { get; set; }
        public virtual ICollection<Group> Courses { get; set; }
    }
}