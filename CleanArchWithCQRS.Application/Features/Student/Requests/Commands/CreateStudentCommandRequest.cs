using CleanArchWithCQRS.Application.Dtos.StudentDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Features.Student.Requests.Commands
{
    public class CreateStudentCommandRequest:IRequest<Guid>
    {
        public CreateStudent? CreateStudentDto {get; set; }
    }
}
