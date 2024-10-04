using CleanArchWithCQRS.Application.Dtos.StudentDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Features.Student.Requests.Queries
{
    public class GetAllStudentsRequest:IRequest<List<StudentDto>>
    {
    }
}
