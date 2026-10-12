using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductService
    {
        private ProductRepository repo;

        public ProductService()
        {
            repo = new ProductRepository();
        }

        public void AddProduct(Product product)
        {
            repo.AddProduct(product);
        }

        public IQueryable<Product> GetProducts()
        {
            return repo.GetProducts();
        }

        public void DeleteProduct(int id)
        {
            repo.DeleteProduct(id);
        }
    }
}