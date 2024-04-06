using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_05.Task_1._2
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public static void TotalPrice(ILookup<string, Product> lookup)
        {
            foreach (var group in lookup)
            {
                foreach (var product in group)
                {
                    Console.WriteLine($"{product.Name} {product.Price}");
                }
                decimal totalPriceForCategory = group.Sum(product => product.Price);

                Console.WriteLine($"{group.Key} {totalPriceForCategory}");
            }
        }
    }
}
