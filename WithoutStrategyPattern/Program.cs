using System;
using System.Collections.Generic;

namespace WithoutStrategyPattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product
                {
                    Name = "Computer",
                    Price = 299.99m,
                    ProductionCountry = "China"
                },
                new Product
                {
                    Name = "Shampoo",
                    Price = 1.49m,
                    ProductionCountry = "Australia"
                },
                new Product
                {
                    Name = "Car",
                    Price = 24999.99m,
                    ProductionCountry = "USA"
                }
            };

            var productionCostCalculatorService = new ProductionCostCalculatorService();

            foreach (var item in products)
            {
               var productionCost = productionCostCalculatorService.CalculateProductionCost(item);

                Console.WriteLine($"The production costs for {item.Name} are {productionCost}$");
            }

            Console.ReadKey();
        }
    }
}