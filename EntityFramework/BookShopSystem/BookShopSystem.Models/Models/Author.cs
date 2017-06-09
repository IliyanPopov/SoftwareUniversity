namespace BookShopSystem.Models.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Author
    {
        private ICollection<Book> _books;

        public Author()
        {
            this._books = new HashSet<Book>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public ICollection<Book> Books
        {
            get { return this._books; }
            set { this._books = value; }
        }
    }
}