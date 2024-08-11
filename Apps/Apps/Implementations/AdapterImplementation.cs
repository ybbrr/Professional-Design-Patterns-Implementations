//Benim Adapter Design Pattern'imin dizini.
using DesignPatterns.Adapter;

namespace Apps.Implementations
{
    public static class AdapterImplementation
    {
        public static void Adapter_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nAdapter Design Pattern\n");

            ProductManager productManager = new ProductManager(new Some_Logger());
            productManager.Save();

            productManager = new ProductManager(new Log4NetAdapter());
            productManager.Save();

            Console.WriteLine("\n**************************************************");
        }
    }
}
