using DataAccessLayer.CQRS.Queries;
using DataAccessLayer.CQRS.Queries.Response;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Handlers.QueryHandlers
{
   public class GetByIdBookQueryHandler
    {
        public GetByIdBookQueryResponse GetByIdBook(GetByIdBookQueryRequest getByIdbookQueryRequest)
        {
            var book = DbContext.BookList.FirstOrDefault(p => p.Id == getByIdbookQueryRequest.Id);
            return new GetByIdBookQueryResponse
            {
                Id = book.Id,
                Name = book.Name,
                Price = book.Price
            };
        }
    }
}
