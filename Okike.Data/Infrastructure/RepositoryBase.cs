using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okike.Data.Infrastructure
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbContext _dbContext;
        private IDbSet<TEntity> dbSet; 

        protected RepositoryBase(IDatabaseFactory dataFac)
        {
            
                DataFactory = dataFac;
            dbSet = DataContext.Set<TEntity>();
        }
        public IDatabaseFactory DataFactory { get; private set; }

        public DbContext DataContext
        {
            get { return DataFactory.Get(); }
        }

        public virtual void Add(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            var result  = dbSet.Find(id);
            if(result != null)
                Delete(result);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> where)
        {
            var result = dbSet.Where(where).ToList();
            foreach (TEntity obj in result)
                Delete(obj);
        }

        public virtual void Delete(TEntity entity)
        {
            dbSet.Attach(entity);
            DataContext.Entry(entity).State = EntityState.Deleted;
        }

        public virtual TEntity GetById(object id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return dbSet.Where(where).AsEnumerable();
        }

        public virtual void Update(TEntity entity)
        {
            if(DataContext.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
                DataContext.Entry(entity).State = EntityState.Modified;
            }

        }

        public void Commit()
        {
            DataContext.SaveChanges();
        }
        public void CommitAsync()
        {
            DataContext.SaveChangesAsync();
        }
        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> where)
        {
            return dbSet;
        }
    }
}
