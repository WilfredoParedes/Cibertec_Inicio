using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData: BaseDataAccess<Product>
    {
        public List<Product> GetFakeProducts()
        {
            return new List<Product>
            {
                new Product {Id=1, Description="Cristal", Price=3.0,CreateDate=null},
            new Product { Id = 1, Description = "Pilsen", Price = 0.0, CreateDate=DateTime.Now },
            new Product { Id = 1, Description = "Cuzqueña", Price = 5.0,CreateDate=null },
            new Product { Id = 1, Description = "Sublime", Price = 1.0, CreateDate=DateTime.Now },
            new Product { Id = 1, Description = "Coca Cola", Price = 2.0,CreateDate=null },
            new Product { Id = 1, Description = "Guarana", Price = 0.0,CreateDate=DateTime.Now },
            new Product { Id = 1, Description = "Brama", Price = 4.0,CreateDate=null },
            new Product { Id = 1, Description = "Danker", Price = 0.0, CreateDate=DateTime.Now }
        };
        }
    }
}
