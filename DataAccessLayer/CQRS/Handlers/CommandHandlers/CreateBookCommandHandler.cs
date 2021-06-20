using DataAccessLayer.CQRS.Commands.Request;
using DataAccessLayer.CQRS.Commands.Response;
using DataAccessLayer.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Handlers.CommandHandlers
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommandRequest, CreateBookCommandResponse>
    {

        public async Task<CreateBookCommandResponse> Handle(CreateBookCommandRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            DbContext.BookList.Add(new()
            {
                Id = id,
                Name = request.Name,
                Price = request.Price           
            });
            return new CreateBookCommandResponse
            {
                IsSuccess = true,
                Id = id
            };
        }
    }
}
