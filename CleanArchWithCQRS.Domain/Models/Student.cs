using CleanArchWithCQRS.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Domain.Models
{
    public class Student:BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public  string? FName { get; set; }
        public bool Status { get; set; } = true;
        public List<PhoneNumber> PhoneNumbers { get; set; } = [];
        public List<Tuition> Tuitions { get; set; } = [];
    }
}
