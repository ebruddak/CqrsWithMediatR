using DataAccessLayer.CQRS.Commands.Request;
using DataAccessLayer.CQRS.Commands.Response;
using DataAccessLayer.CQRS.Handlers.CommandHandlers;
using DataAccessLayer.CQRS.Handlers.QueryHandlers;
using DataAccessLayer.CQRS.Queries;
using DataAccessLayer.CQRS.Queries.Response;
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
        CreateBookCommandHandler _createBookCommandHandler;
        DeleteBookCommandHandler _deleteBookCommandHandler;
        GetAllBookQueryHandler _getAllBookQueryHandler;
        GetByIdBookQueryHandler _getByIdBookQueryHandler;
        public BookController(
            CreateBookCommandHandler createBookCommandHandler,
            DeleteBookCommandHandler deleteBookCommandHandler,
            GetAllBookQueryHandler getAllBookQueryHandler,
            GetByIdBookQueryHandler getByIdBookQueryHandler)
        {
            _createBookCommandHandler = createBookCommandHandler;
            _deleteBookCommandHandler = deleteBookCommandHandler;
            _getAllBookQueryHandler = getAllBookQueryHandler;
            _getByIdBookQueryHandler = getByIdBookQueryHandler;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] GetAllBookQueryRequest requestModel)
        {
            List<GetAllBookQueryResponse> allBooks = _getAllBookQueryHandler.GetAllBook(requestModel);
            return Ok(allBooks);
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromQuery] GetByIdBookQueryRequest requestModel)
        {
            GetByIdBookQueryResponse Book = _getByIdBookQueryHandler.GetByIdBook(requestModel);
            return Ok(Book);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateBookCommandRequest requestModel)
        {
            CreateBookCommandResponse response = _createBookCommandHandler.CreateBook(requestModel);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromQuery] DeleteBookCommandRequest requestModel)
        {
            DeleteBookCommandResponse response = _deleteBookCommandHandler.DeleteBook(requestModel);
            return Ok(response);
        }
    }
}
