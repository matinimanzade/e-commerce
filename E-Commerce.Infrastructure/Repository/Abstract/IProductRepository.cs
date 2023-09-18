using E_Commerce.Repository.Abstract.Generic;

namespace E_Commerce.Repository.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetPopularProducts();
    }
}
