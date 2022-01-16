using Step_EShop.BLL.Products.Models;
using Step_EShop.FakeDB.Repositories.Categories.Abstract;
using Step_EShop.FakeDB.Repositories.Products.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Step_EShop.BLL.Products
{
    public interface IProductService
    {
        List<GetAllProductsResponse> GetAllProducts();
        int Add(AddProductRequest request);
        int Update(UpdateProductRequest request);
        void Delete(int id);
        ProductGetByIdResponse ProductGetById(int id);
    }
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;

        public ProductService(IProductRepository productRepository,ICategoryRepository categoryRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
        }

        public int Add(AddProductRequest request)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<GetAllProductsResponse> GetAllProducts()
        {
            var products = productRepository.GetAll().Select(i => new GetAllProductsResponse
            {
                Id = i.Id,
                Name = i.Name,
                BuyingPrice = i.BuyingPrice,
                CategoryId = i.CategoryId,
                SalePrice = i.SalePrice,
                StockAmount = i.StockAmount
            });
            return products.ToList();
        }

        public ProductGetByIdResponse ProductGetById(int id)
        {
            var product = (from p in productRepository.GetAll()
                          join c in categoryRepository.GetCategories()
                          on p.CategoryId equals c.Id
                          select new ProductGetByIdResponse
                          {
                              Id = p.Id,
                              Name = p.Name,
                              BuyingPrice = p.BuyingPrice,
                              SalePrice = p.SalePrice,
                              StockAmount = p.StockAmount,
                              CategoryName = c.Name
                          }).FirstOrDefault(i=>i.Id == id);
            return product;
        }

        public int Update(UpdateProductRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
