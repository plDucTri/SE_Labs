using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupplierRepository
    {
        private readonly Exer1DbContext db;

        public SupplierRepository()
        {
            db = new Exer1DbContext();
        }

        public void AddSupplier(Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            db.SaveChanges();
        }

        public IQueryable<Supplier> GetSuppliers()
        {
            return db.Suppliers;
        }

        public void DeleteSupplier(int id)
        {
            var supplier = db.Suppliers.Find(id);

            if (supplier != null)
            {
                db.Suppliers.Remove(supplier);
                db.SaveChanges();
            }
        }
    }
}