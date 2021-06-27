using DataAccessLayer.CQRS.Queries.Response;
using Mediator.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Queries
{
    public class GetByIdBookQueryRequest : IQuery<GetByIdBookQueryResponse>
    {
        public Guid Id { get; set; }

    }
}
