using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public static class DbContext
    {
        static List<Book> bookList = new List<Book> {
         new() { Id = Guid.NewGuid(), Name = "İki Şehrin Hikayesi:", Price = 100 },
         new() { Id = Guid.NewGuid(), Name = "Yüzüklerin Efendisi", Price = 200 },
         new() { Id = Guid.NewGuid(), Name = "7. Kızıl Köşkün Rüyası", Price = 20 },
         new() { Id = Guid.NewGuid(), Name = "Siyah İnci", Price = 60 }
        };
        public static List<Book> BookList => bookList;
    }
}
