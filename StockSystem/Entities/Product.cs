using System.Globalization;
using StockSystem.Services;

namespace StockSystem.Entities
{
    class Product
    {
        public string ProductName { get; private set; }
        public double Price { get;  set; }

        public Product(string name, double price)
        {
            ProductName = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ProductName} - ${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
