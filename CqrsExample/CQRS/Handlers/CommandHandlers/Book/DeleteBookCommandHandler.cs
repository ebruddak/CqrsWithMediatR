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
    public class DeleteBookCommandHandler : ICommandHandler<DeleteBookCommandRequest, DeleteBookCommandResponse>
    {

        public async Task<DeleteBookCommandResponse> Handle(DeleteBookCommandRequest query, CancellationToken cancellationToken)
        {
            await Task.Yield();
            var deleteBook = DbContext.BookList.FirstOrDefault(p => p.Id == query.Id);
            DbContext.BookList.Remove(deleteBook);
            return new DeleteBookCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}
