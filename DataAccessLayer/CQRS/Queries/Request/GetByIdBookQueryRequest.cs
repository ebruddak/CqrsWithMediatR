using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Queries
{
    public class GetByIdBookQueryRequest
    {
        public Guid Id { get; set; }

    }
}
