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
    public class DeleteBookCommandHandler
    {
        public DeleteBookCommandResponse DeleteBook(DeleteBookCommandRequest deleteBookCommandRequest)
        {
            var deleteBook = DbContext.BookList.FirstOrDefault(p => p.Id == deleteBookCommandRequest.Id);
            DbContext.BookList.Remove(deleteBook);
            return new DeleteBookCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}
