//Benim Composite Design Pattern'ımın dizini.
using DesignPatterns.Composite;
namespace Apps.Implementations
{
    public static class CompositeImplementation
    {
        public static void Composite_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nComposite Design Pattern\n");

            Employee john = new Employee { Name = "John Doe" };
            Employee jane = new Employee { Name = "Jane Doe" };
            john.AddSubordinates(jane);

            Employee july = new Employee { Name = "July Doe" };
            july.AddSubordinates(john);

            Contractor jude = new Contractor { Name = "Jude Doe" };
            john.AddSubordinates(jude);

            Employee judy = new Employee { Name = "Judy Doe" };
            july.AddSubordinates(judy);

            Console.WriteLine("* " + july.Name);
            foreach (Employee manager in july)
            {
                Console.WriteLine("  ** " + manager.Name);
                foreach (IPerson subordinate in manager)
                {
                    Console.WriteLine("     *** " + subordinate.Name);
                }
            }

            Console.WriteLine("\n**************************************************");
        }
    }
}
