using DataAccessLayer.CQRS.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Commands.Request
{
    public class DeleteBookCommandRequest : IRequest<DeleteBookCommandResponse>
    {
        public Guid Id { get; set; }

    }
}
