namespace DesignPatterns.NullObject
{
    /*
      * Bazan yazılım geliştirirken oluşturduğunuz iş tanımını test etmek için hiçbir şey yapmamasını isteyebilirsiniz.
        Bunun için direkt olarak null gönderemezsiniz çünkü null reference hatası hatası alırsınız. 
        Bunun yerine hiçbir şey yapmayan bir nesne tasarlayıp gönderirsiniz.
    */
    public class CustomerManager
    {
        private ILogger _logger;

        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            Console.WriteLine("Saved.");
            _logger.Log();
        }
    }

    /*
      * Bir tane test kodu yazacağınızı farzedin.
      * StubLogger null object işlevi görecek.
        StubLogger class'ını singleton olarak tasarlamak çok iyi olur çünkü
        programın neresinde kullanırsak kullanalım hiçbir şey yapmayacak, öyleyse sadece
        bir tane StubLogger instance'ı üretip onu defalarce kez kullanmak en doğrusu olur.
    */

    public class StubLogger : ILogger
    {
        private static StubLogger _stubLogger;
        private static object _lock = new object();

        private StubLogger()
        {

        }

        public static StubLogger GetInstance()
        {
            lock (_lock)
            {
                if(_stubLogger == null) _stubLogger = new StubLogger();
            }

            return _stubLogger;
        }

        public void Log()
        {
            /*Bu metodun içi tamamen boş duracak.*/
        }
    }

    public class CustomerManagerTest
    {
        public void Test()
        {
            /*
              * Buradaki new'lemeyi önemsemeyin, sadece konuyu anlatırken hızlı olmak için buraya yazıldı.
                Normalde metod içine asla new'leme yapmayız. Dependency Injection esastır.
            */
            CustomerManager customerManager = new CustomerManager(StubLogger.GetInstance());
            customerManager.Save();
        }
    }

    public interface ILogger
    {
        void Log();
    }

    public class Log4NetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with Log4Net. (imitation)");
        }
    }

    public class NLogLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with NLogLogger. (imitation)");
        }
    }
}
