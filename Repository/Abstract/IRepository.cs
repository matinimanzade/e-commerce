using E_Commerce.Entity;

namespace E_Commerce.Repository.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void DeleteById(int id);
    }
}
