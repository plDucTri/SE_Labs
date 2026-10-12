using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SupplierService
    {
        private readonly SupplierRepository repo;

        public SupplierService()
        {
            repo = new SupplierRepository();
        }

        public void AddSupplier(Supplier supplier)
        {
            repo.AddSupplier(supplier);
        }

        public IQueryable<Supplier> GetSuppliers()
        {
            return repo.GetSuppliers();
        }

        public void DeleteSupplier(int id)
        {
            repo.DeleteSupplier(id);
        }
    }
}