﻿using E_Commerce.Entity;
using E_Commerce.Repository.Abstract;

namespace E_Commerce.Repository.Concrete.EfCore
{
    public class EfCoreProductRepository : IProductRepository
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
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

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}