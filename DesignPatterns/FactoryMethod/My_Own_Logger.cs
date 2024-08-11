namespace DesignPatterns.FactoryMethod
{
    public class My_Own_Logger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with \"My_Own_Logger\"");
        }
    }
}
