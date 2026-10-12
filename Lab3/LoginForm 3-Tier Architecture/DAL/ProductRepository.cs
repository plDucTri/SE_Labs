using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepository
    {
        private readonly Exer1DbContext db;

        public ProductRepository()
        {
            db = new Exer1DbContext();
        }

        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public IQueryable<Product> GetProducts()
        {
            return db.Products;
        }

        public void DeleteProduct(int id)
        {
            var product = db.Products.Find(id);

            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }
    }
}
