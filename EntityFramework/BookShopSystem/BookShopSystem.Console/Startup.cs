namespace BookShopSystem.Console
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using BookShopSystem.Data;
    using BookShopSystem.Models.Enumerations;
    using BookShopSystem.Models.Models;
    using EntityFramework.Extensions;

    public class Startup
    {
        public static void Main()
        {
            var context = new BookShopContext();

            RemoveBooksWithCopiesLowerThan(context);
        }

        //15.Remove Books
        public static void RemoveBooksWithCopiesLowerThan(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Copies <= 6000)
                .Delete();

            Console.WriteLine(books);
            context.SaveChanges();
        }

        // 14.	Increase Book Copies
        public static void IncreaseBookCopiesAfterDate(BookShopContext context)
        {
            var dateTime = new DateTime(2013,7,6);
            var books =
                context.Books.Where(b => b.ReleaseDate >= dateTime)
                .Update(x => new Book {Copies = x.Copies + 44});

            Console.WriteLine(books * 44);
            //context.Table.Where(x => x.Field1 > 0).Update(y => new Table { Field2 = y.Field2 + 1 });
        }

        // 13. Most Recent Books
        public static void GetMostRecentBooksByCategories(BookShopContext context)
        {
            var categories = context.Categories
                .Include(c => c.Books)
                .Select(c => new
                {
                    c.Name,
                    BooksCount = c.Books.Count,
                    Books = c.Books
                        .Select(b => b)
                        .OrderByDescending(b => b.ReleaseDate)
                        .Take(3)
                })
                .OrderByDescending(c =>c.BooksCount)
                .ToList();

            foreach (var category in categories)
            {
                Console.WriteLine($"--{category.Name}: {category.BooksCount} books");

                foreach (var book in category.Books)
                {
                    Console.WriteLine($"{book.Title} ({book.ReleaseDate.Year})");
                }
            }
        }

        // 12. Find Profit
        public static List<CategoryProfitViewModel> GetProfitOfBookCategories(BookShopContext context)
        {
            var categories = context.Categories
                .Include(c => c.Books)
                .Select(c => new CategoryProfitViewModel
                {
                    Title = c.Name,
                    Profit = c.Books.Select(b => b.Price * b.Copies).Sum()
                })
                .OrderByDescending(c => c.Profit)
                .ThenBy(c => c.Title)
                .ToList();

            return categories;
        }

        //11. Total Book Copies
        public static List<Book> GetBookCopiesByAuthor(BookShopContext context)
        {
            var books = context.Books
                .Include(b => b.Author)
                .OrderByDescending(b => b.Copies)
                .ToList();

            return books;
        }

        // 10. Count Books
        public static int GetBookCountWhereTitleIsLongerThanNumber(int lenght, BookShopContext context)
        {
            var booksCount = context.Books.Count(b => b.Title.Length >= lenght);

            return booksCount;
        }

        //9. Book Titles Search
        public static List<Book> GetBooksByAuthorLastNameLetter(string input, BookShopContext context)
        {
            var books = context.Books
                .Include(b => b.Author)
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(b => b.Id)
                .ToList();

            return books;
        }

        //8. Books Search
        public static List<Book> GetBooksByLetternInTitle(string input, BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .ToList();

            return books;
        }

        //7. Authors Search
        public static List<Author> GetAuthorByLettersInFirstName(string input, BookShopContext context)
        {
            var authors = context.Authors
                .Where(a => a.FirstName.EndsWith(input))
                .ToList();

            return authors;
        }

        //6. Books Released Before Date
        public static List<Book> GetBooksBeforeThisDate(string inputDate, BookShopContext context)
        {
            string[] dateArr = inputDate
                .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int day = int.Parse(dateArr[0]);
            int month = int.Parse(dateArr[1]);
            int year = int.Parse(dateArr[2]);

            DateTime date = new DateTime(year, month, day);

            var books = context.Books
                .Where(b => b.ReleaseDate <= date)
                .ToList();

            return books;
        }

        //5. Book Titles by Category
        public static HashSet<Book> GetBooksByCategories(string input, BookShopContext context)
        {
            var categories = ReadCategories(input);

            HashSet<Book> booksInCategories = new HashSet<Book>();
            foreach (var category in categories)
            {
                var booksInCategory = context.Categories
                    .Include(c => c.Books)
                    .FirstOrDefault(c => c.Name == category);

                if (booksInCategory != null)
                {
                    foreach (var book in booksInCategory.Books)
                    {
                        booksInCategories.Add(book);
                    }
                }
            }

            return booksInCategories;
        }

        //4. Not Released Books
        public static List<Book> GetBooksBookNotInYear(int year, BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.Year != year)
                .OrderBy(b => b.Id)
                .ToList();

            return books;
        }


        //3. Books by Price
        public static IEnumerable<BookViewModel> GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Price <= 5 || b.Price >= 40)
                .OrderBy(b => b.Id)
                .Select(b => new BookViewModel
                {
                    Title = b.Title,
                    Price = b.Price
                }).ToArray();

            return books;
        }

        //2. Golden Books
        public static IEnumerable<Book> GetGoldenBooks(BookShopContext context)
        {
            var goldenBooks = context
                .Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .Include(b => b.Author)
                .OrderBy(b => b.Id)
                .ToList();

            return goldenBooks;
        }

        // 1. Books Titles by Age Restriction
        public static IEnumerable<Book> GetBooksByAgeRestriction(string input, BookShopContext context)
        {
            AgeRestriction ageRestriction;
            Enum.TryParse(input, true, out ageRestriction);
            var adultBooks = context
                .Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .ToList();

            return adultBooks;
        }


        public static string[] ReadCategories(string input)
        {
            var categoriesArray = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e)
                .ToArray();

            return categoriesArray;
        }


        public class BookViewModel
        {
            public string Title { get; set; }

            public decimal Price { get; set; }
        }

        public class CategoryProfitViewModel
        {
            public string Title { get; set; }

            public decimal Profit { get; set; }
        }
    }
}