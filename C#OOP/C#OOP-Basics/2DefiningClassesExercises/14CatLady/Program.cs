namespace _14CatLady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Cat> cats = new List<Cat>();

            while (input != "End")
            {
                var data = input
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (data[0] == "StreetExtraordinaire")
                {
                    StreetExtraordinaire streetExtraordinaire = new StreetExtraordinaire();
                    streetExtraordinaire.Name = data[1];
                    streetExtraordinaire.DecibelsOfMeows = double.Parse(data[2]);
                    cats.Add(streetExtraordinaire);
                }
                else if (data[0] == "Siamese")
                {
                    Siamese siamese = new Siamese();
                    siamese.Name = data[1];
                    siamese.EarSize = double.Parse(data[2]);
                    cats.Add(siamese);
                }
                else if (data[0] == "Cymric")
                {
                    Cymric cymric = new Cymric();
                    cymric.Name = data[1];
                    cymric.FurLenght = double.Parse(data[2]);
                    cats.Add(cymric);
                }

                input = Console.ReadLine();
            }

            string catName = Console.ReadLine();

            var catResult = cats.FirstOrDefault(c => c.Name == catName);
            Console.WriteLine($"{catResult}");
        }
    }
}