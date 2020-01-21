using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Univer.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}