namespace _1ParkingLot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> carNumbers = new HashSet<string>();

            while (input != "END")
            {
                var data = Regex.Split(input, ", ");
                string direction = data[0];
                string carNumber = data[1];

                if (direction == "IN")
                {
                    carNumbers.Add(carNumber);
                }
                else
                {
                    carNumbers.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            var sortedCarNumbers = carNumbers.OrderBy(x => x).ToList();
            if (sortedCarNumbers.Count > 0)
            {
                foreach (var carNumber in sortedCarNumbers)
                {
                    Console.WriteLine($"{carNumber}");
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
           
        }
    }
}