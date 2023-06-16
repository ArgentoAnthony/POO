using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class BookService : IBookService
    {
        public void Add(Book b)
        {
            throw new NotImplementedException();
        }

        public Book Get(string isbn)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(string isbn, Book b)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string isbn)
        {
            throw new NotImplementedException();
        }
    }
}
