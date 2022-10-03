using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Students = new HashSet<Student>();
        }

        public int GenderId { get; set; }
        public string? GenderName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
