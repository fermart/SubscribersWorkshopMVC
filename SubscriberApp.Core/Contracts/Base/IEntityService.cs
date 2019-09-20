using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscribersApp.Core.Contracts.Base
{
    public interface IEntityService<T>
    {
        IList<T> GetAll();
        T GetById(int id);
        void Update(T entity);
        T Insert(T entity);
        void Delete(T entity);
    }
}
