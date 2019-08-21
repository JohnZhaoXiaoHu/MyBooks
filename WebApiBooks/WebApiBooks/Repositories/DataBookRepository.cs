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

        public void Add(Book updatebook)
        {
            _repositoryContext.Books.Add(updatebook);
           
        } 

        public void Delete(Book updatebook)
        {
            _repositoryContext.Books.Remove(updatebook);          
        }

        public Book Get(Guid id)
        {
            return _repositoryContext.Books.FirstOrDefault(e=>e.Id==id);
        }


        public IEnumerable<Book> GetBooks(Book book)
        {
            
            var books = _repositoryContext.Books.AsQueryable();
            if (!string.IsNullOrEmpty(book.NameBook))
            {
                books = books.Where(e => string.Equals(e.NameBook, book.NameBook));
            }
            if(!string.IsNullOrEmpty(book.Author))
            {
                books = books.Where(e => string.Equals(e.Author, book.Author));
            }
            return books.ToList();
        }


        public IEnumerable<Book> GetAll()
        {
            return _repositoryContext.Books.ToList();
        }

        public void Update(Book book, Book updateBook)
        {          
            book.Author = updateBook.Author;
            book.NameBook = updateBook.NameBook;
            book.Page =  updateBook.Page;

            _repositoryContext.Books.Update(updateBook);
        }
    }
}
