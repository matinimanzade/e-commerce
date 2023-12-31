﻿namespace E_Commerce.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public int CategoryId { get; set; }
        public List<ProductCategory> ProductCategory { get; set; }
    }
}
