using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Commands.Request
{
    public class DeleteBookCommandRequest
    {
        public Guid Id { get; set; }

    }
}
