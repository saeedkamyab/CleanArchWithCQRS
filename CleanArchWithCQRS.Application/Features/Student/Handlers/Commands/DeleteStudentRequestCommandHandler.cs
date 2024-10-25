using AutoMapper;
using CleanArchWithCQRS.Application.Contracts.Persistance;
using CleanArchWithCQRS.Application.Features.Student.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Features.Student.Handlers.Commands
{
    public class DeleteStudentRequestCommandHandler :
        IRequestHandler<DeleteStudentRequestCommand, Unit>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public DeleteStudentRequestCommandHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteStudentRequestCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.Get(request.Id);
            await _studentRepository.Delete(student);
            return Unit.Value;
        }
    }
}
