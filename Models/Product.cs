﻿namespace MYShop.Models
{
    public class Product
    {

        public Product()
        {
            categories = new List<Category>();  
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Category> categories { get; set; }
     }
}
