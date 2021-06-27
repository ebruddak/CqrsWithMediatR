using DataAccessLayer.CQRS.Commands.Response;
using DataAccessLayer.CQRS.Queries.Response;
using Mediator.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Commands.Request
{
    public class DeleteBookCommandRequest : IQuery<DeleteBookCommandResponse>
    {
        public Guid Id { get; set; }

    }
}
