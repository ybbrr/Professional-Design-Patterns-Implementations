
using DesignPatterns.Strategy;

namespace Apps.Implementations
{
    public static class StrategyImplementation
    {
        public static void Strategy_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nStrategy Design Pattern\n");

            CustomerManager customerManager = new CustomerManager();
            customerManager.creditCalculatorBase = new After2010CreditCalculator();
            customerManager.SaveCredit();

            Console.WriteLine("\n----------------------------------\n");

            customerManager.creditCalculatorBase = new Before2010CreditCalculator();
            customerManager.SaveCredit();

            Console.WriteLine("\n**************************************************");
        }
    }
}
