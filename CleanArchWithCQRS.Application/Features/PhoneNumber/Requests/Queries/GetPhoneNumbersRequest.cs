using CleanArchWithCQRS.Application.Dtos.PhoneNumberDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Features.PhoneNumber.Requests.Queries
{
    public class GetPhoneNumbersRequest:IRequest<List<PhoneNumberDto>>
    {
    }
}
