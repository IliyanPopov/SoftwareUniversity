namespace BookShopSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using BookShopSystem.Data.Migrations;
    using BookShopSystem.Models.Models;

    public class BookShopContext : DbContext
    {
        // Your context has been configured to use a 'BookShopContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BookShopSystem.Data.BookShopContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BookShopContext' 
        // connection string in the application configuration file.
        public BookShopContext()
            : base("name=BookShopContext")
        {
            //Database.SetInitializer(
            //    new MigrateDatabaseToLatestVersion<BookShopContext, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(b => b.RelatedBooks)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("BookId");
                    m.MapRightKey("RelatedBookId");
                    m.ToTable("BookRelatedBooks");
                });
            base.OnModelCreating(modelBuilder);
        }

        public virtual IDbSet<Book> Books { get; set; }

        public virtual IDbSet<Author> Authors { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }
    }
}