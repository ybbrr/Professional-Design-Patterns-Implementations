using DesignPatterns.NullObject;

namespace Apps.Implementations
{
    internal class NullObjectImplementation
    {
        public static void NullObject_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nNull Object Design Pattern\n");

            CustomerManager customerManager = new CustomerManager(new NLogLogger());
            customerManager.Save();

            customerManager = new CustomerManager(StubLogger.GetInstance());
            customerManager.Save();

            Console.WriteLine("\n**************************************************");
        }
    }
}
