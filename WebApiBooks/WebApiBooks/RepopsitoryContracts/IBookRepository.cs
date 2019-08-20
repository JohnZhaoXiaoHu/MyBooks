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
        Book Get(int id);
        void Add(Book entity);
        void Update(Book dbEntity, Book entity);
        void Delete(Book entity);
    }
}
