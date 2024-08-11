using DesignPatterns.ChainOfResponsibility;

namespace Apps.Implementations
{
    public static class ChainOfResponsibilityImplementation
    {
        public static void ChainOfResponsibility_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nChain Of Responsibility Design Pattern\n");

            Manager manager = new Manager();
            VicePresident vicePresident = new VicePresident();
            President president = new President();

            manager.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            Expense expense = new Expense { Detail = "Keyboard", Amount = 98 };
            manager.HandleExpense(expense);

            Expense expense2 = new Expense { Detail = "Monitor", Amount = 250 };
            manager.HandleExpense(expense2);

            Expense expense3 = new Expense { Detail = "Laptop", Amount = 2000 };
            manager.HandleExpense(expense3);

            Console.WriteLine("\n**************************************************");
        }
    }
}
