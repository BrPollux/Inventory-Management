using StokTakipProgramı.Entity;
using StokTakipProgramı.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : IProductRepository
    {
        private StokContext context;

        public EfProductRepository(StokContext _context)
        {
            context = _context;
        }

        public void AddProduct(Product entity)
        {
            context.Products.Add(entity);
            context.SaveChanges();
        }
     
        public void DeleteProduct(int productId)
        {
            var product = context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public IQueryable<Product> GetAll()
        {
            return context.Products;
        }

        public IQueryable<Product> GetByDepoId(int depoId)
        {
            return context.Products.Where(p => p.DepoId == depoId);
        }

        public Product GetById(int productId)
        {
            return context.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        

        public void UpdateProduct(Product entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
