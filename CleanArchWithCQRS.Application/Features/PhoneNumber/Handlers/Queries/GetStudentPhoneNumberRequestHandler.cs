using AutoMapper;
using CleanArchWithCQRS.Application.Contracts.Persistance;
using CleanArchWithCQRS.Application.Dtos.PhoneNumberDtos;
using CleanArchWithCQRS.Application.Features.PhoneNumber.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Features.PhoneNumber.Handlers.Queries
{
    public class GetStudentPhoneNumberRequestHandler : IRequestHandler<GetStudentPhoneNumbersRequest, List<PhoneNumberDto>>
    {
        private readonly IPhoneNumberRepository _PhNuRepository;
        private readonly IMapper _mapper;

        public GetStudentPhoneNumberRequestHandler(IPhoneNumberRepository phNuRepository, IMapper mapper)
        {
            _PhNuRepository = phNuRepository;
            _mapper = mapper;
        }

        public async Task<List<PhoneNumberDto>> Handle(GetStudentPhoneNumbersRequest request, CancellationToken cancellationToken)
        {
            var phoneNumberList = await _PhNuRepository.GetAllStudentPhoneNumber(request.StudentId);
            return _mapper.Map<List<PhoneNumberDto>>(phoneNumberList);
        }
    }
}
