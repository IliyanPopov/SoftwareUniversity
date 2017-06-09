using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopSystem.Data.Repositories
{
    using System.Data.Entity;
    using System.Linq.Expressions;

    public class GenericEfRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _dbContext;

        public GenericEfRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
            this.EntitySet = dbContext.Set<TEntity>();
        }

        public IDbSet<TEntity> EntitySet { get; }

        public IQueryable<TEntity> GetAll()
        {
            return this.EntitySet;
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return this.EntitySet.Where(predicate);
        }

        public TEntity FindById(object id)
        {
            return this.EntitySet.Find(id);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return this.EntitySet.SingleOrDefault(predicate);
        }

        public TEntity Add(TEntity entity)
        {
            return this.ChangeState(entity, EntityState.Added);
        }

        public TEntity Remove(object id)
        {
            var entity = this.FindById(id);
            this.Remove(entity);
            return entity;
        }

        public void Remove(TEntity entity)
        {
            this.ChangeState(entity, EntityState.Deleted);
        }

        public TEntity Update(TEntity entity)
        {
            return this.ChangeState(entity, EntityState.Modified);
        }

        public void SaveChanges()
        {
            this._dbContext.SaveChanges();
        }

        private TEntity ChangeState(TEntity entity, EntityState state)
        {
            var entry = this._dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.EntitySet.Attach(entity);
            }

            entry.State = state;
            return entity;
        }

        public void Dispose()
        {
           this._dbContext.Dispose();
        }
    }
}
