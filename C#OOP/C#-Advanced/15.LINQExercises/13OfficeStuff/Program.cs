namespace _13OfficeStuff
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<Product>> dictionary = new Dictionary<string, List<Product>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var inputSkippedBars = input.Skip(1).Take(input.Length - 2);
                string inputWithoutBards = string.Join("", inputSkippedBars);

                var data = inputWithoutBards.Split(new string[] { "-", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string companyName = data[0];
                long productQuantity = long.Parse(data[1]);
                string productName = data[2];

                Product product = new Product
                {
                    Name = productName,
                    Quantity = productQuantity
                };

                List<Product> products = new List<Product>();
                products.Add(product);
                if (!dictionary.ContainsKey(companyName))
                {
                    dictionary.Add(companyName, products);
                }
                else
                {
                    if (dictionary[companyName].Any(x => x.Name == productName))
                    {
                        int intdex = dictionary[companyName].FindIndex(x => x.Name == productName);
                        dictionary[companyName][intdex].Quantity += productQuantity;
                    }
                    else
                    {
                        dictionary[companyName].Add(product);
                    }
                }
            }


            foreach (var pair in dictionary.OrderBy(x =>x.Key))
            {
                Console.Write($"{pair.Key}: ");
                var last = pair.Value.Last();

                foreach (var value in pair.Value)
                {
                    if (value == last)
                    {
                        Console.Write($"{value.Name}-{value.Quantity}");
                    }
                    else
                    {
                        Console.Write($"{value.Name}-{value.Quantity}, ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }

        public long Quantity { get; set; }
        // {
        // public Product()
        //     this.ProductsAndQuantity = new Dictionary<string, long>();
        // }
        //// public string Name { get; set; }

        // public Dictionary<string, long> ProductsAndQuantity { get; set; }
    }
}