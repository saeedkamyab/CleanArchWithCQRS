using CleanArchWithCQRS.Application.Dtos.PhoneNumberDtos;
using CleanArchWithCQRS.Application.Features.PhoneNumber.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchWithCQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneNumberController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PhoneNumberController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<List<PhoneNumberDto>>> GetAll()
        {
            var phoneNumbers = await _mediator.Send(new GetPhoneNumbersRequest());
            return phoneNumbers;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<PhoneNumberDto>>> GetStudentPhoneNumbers(Guid id)
        {
            var phoneNumbers = await _mediator.Send(new GetStudentPhoneNumbersRequest { StudentId = id });
            return phoneNumbers;
        }
    }
}
