﻿using E_Commerce.Entity;
using E_Commerce.Repository.Abstract.Generic;

namespace E_Commerce.Repository.Abstract
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
       List<Category> GetPopularCategories();
    }
}