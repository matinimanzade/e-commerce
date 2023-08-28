using E_Commerce.Entity;
using E_Commerce.Repository.Abstract;
using E_Commerce.Repository.Concrete.EfCore.Generic;

namespace E_Commerce.Repository.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<ShopContext, Product>, IProductRepository
    {
        public List<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }
    }
}
