using E_Commerce.Entity;

namespace E_Commerce.Repository.Abstract.Generic
{
    public interface IGenericRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
