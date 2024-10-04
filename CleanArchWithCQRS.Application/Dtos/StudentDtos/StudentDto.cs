using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Dtos.StudentDtos
{
    public class StudentDto:BaseDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FName { get; set; }
        public bool Status { get; set; } = true;

    }
}
