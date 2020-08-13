using StockSystem.Entities;
using System;

namespace StockSystem.Services
{
    class DiscountService
    {
        // Action delegate is not return, because aciton is void
        public Action<Product> disc = p => { p.Price -= p.Price * 0.1; };
    }
}
