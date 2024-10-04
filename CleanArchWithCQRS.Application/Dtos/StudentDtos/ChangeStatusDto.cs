using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Dtos.StudentDtos
{
    public class ChangeStatusDto:BaseDto
    {
        public bool Status { get; set; } = true;
    }
}
