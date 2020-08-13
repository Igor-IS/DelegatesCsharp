
using System;
using System.Collections.Generic;

namespace StockSystem.Services
{
    class DataDisplay
    {
        public void Display<T>(List<T> values) // usando recurso do generics para aumentar o reuso!
        {
            foreach (var obj in values)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
