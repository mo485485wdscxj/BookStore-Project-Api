using library_.Dtos;
using library_.Models;

namespace library_.Interface
{
    public interface IBook
    {
        public BookDtos GetBookById(int id);
        public void AddBooks(BookDtos bookDtos);
        public IEnumerable<Book> GetAllBooks();
        public void updateBooks(BookDtos bookdto, int id);
        public void DeletBook(int id);




    }
};
