namespace _1DefineClassPerson
{
    public class Person
    {
        public int age;
        public string name;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age)
            : this()
        {
            this.age = age;
        }

        public Person(string name, int age)
            : this(age)
        {
            this.name = name;
        }
    }
}