namespace _12Google
{
    using System;

    public class Parent
    {
        public Parent(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Name { get; set; }

        public string Birthday { get; set; }

        public override string ToString()
        {
            return $"{Environment.NewLine} {this.Name} {this.Birthday:dd/MM/yyyy}";
        }
    }
}