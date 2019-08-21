using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBooks.Models;

namespace WebApiBooks.RepopsitoryContracts
{
   public interface IBookRepository<Book>
    {
        IEnumerable<Book> GetAll();
        Book Get(Guid id);
        void Add(Book updateBook);
        void Update(Book dbEntity, Book updateBook);
        void Delete(Book updateBook);
        IEnumerable<Book> GetBooks(Book book);
    }
}
