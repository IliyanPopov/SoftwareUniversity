namespace BookShopSystem.Data.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        TEntity FindById(object id);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        TEntity Add(TEntity entity);

        TEntity Remove(object id);

        void Remove(TEntity entity);

        TEntity Update(TEntity entity);

        void SaveChanges();
    }
}