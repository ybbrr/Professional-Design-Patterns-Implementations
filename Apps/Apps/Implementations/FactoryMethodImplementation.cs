//Benim Factory Method Design Pattern'imin dizini.
using DesignPatterns.FactoryMethod;

namespace Apps.Implementations
{
    public static class FactoryMethodImplementation
    {
        public static void FactoryMethod_for_Some_Logger()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nFactory Method Design Pattern\n");

            CustomerManager cm = new CustomerManager(new LoggerFactory());
            cm.Save();

            cm = new CustomerManager(new LoggerFactory2());
            cm.Save();

            /*
              * Artık nesne new'lerken tek bağımlılık CustomerManager class'ınadır.
            */

            Console.WriteLine("\n**************************************************");
        }
    }
}
