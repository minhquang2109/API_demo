using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Dob { get; set; }
        public int? GenderId { get; set; }
        public DateTime? Registration { get; set; }
        public int? Status { get; set; }

        public virtual Gender? Gender { get; set; }
    }
}
