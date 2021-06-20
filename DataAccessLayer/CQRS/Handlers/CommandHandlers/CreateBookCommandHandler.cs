using DataAccessLayer.CQRS.Commands.Request;
using DataAccessLayer.CQRS.Commands.Response;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Handlers.CommandHandlers
{
    public class CreateBookCommandHandler
    {
        public CreateBookCommandResponse CreateBook(CreateBookCommandRequest createBookCommandRequest)
        {
            var id = Guid.NewGuid();
            DbContext.BookList.Add(new()
            {
                Id = id,
                Name = createBookCommandRequest.Name,
                Price = createBookCommandRequest.Price
              
            });
            return new CreateBookCommandResponse
            {
                IsSuccess = true,
                Id = id
            };
        }
    }
}
