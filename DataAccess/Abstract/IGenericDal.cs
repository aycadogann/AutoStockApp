using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IGenericDal<T> where T: class
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        List<T> GetAll();
    }
}
