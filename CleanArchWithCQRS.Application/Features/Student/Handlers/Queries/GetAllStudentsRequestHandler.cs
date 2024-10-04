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
    public class GetAllStudentsRequestHandler :
        IRequestHandler<GetAllStudentsRequest, List<StudentDto>>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public GetAllStudentsRequestHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<List<StudentDto>> Handle(GetAllStudentsRequest request, CancellationToken cancellationToken)
        {
            var studentList = await _studentRepository.GetAll();
            return _mapper.Map<List<StudentDto>>(studentList);
        }
    }
}
