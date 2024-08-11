namespace DesignPatterns.AbstractFactory
{
    /*
      * Logging abstract sınıfını kalıtımlayan bir sınıftır Log4NetLogger. 
      * Log4Net'in bu projenin iş katmanında kullanılan bir loglama yöntemi olduğunu farzedin.
    */
    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            /*Burada Log4Net kodu yazdığını farzedin.*/
            Console.WriteLine(message + " Logged with Log4Net. (imitation)");
        }
    }
}
