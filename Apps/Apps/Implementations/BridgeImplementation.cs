
using DesignPatterns.Bridge;

namespace Apps.Implementations
{
    public static class BridgeImplementation
    {
        public static void Bridge_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nBridge Design Pattern\n");

            CustomerManager customerManager = new CustomerManager(); 
            customerManager.messageSenderBase = new SmSSender(); /*Bridging operation*/
            customerManager.UpdateCustomer();

            Console.WriteLine("\n\n----------------------------------------");

            customerManager.messageSenderBase = new EmailSender(); /*Bridging operation*/
            customerManager.UpdateCustomer();

            Console.WriteLine("\n**************************************************");
        }
    }
}
