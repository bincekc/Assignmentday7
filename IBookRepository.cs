using AssignmentApiBook.Models;

namespace AssignmentApiBook.Repositories
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        List<Book> GetAllBooks();
        List <Book> BookByAuthor(string Auther);
        List<Book> GetBookByLang(string Lang);
        List<Book> GetBookByyear(int year);
        void UpdateBook(Book book);
        void DeleteBook(int bookId);

    }
}
