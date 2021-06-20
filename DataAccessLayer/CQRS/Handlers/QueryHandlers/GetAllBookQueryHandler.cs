using DataAccessLayer.CQRS.Queries.Response;
using DataAccessLayer.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Handlers.QueryHandlers
{
   public class GetAllBookQueryHandler: IRequestHandler<GetAllBookQueryRequest, List<GetAllBookQueryResponse>>
    {
        public async Task<List<GetAllBookQueryResponse>> Handle(GetAllBookQueryRequest request, CancellationToken cancellationToken)
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
