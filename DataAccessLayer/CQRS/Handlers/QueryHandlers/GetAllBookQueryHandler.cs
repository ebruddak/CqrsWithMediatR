using DataAccessLayer.CQRS.Queries.Response;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Handlers.QueryHandlers
{
   public class GetAllBookQueryHandler
    {
        public List<GetAllBookQueryResponse> GetAllBook(GetAllBookQueryRequest getAllProductQueryRequest)
        {
            return DbContext.BookList.Select(book => new GetAllBookQueryResponse
            {
                Id = book.Id,
                Name = book.Name,
                Price = book.Price
            }).ToList();
        }
    }
}
