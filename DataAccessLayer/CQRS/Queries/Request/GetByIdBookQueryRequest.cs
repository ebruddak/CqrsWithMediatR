using DataAccessLayer.CQRS.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Queries
{
    public class GetByIdBookQueryRequest : IRequest<GetByIdBookQueryResponse>
    {
        public Guid Id { get; set; }

    }
}
