namespace _5PizzaCalories
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Pizza pizza = new Pizza();
            bool isPizzaFirst = false;
            try
            {
                string input = Console.ReadLine();
                if (input.Split(' ')[0] == "Pizza")
                {
                    isPizzaFirst = true;
                }
                while (input != "END")
                {
                    var data = input.Split(new char[] {' '});

                    if (data[0] == "Pizza")
                    {
                        string pizzaName = data[1];
                        long toppingsCount = long.Parse(data[2]);
                        pizza.Name = pizzaName;
                        pizza.NumberOfToppings = toppingsCount;
                    }
                    else if (data[0] == "Dough")
                    {
                        string flourType = data[1];
                        string backingTechnique = data[2];
                        double weight = double.Parse(data[3]);

                        try
                        {
                            Dough dough = new Dough(backingTechnique, flourType, weight);
                            if (!isPizzaFirst)
                            {
                                Console.WriteLine($"{dough.Calories:F2}");
                            }

                            pizza.Dough = dough;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Environment.Exit(0);
                        }
                    }
                    else if (data[0] == "Topping")
                    {
                        string type = data[1];
                        double weight = double.Parse(data[2]);
                        try
                        {
                            Topping topping = new Topping(type, weight);
                            pizza.AddTopping(topping);
                            if (!isPizzaFirst)
                            {
                                Console.WriteLine($"{topping.Calories:F2}");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Environment.Exit(0);
                        }
                    }
                    input = Console.ReadLine();
                }

                if (isPizzaFirst)
                {
                    Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:F2} Calories.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }
    }
}