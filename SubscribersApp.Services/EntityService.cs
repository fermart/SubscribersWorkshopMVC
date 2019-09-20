using SubscribersApp.Core.Contracts.Base;
using SubscribersApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscribersApp.Services
{
    public abstract class EntityService<T>: IEntityService<T> where T: Entity
    {
        private readonly IRepository<T> _entityRepository;

        public EntityService(IRepository<T> entityRepository)
        {
            this._entityRepository = entityRepository;
        }

        public IList<T> GetAll()
        {
            return this._entityRepository.Get();
        }

        public T GetById(int id)
        {
            return this._entityRepository.GetByID(id);
        }

        public void Update(T entity)
        {
            this._entityRepository.Update(entity);
            this._entityRepository.CommitChanges();
        }

        public T Insert(T entity)
        {
            var inserted = this._entityRepository.Insert(entity);
            this._entityRepository.CommitChanges();
            return inserted;
        }

        public void Delete(T entity)
        {
            this._entityRepository.Delete(entity);
            this._entityRepository.CommitChanges();
        }

    }
}
