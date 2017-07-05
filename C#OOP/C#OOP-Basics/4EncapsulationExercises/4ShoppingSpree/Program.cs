namespace _4ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public class Program
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            var peopleAndMoneyLine = Console.ReadLine().Trim()
                .Split(';');

            foreach (var personAndMoney in peopleAndMoneyLine)
            {
                var personData = personAndMoney
                .Split('=');

                string name = personData[0];
                decimal money = decimal.Parse(personData[1]);

                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            var productsAndCostLine = Console.ReadLine()
                .Split(';');

            foreach (var productAndCost in productsAndCostLine)
            {
                var productData = productAndCost
                    .Split('=');

                string name = productData[0];
                decimal money = decimal.Parse(productData[1]);

                try
                {
                    Product product = new Product(name, money);
                    products.Add(product);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            string nameAndProductLine = Console.ReadLine();

            while (nameAndProductLine != "END")
            {
                var data = nameAndProductLine.Split(' ');
                string personName = data[0];
                string productName = data[1];

                try
                {
                    Person person = people.FirstOrDefault(p => p.Name == personName);
                    Product product = products.FirstOrDefault(p => p.Name == productName);

                    if (person != null && product != null)
                    {
                        person.BuyProduct(product);
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


                nameAndProductLine = Console.ReadLine().Trim();
            }

            foreach (var person in people)
            {
                if (person.Products.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products)}");
                }

            }
        }
    }
}