using library_.Dtos;
using library_.Interface;
using library_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace library_.Reposatories
{
    public class BookRepo : IBook
    {
        private readonly AppDbContext _context;
        public BookRepo(AppDbContext context)
        {
            _context = context;
        }

        /*
         Get Book By Name ✅
         Get All Books ✅
         Add Book ✅
         Reomve Book✅
         update book✅
         Remove All Books✅
        */

        public BookDtos GetBookById(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            if (book == null) { return null; };
            var bookDtos = new BookDtos
            {
                Title = book.Title,
                Id = book.Id,
                PublishedYear = book.PublishedYear,
                authorIds = book.authors.Select(a => a.Id).ToList(),
                genreIds = book.genres.Select(a => a.Id).ToList(),

            };
            return bookDtos;
        }

        public void AddBooks(BookDtos bookDtos)
        {
            var author = _context.Authers.Where(a => bookDtos.authorIds.Contains(a.Id)).ToList();
            Book book = new Book
            {
                Title = bookDtos.Title,
                Id = bookDtos.Id,
                PublishedYear = bookDtos.PublishedYear,
                authors = author,
            };
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            var books = _context.Books.Include(b => b.authors)
                .Include(a => a.genres).ToList();
            return books;
        }

        public void updateBooks(BookDtos bookdto, int id)
        {
            var book = _context.Books.Find(id);
            if (book != null)
            {
                book.Title = bookdto.Title;
                book.Id = id;
                book.PublishedYear = bookdto.PublishedYear;
                book.authors = (ICollection<Author>)bookdto.authorIds;
                book.genres = (ICollection<Genre>)bookdto.genreIds;
            }

        }

        public void DeletBook(int id)
        {
            var Book = _context.Books.Find(id);
            if (Book != null)
            {
                _context.Books.Remove(Book);
                _context.SaveChanges();
            }

        }

       

    }
}
