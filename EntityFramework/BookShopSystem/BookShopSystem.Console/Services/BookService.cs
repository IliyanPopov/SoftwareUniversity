namespace BookShopSystem.Console.Services
{
    using System.Linq;
    using BookShopSystem.Data.Repositories;
    using BookShopSystem.Models.Models;

    public class BookService
    {
        private IRepository<Book> _books;
        public BookService(IRepository<Book> books)
        {
            this._books = books;
        }

        public IQueryable<Book> AllBooks()
        {
            return this._books.GetAll();
        }
    }
}