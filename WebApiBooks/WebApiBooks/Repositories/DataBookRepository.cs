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

        public void Add(Book updateBook)
        {
            _repositoryContext.Books.Add(updateBook);
           
        } 

        public void Delete(Book updateBook)
        {
            _repositoryContext.Books.Remove(updateBook);          
        }

        public Book Get(Guid id)
        {
            return _repositoryContext.Books.FirstOrDefault(e=>e.Id==id);
        }


        public IEnumerable<Book> GetBooks(Book getBook)
        {
            var res = new List<Book>();
            var tmp = _repositoryContext.Books.AsQueryable();
            if (!string.IsNullOrEmpty(getBook.NameBook))
            {
                tmp = tmp.Where(e => string.Equals(e.NameBook, getBook.NameBook));
            }
            if(!string.IsNullOrEmpty(getBook.Author))
            {
               tmp = tmp.Where(e => string.Equals(e.Author, getBook.Author));
            }
            return res;
        }


        public IEnumerable<Book> GetAll()
        {
            return _repositoryContext.Books.ToList();
        }

        public void Update(Book UpdateBook, Book updateBookDb)
        {          
            UpdateBook.Author = updateBookDb.Author;
            UpdateBook.NameBook = updateBookDb.NameBook;
            UpdateBook.Page =  updateBookDb.Page;

            _repositoryContext.Books.Update(updateBookDb);
        }
    }
}
