using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Step_EShop.BLL.Products.Models
{
    public class ProductGetByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SalePrice { get; set; }
        public int StockAmount { get; set; }
        public decimal BuyingPrice { get; set; }
        public string CategoryName { get; set; }
    }
}
