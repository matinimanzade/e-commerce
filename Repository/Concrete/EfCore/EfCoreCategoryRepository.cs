using E_Commerce.Entity;
using E_Commerce.Repository.Abstract;
using E_Commerce.Repository.Concrete.EfCore.Generic;

namespace E_Commerce.Repository.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<ShopContext, Category>, ICategoryRepository

    {
        public List<Category> GetPopularCategories()
        {
            throw new NotImplementedException();
        }
    }
}
