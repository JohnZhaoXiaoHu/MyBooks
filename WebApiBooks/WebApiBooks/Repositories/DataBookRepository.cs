using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBooks.Models;
using WebApiBooks.RepopsitoryContracts;

namespace WebApiBooks.Repositories
{
    public class DataBookRepository : IBookRepository<Book>
    {
        readonly RepositoryContext _repositoryContext; 
        public DataBookRepository(RepositoryContext context)
        {
            _repositoryContext = context;
        }

        public void Add(Book entity)
        {
            _repositoryContext.Books.Add(entity);
            _repositoryContext.Books.Update(entity);
        } 

        public void Delete(Book book)
        {
            _repositoryContext.Books.Remove(book);
            _repositoryContext.Books.Update(book);
        }

        public Book Get(int id)
        {
            return _repositoryContext.Books.FirstOrDefault(e => e.BookId == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _repositoryContext.Books.ToList();
        }

        public void Update(Book book, Book entity)
        {
            book.BookId = entity.BookId;
            book.Author = entity.Author;
            book.nameBook = entity.nameBook;
            book.Page = entity.Page;

            _repositoryContext.Books.Update(entity);
        }
    }
}
