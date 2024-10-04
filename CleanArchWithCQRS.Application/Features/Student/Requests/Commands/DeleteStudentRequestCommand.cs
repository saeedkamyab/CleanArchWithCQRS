using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Features.Student.Requests.Commands
{
    public class DeleteStudentRequestCommand:IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
