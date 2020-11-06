using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Typing.DataAccess.Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //Get object by ID
        T Get(int id);

        //Get all objects IEnumerable
        IEnumerable<T> GetAll(
             Expression<Func<T, bool>> filter = null,
             Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
             string includeProperties = null
            );

        //Get the first or default 
        T GetFirstOrDefault(
             Expression<Func<T, bool>> filter = null,
             string includeProperties = null
            );

        //Add
        void Add(T entity);


        //Remove by ID
        void Remove(int id);

        //Remove the object itself
        void Remove(T entity);

        //Remove list of an object
        void RemoveRange(IEnumerable<T> entity);
    }
}
