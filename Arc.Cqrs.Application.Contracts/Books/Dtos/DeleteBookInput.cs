using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arc.Cqrs.Application.Contracts.Books.Dtos
{
    public class DeleteBookInput
    {
        public Guid Id { get; set; }

    }
}
