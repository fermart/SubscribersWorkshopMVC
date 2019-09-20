using SubscribersApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SubscribersApp.Core.Contracts.Base
{
    public interface IRepository<T> where T: Entity
    {
        IList<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        T GetByID(int id);
        T Insert(T entity);
        void Delete(int id);
        void Delete(T entityToDelete);
        void Update(T entityToUpdate);
        IList<T> GetAll();
        void CommitChanges();
    }
}
