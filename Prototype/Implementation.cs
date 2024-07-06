namespace Prototype
{
    public abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract Person Colne();
    }

    public class Manager : Person
    {
        public override string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public override Person Colne()
        {
            return (Person)MemberwiseClone();
        }
    }
    public class Employee : Person
    {
        public override string Name { get; set; }
        public Manager Manager { get; set; }

       

        public Employee(string name, Manager manager)
        {
            Name = name;
            Manager = manager;
        }

        public override Person Colne()
        {
            return (Person)MemberwiseClone();
        }
    }
}
