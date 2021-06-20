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
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommandRequest, DeleteBookCommandResponse>
    {
        public async Task<DeleteBookCommandResponse> Handle(DeleteBookCommandRequest request, CancellationToken cancellationToken)
        {
            var deleteBook = DbContext.BookList.FirstOrDefault(p => p.Id == request.Id);
            DbContext.BookList.Remove(deleteBook);
            return new DeleteBookCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}

