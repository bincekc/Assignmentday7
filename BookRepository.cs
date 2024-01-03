using AssignmentApiBook.Models;

namespace AssignmentApiBook.Repositories
{
    public class BookRepository : IBookRepository
    {
        public static List<Book> books = new List<Book>()
        {
            new Book() {BookId=123,BookName="GOAT",Price=300,Author="Hendry",Language="English",Publiser="john",Ryear=2020 },
            new Book() {BookId=124,BookName="GOT",Price=350,Author="joseph",Language="Irish",Publiser="john",Ryear=2001 },
            new Book() {BookId=125,BookName="The power of money",Price=400,Author="Hyra",Language="English",Publiser="johan",Ryear=2012 },
        };
        public void AddBook(Book book)
        {
            try
            {
                books.Add(book);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Book> BookByAuthor(string Author)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int bookId)
        {
            try
            {
                foreach (var book in books)
                {
                    if (book.BookId == bookId)
                    {
                        books.Remove(book);
                        break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Book> GetAllBooks()
        {
            return books;
        }

        public List<Book> GetBookByLang(string Lang)
        {
            List<Book> bookBylang = new List<Book>();
            try
            {
                foreach (var book in books)
                {
                    if (book.Language == Lang)
                    {
                        bookBylang.Add(book);
                        return bookBylang;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    

        public List<Book> GetBookByyear(int year)
        {
            List<Book> bookByear = new List<Book>();
            try
            {
                foreach (var book in books)
                {
                    if (book.Ryear == year)
                    {
                        bookByear.Add(book);
                        return bookByear;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateBook(Book book)
        {
            try
            {
                foreach (var item in books)
                {
                    if (item.BookId == book.BookId)
                    {
                        item.Author = book.Author;
                        item.BookName = book.BookName;
                        item.Price = book.Price;
                        item.Publiser = book.Publiser;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    }


