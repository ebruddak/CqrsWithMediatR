using Arc.Cqrs.Application.Contracts.Books;
using Arc.Cqrs.Application.Contracts.Books.Dtos;
using DataAccessLayer.CQRS.Commands.Request;
using DataAccessLayer.CQRS.Commands.Response;
using DataAccessLayer.CQRS.Handlers.CommandHandlers;
using DataAccessLayer.CQRS.Handlers.QueryHandlers;
using DataAccessLayer.CQRS.Queries;
using DataAccessLayer.CQRS.Queries.Response;
using Mediator.Core;
using Mediator.Core.Contracts;
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
        private readonly IMediatorBus _mediator;
        private readonly IBookManager _bookManager;

        public BookController(IMediatorBus mediator, IBookManager bookManager)
        {
            _mediator = mediator;
            _bookManager = bookManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<GetAllBookQueryResponse> allBooks = await _mediator.SendAsync(new GetAllBookQueryRequest());
            return Ok(allBooks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(GetByIdBookInput requestModel)
        {
            GetByIdBookQueryResponse Book = await _mediator.SendAsync(new GetByIdBookQueryRequest { Id = requestModel.Id });
            return Ok(Book);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateBookInput requestModel)
        {
            CreateBookCommandResponse response = await _mediator.SendAsync(new CreateBookCommandRequest { Name=requestModel.Name, Price=requestModel.Price });
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(DeleteBookInput requestModel)
        {
            DeleteBookCommandResponse response = await _mediator.SendAsync(new DeleteBookCommandRequest { Id=requestModel.Id } );
            return Ok(response);
        }

    }
}
