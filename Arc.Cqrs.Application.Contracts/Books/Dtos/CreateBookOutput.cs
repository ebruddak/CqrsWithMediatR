using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arc.Cqrs.Application.Contracts.Books.Dtos
{
    public class CreateBookOutput
    {
        public bool IsSuccess { get; set; }
        public Guid Id { get; set; }
    }
}
