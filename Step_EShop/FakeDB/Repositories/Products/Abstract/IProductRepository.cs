using Step_EShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Step_EShop.FakeDB.Repositories.Products.Abstract
{
    public interface IProductRepository
    {
        Product GetById(int id);
        List<Product> GetAll();
        int Update(Product product);
        Product Add(Product product);
        void Delete(int id);
    }
}
