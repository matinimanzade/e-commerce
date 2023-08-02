using E_Commerce.Entity;
using E_Commerce.Repository.Abstract;

namespace E_Commerce.Repository.Concrete.EfCore
{
    public class EfCoreProductRepository : IProductRepository
    {
        private ShopContext shopContext = new ShopContext();
        public void Create(Product entity)
        {
            shopContext.Products.Add(entity);
            shopContext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
