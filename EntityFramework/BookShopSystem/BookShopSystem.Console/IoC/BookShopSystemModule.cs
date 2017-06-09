namespace BookShopSystem.Console.IoC
{
    using System.Data.Entity;
    using BookShopSystem.Data;
    using BookShopSystem.Data.Repositories;
    using Ninject.Modules;
    public class BookShopSystemModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind(typeof(IRepository<>)).To(typeof(GenericEfRepository<>));
            this.Bind<DbContext>().To<BookShopContext>().InSingletonScope();
        }
    }
}