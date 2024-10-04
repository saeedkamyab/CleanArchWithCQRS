using AutoMapper;
using CleanArchWithCQRS.Application.Contracts.Persistance;
using CleanArchWithCQRS.Application.Dtos.StudentDtos;
using CleanArchWithCQRS.Application.Features.Student.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Features.Student.Handlers.Queries
{
    public class GetStudentDetailRequestHandler :
        IRequestHandler<GetStudentDetailRequest, StudentDto>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public GetStudentDetailRequestHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<StudentDto> Handle(GetStudentDetailRequest request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.Get(request.Id);
            return _mapper.Map<StudentDto>(student);
        }
    }
}
