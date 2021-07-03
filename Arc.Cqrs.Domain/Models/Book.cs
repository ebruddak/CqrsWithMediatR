using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arc.Cqrs.Domain

{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
