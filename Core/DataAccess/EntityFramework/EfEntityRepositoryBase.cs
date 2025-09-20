using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        AutoStockAppEntities
        public EfEntityRepositoryBase()
        {

        }
        public List<TEntity> GetAll()
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }
    }
}
