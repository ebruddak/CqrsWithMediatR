using Arc.Cqrs.Domain;
using DataAccessLayer.CQRS.Queries.Response;
using Mediator.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Handlers.QueryHandlers
{
    public class GetAllBookQueryHandler : IQueryHandler<GetAllBookQueryRequest, List<GetAllBookQueryResponse>>
    {
        public async Task<List<GetAllBookQueryResponse>> Handle(GetAllBookQueryRequest query, CancellationToken cancellationToken)
        {
            await Task.Yield();
            return DbContext.BookList.Select(book => new GetAllBookQueryResponse
            {
                Id = book.Id,
                Name = book.Name,
                Price = book.Price
            }).ToList();
        }
    }
}
