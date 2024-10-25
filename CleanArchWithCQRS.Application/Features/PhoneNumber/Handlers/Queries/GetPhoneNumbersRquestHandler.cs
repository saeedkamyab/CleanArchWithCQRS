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
    public class GetPhoneNumbersRquestHandler : IRequestHandler<GetPhoneNumbersRequest, List<PhoneNumberDto>>
    {
        private readonly IPhoneNumberRepository _phNuRepository;
        private readonly IMapper _mapper;

        public GetPhoneNumbersRquestHandler(IPhoneNumberRepository phNuRepository,
            IMapper mapper)
        {
            _phNuRepository = phNuRepository;
            _mapper = mapper;
        }

        public async Task<List<PhoneNumberDto>> Handle(GetPhoneNumbersRequest request, CancellationToken cancellationToken)
        {
            var phoneNumberList=await _phNuRepository.GetAll();
            return _mapper.Map<List<PhoneNumberDto>>(phoneNumberList);
        }
    }
}
