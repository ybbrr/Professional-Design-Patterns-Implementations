namespace DesignPatterns.FactoryMethod
{
    public class OracleLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with \"OracleLogger\"");
        }
    }
}
