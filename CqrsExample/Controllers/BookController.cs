using DataAccessLayer.CQRS.Commands.Request;
using DataAccessLayer.CQRS.Commands.Response;
using DataAccessLayer.CQRS.Handlers.CommandHandlers;
using DataAccessLayer.CQRS.Handlers.QueryHandlers;
using DataAccessLayer.CQRS.Queries;
using DataAccessLayer.CQRS.Queries.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsExample
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        IMediator _mediator;
        public BookController( IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllBookQueryRequest requestModel)
        {
            List<GetAllBookQueryResponse> allBooks = await _mediator.Send(requestModel);
            return Ok(allBooks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromQuery] GetByIdBookQueryRequest requestModel)
        {
            GetByIdBookQueryResponse Book = await _mediator.Send(requestModel);
            return Ok(Book);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateBookCommandRequest requestModel)
        {
            CreateBookCommandResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] DeleteBookCommandRequest requestModel)
        {
            DeleteBookCommandResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}
