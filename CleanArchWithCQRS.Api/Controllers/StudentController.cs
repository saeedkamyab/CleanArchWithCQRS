using CleanArchWithCQRS.Application.Dtos.StudentDtos;
using CleanArchWithCQRS.Application.Features.Student.Requests.Commands;
using CleanArchWithCQRS.Application.Features.Student.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchWithCQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentDto>>> Get()
        {
            var students = await _mediator.Send(new GetAllStudentsRequest());
            return students;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDto>> Get(Guid id)
        {
            var student = await _mediator.Send(new GetStudentDetailRequest{Id = id});
            return student;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateStudent createStudent)
        {
            var command = new CreateStudentCommandRequest { CreateStudentDto = createStudent };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] UpdateStudentDto updateStudentDto)
        {
            var command = new UpdateStudentCommandRequest {Id=id, UpdateStudentDto = updateStudentDto };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteStudentRequestCommand { Id = id};
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
