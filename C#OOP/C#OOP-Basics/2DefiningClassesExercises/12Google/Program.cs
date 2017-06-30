namespace _12Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Person> people = new List<Person>();

            while (input != "End")
            {
                var data = input
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string personName = data[0];

                if (!people.Any(p => p.Name == personName))
                {
                    Person personTemp = new Person(personName);
                    people.Add(personTemp);
                }

                var person = people.FirstOrDefault(p => p.Name == personName);

                if (data[1] == "company")
                {
                    CreateCompany(data, person);
                }
                else if (data[1] == "pokemon")
                {
                    CreatePokemon(data, person);
                }
                else if (data[1] == "parents")
                {
                    CreateParent(data, person);
                }
                else if (data[1] == "children")
                {
                    CreateChild(data, person);
                }
                else if (data[1] == "car")
                {
                    CreateCar(data, person);
                }

                input = Console.ReadLine();
            }

            string name = Console.ReadLine();

            var personResult = people.FirstOrDefault(p => p.Name == name);

            if (personResult != null)
            {
                Console.WriteLine(personResult);
            }
        }

        private static void CreateCar(List<string> data, Person person)
        {
            string carModel = data[2];
            long carSpeed = long.Parse(data[3]);

            Car car = new Car(carModel, carSpeed);
            person.Car = car;
        }

        private static void CreateChild(List<string> data, Person person)
        {
            string childName = data[2];
            var yearData = data[3];

            Child child = new Child(childName, yearData);

            if (!person.Children.Any(c => c.Name == childName))
            {
                person.Children.Add(child);
            }
            else
            {
                var childFound = person.Children.Find(p => p.Name == childName);
                childFound.Name = childName;
                childFound.Birthday = yearData;
            }
        }

        private static void CreateParent(List<string> data, Person person)
        {
            string parentName = data[2];
            var yearData = data[3];

            Parent parent = new Parent(parentName, yearData);

            if (!person.Parents.Any(p => p.Name == parentName))
            {
                person.Parents.Add(parent);
            }
            else
            {
                var parentFound = person.Parents.Find(p => p.Name == parentName);
                parentFound.Name = parentName;
                parentFound.Birthday = yearData;
            }
        }

        private static void CreatePokemon(List<string> data, Person person)
        {
            string pokemonName = data[2];
            string pokemonType = data[3];

            Pokemon pokemon = new Pokemon(pokemonName, pokemonType);

            if (!person.Pokemons.Any(p => p.Name == pokemonName))
            {
                person.Pokemons.Add(pokemon);
            }
            else
            {
                var pokemonFound = person.Pokemons.Find(p => p.Name == pokemonName);
                pokemonFound.Name = pokemonName;
                pokemonFound.Type = pokemonType;
            }
        }

        private static void CreateCompany(List<string> data, Person person)
        {
            string companyName = data[2];
            string companyDepartment = data[3];
            decimal salary = decimal.Parse(data[4]);

            Company company = new Company(companyName, companyDepartment, salary);
            person.Company = company;
        }
    }
}