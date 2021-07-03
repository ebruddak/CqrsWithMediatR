using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Commands.Response
{
   public class CreateBookCommandResponse
    {
        public bool IsSuccess { get; set; }
        public Guid Id { get; set; }
    }
}
