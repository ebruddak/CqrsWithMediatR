using Arc.Cqrs.Domain;
using DataAccessLayer.CQRS.Commands.Request;
using DataAccessLayer.CQRS.Commands.Response;
using Mediator.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Handlers.CommandHandlers
{
    public class CreateBookCommandHandler : ICommandHandler<CreateBookCommandRequest, CreateBookCommandResponse>
    {

        public async Task<CreateBookCommandResponse> Handle(CreateBookCommandRequest query, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            DbContext.BookList.Add(new()
            {
                Id = id,
                Name = query.Name,
                Price = query.Price
            });
            await Task.Yield();
            return new CreateBookCommandResponse
            {
                IsSuccess = true,
                Id = id
            };
        }

      
    }
}
