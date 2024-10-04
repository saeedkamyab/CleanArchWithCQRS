using AutoMapper;
using CleanArchWithCQRS.Application.Contracts.Persistance;
using CleanArchWithCQRS.Application.Features.Student.Requests.Commands;
using CleanArchWithCQRS.Domain.Models;
using MediatR;

namespace CleanArchWithCQRS.Application.Features.Student.Handlers.Commands
{
    public class CreateStudentCommandRequestHandler :
        IRequestHandler<CreateStudentCommandRequest, Guid>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public CreateStudentCommandRequestHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateStudentCommandRequest request, CancellationToken cancellationToken)
        {
            var student = _mapper.Map<Domain.Models.Student>(request.CreateStudentDto);
            student = await _studentRepository.Add(student);
            return student.Id;
        }
    }
}
