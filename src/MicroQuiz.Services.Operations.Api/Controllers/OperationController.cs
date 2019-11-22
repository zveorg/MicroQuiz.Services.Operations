using MediatR;
using MicroQuiz.Services.Operations.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MicroQuiz.Services.Operations.Api.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class OperationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OperationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _mediator.Send(new GetOperationByIdQuery { Id = id });
            return Ok(result);
        }
    }
}