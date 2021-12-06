using StokTakipProgramı.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Repository.Abstract
{
    public interface IProductRepository
    {
        Product GetById(int productId);
        IQueryable<Product> GetByDepoId(int depoId);
        IQueryable<Product> GetAll();
       
        void AddProduct(Product entity);
        void UpdateProduct(Product entity);
        void DeleteProduct(int productId);
    }
}
