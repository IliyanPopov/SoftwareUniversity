namespace _13FamilyTree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        public Person(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Children = new List<Person>();
            this.Parents = new List<Person>();
        }

        public Person()
        {
            this.Children = new List<Person>();
            this.Parents = new List<Person>();
        }
        public string Name { get; set; }

        public string Birthday { get; set; }

        public List<Person> Children { get; set; }

        public List<Person> Parents { get; set; }

        //public override string ToString()
        //{
        //    return $"{this.Name} {this.Birthday} Parents: {Environment.NewLine} {string.Join(Environment.NewLine,this.Parents.ToString())}" +
        //           $" Children: {Environment.NewLine} {string.Join(Environment.NewLine, this.Children.ToString())}";
        //}
    }
}