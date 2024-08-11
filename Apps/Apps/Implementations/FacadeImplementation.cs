using DesignPatterns.Facade;

namespace Apps.Implementations
{
    public static class FacadeImplementation
    {
        public static void Facade_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nFacade Design Pattern\n");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();

            Console.WriteLine("\n**************************************************");
        }
    }
}
