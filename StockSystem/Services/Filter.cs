using StockSystem.Entities;

namespace StockSystem.Services
{
    class Filter
    {
        // usando lambda functions para delegar o argumento da sort que esta em Program
        public int FilterName(Product prod, Product prod2) => prod.ProductName.ToUpper().CompareTo(prod2.ProductName.ToUpper());

        public int FilterPrice(Product prod, Product prod2) => prod.Price.CompareTo(prod2.Price);

        public bool FilterValuesMax100(Product prod) => prod.Price >= 5000;
    }
}
