using DesignPatterns.Visitor;

namespace Apps.Implementations
{
    public static class VisitorImplementtation
    {
        public static void Visitor_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nVisitor Design Pattern\n");

            Manager manager = new Manager { Name = "Jack", Salary = 1200};
            Manager manager2 = new Manager { Name = "Jane", Salary = 1000 };
            Worker worker = new Worker { Name = "John", Salary = 800};
            Worker worker2 = new Worker { Name = "John", Salary = 800 };

            manager.Subordinates.Add(manager2);
            manager2.Subordinates.Add(worker);
            manager2.Subordinates.Add(worker2);

            OrganisationalStructure organisationalStructure = new OrganisationalStructure(manager); /*Hiyerarşinin en üst kademesinden başlatılır*/

            PaymentlVisitor payrollVisitor = new PaymentlVisitor();
            PayRiseVisitor payRiseVisitor = new PayRiseVisitor();

            organisationalStructure.Accept(payrollVisitor);
            Console.WriteLine();
            organisationalStructure.Accept(payRiseVisitor);

            Console.WriteLine("\n**************************************************");
        }
    }
}
