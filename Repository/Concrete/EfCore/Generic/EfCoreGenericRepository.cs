using E_Commerce.Repository.Abstract.Generic;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Repository.Concrete.EfCore.Generic
{
    public class EfCoreGenericRepository<TContext, TEntity> : IGenericRepository<TEntity>
        where TContext : class
        where TEntity : DbContext, new()
    {
        public void Create(TEntity entity)
        {
            using(var context = new TContext())
            {
                context.Set
            }
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
