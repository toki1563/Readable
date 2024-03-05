using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readable
{
    // sealed(継承できないように)
    public sealed class Product
    {
        public Product(int productId, string productName, int price, int stock)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public int ProductId { get; }
        public string ProductName { get; }
        public int Price { get; }
        public int Stock { get; }
    }


    public sealed class ProductDto
    {
        public ProductDto(Product product)
        {
            ProductId = product.ProductId.ToString();
            ProductName = product.ProductName;
            Price = product.Price.ToString();
            Stock = product.Stock.ToString();
        }

        public string ProductId { get; }
        public string ProductName { get; }
        public string Price { get; }
        public string Stock { get; }
    }


    public static class ProductSqlServer
    {
        public static IEnumerable<Product> GetProducts()
        {
            var result = new List<Product>();
            result.Add(new Product(10, "p10", 100, 2));
            result.Add(new Product(20, "p20", 200, 4));
            result.Add(new Product(30, "p30", 300, 8));
            return result;
        }
    }
}
