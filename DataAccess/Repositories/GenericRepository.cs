using DataAccess.Abstract;
using Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T>
        where T : class
    {
        AutoStockAppEntities context = new AutoStockAppEntities();
        private readonly DbSet<T> _object;
        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public void Add(T entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Remove(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
