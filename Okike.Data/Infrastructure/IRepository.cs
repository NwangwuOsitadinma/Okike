using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okike.Data.Infrastructure
{
    /// <summary>
    /// IRepository interface with basic CRUD following Repository pattern
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Adds entity to the persistent repository
        /// </summary>
        /// <param name="entity">The entity to be added to the persistent repository</param>
        void Add(T entity);
        /// <summary>
        /// Gets the specified entity from the persistent repository
        /// </summary>
        /// <param name="id">Id of the entity to retrieve</param>
        /// <returns></returns>
        T GetById(object id);
        /// <summary>
        /// Gets all the entities that statisfy the 'where' condition 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        /// <summary>
        /// Removes the specified entity from the persistent repository
        /// </summary>
        /// <param name="entity">The entity to remove</param>
        void Delete(T entity);
        /// <summary>
        /// Removes the entity with the specified id from the persitent repository
        /// </summary>
        /// <param name="id">The id of the entity to remove</param>
        void Delete(object id);
        /// <summary>
        /// Removes the entities that satisfy the where condition
        /// </summary>
        /// <param name="where"></param>
        void Delete(Expression<Func<T, bool>> where);
        /// <summary>
        /// Updates the specified entity from the persistent repository
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        IQueryable<T> Query(Expression<Func<T, bool>> where);
    }
}
