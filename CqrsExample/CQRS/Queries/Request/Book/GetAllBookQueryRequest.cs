using Mediator.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Queries.Response
{
    public class GetAllBookQueryRequest : IQuery<List<GetAllBookQueryResponse>>
    {
    }
}
