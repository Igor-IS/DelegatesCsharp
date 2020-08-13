using StockSystem.Entities;
using StockSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockSystem
{
    class Program
    {
        // delegate deve ser compativel com os methodos a serem usados por ele!
        delegate void Numbers(double num, double num2);

        static void Main(string[] args)
        {
            //UsingFilter();
            //UsingFunc();
            //UsingFilter();
            UsingDalegatesctiAction();
        }

        static void UsingFunc()
        {
            List<Product> productList = new List<Product>();
            DataDisplay display = new DataDisplay();

            productList.Add(new Product("Iphone 11", 11000));
            productList.Add(new Product("TV LG 70'", 7000));
            productList.Add(new Product("PS5", 2500));

            Func<Product, string> delegateFunc = product => product.ProductName.ToUpper();
            List<string> nameList = productList.Select(delegateFunc).ToList();

            display.Display(nameList);
        }

        static void UsingDalegatesctiAction() 
        {
            double num = 15;
            double num2 = 20;
            Numbers Math = CalculationService.ShowSum;
            Math += CalculationService.ShowMax; // add += method() é possivel executar N methodos ao mesmo tempo
            Math(num, num2);
        }

        static void UsingFilter()
        {
            DataDisplay display = new DataDisplay();
            Filter filter = new Filter();
            List<Product> ProductList = new List<Product>();

            ProductList.Add(new Product("Iphone 11", 11000));
            ProductList.Add(new Product("TV LG 70'", 7000));
            ProductList.Add(new Product("PS5", 2500));

            Console.WriteLine("Option the filters: [1] Filter by name  [2] Filter by price  [3] Cash payment  [4] Remove product per value");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                ProductList.Sort(filter.FilterName);
            }
            else if (option == 2)
            {
                ProductList.Sort(filter.FilterPrice);
            }
            else if (option == 3)
            {
                DiscountService discount = new DiscountService();
                ProductList.ForEach(discount.disc);
            }
            else if (option == 4)
            {
                Console.Write("Waht value: ");
                double value = double.Parse(Console.ReadLine());
                //Predicate é um delegate que retorna um bool.
                Predicate<Product> removeItemPerValue = (prod) => prod.Price >= value;
                ProductList.RemoveAll(removeItemPerValue);
            }
            else
            {
                Console.WriteLine("Invalid option!");
            }

            display.Display(ProductList);
        }
    }
}
