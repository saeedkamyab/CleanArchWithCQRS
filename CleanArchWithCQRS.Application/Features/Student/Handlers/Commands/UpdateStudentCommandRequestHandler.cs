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
    public class UpdateStudentCommandRequestHandler :
        IRequestHandler<UpdateStudentCommandRequest, Unit>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public UpdateStudentCommandRequestHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateStudentCommandRequest request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.Get(request.Id);
            if (request.UpdateStudentDto != null)
            {
                _mapper.Map(request.UpdateStudentDto, student);
                await _studentRepository.Update(student);
            }
            else if (request.ChangeStatusDto != null)
            {
               await _studentRepository.ChangeStatus(student);
            }


            return Unit.Value;
        }
    }
}
