using Arc.Cqrs.Domain;
using DataAccessLayer.CQRS.Queries;
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
   public class GetByIdBookQueryHandler : IQueryHandler<GetByIdBookQueryRequest, GetByIdBookQueryResponse>
    {
        public async Task<GetByIdBookQueryResponse> Handle(GetByIdBookQueryRequest query, CancellationToken cancellationToken)
        {
            var book = DbContext.BookList.FirstOrDefault(p => p.Id == query.Id);
            await Task.Yield();
            return new GetByIdBookQueryResponse
            {
                Id = book.Id,
                Name = book.Name,
                Price = book.Price
            };
        }

    }
}
