namespace DesignPatterns.AbstractFactory
{
    /*
      * Logging abstract sınıfını kalıtımlayan bir sınıftır NLogger.
      * NLogger'ın bu projenin iş katmanında kullanılan bir loglama yöntemi olduğunu farzedin.
    */
    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            /*Burada NLogger kodu yazdığını farzedin.*/
            Console.WriteLine(message + " Logged with NLogger. (imitation)");
        }
    }
}
