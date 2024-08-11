namespace DesignPatterns.Adapter
{
    /*
      * Adapter Design Pattern dışarıdaki bir sistemi kendi sisteminize entegre etmeniz gerektiğinde kullanabileceğiniz bir modeldir.
      * Amacı kendi sisteminize entegre ettiğiniz dışardan gelen sistemin kendi sisteminize ait bir sistem gibi çalışmasıdır.
      * Dışardan engtegre ettiğiniz bir sistemi direkt olarak kendi siteminizin içindeki bir metoda referans verirseniz artık
        dışardan gelen sisteme bağımlı olmuşsunuz demektir. Bunu önlemek için Adapter Design Pattern kullanılır.
      * Nesnel programlama, test edilebilirlik gibi durumların bozulmamasını sağlar.
    */

    /*
      * Adapter'ın kullanımını anlatmak için bir senaryo oluşturalım. Farzedin ki Logging için herhangi bir logging yönteminizi
        kullanmaktasınız. Bu logging yönteminin ismi "Some_Logger" olsun.
        İlerleyen zamanlarda Log4Net adlı loglama sisteminin daha iyi olduğunu düşünüp Log4Net'e geçmek istediğinizi farzedin.
        Eğer Some_Logger'ı iş metodlarınızın içine direkt olarak referans vermişseniz, artık Log4Net'e geçebilmek için
        Some_Logger'ı referans ettiğiniz her satırı elle silmeniz gerekmektedir. Bunu kesinlikle istemezsiniz.
    */

    public interface ILogger
    {
        void Log(string message);
    }

    public class Some_Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logger with Some Logger, " + message);
        }
    }

    /*
      * Buradki Log4Net'i NuGet'ten indirdiğinizi farzedin.
        Başkası tarafından yazıldığı için Log4Net class'ının içeriğine dokunamamaktasınız.
        Log4Net bir dll dosyasıdan çağırılmaktadır.
    */
    public class Log4Net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Logger with Log4Net, " + message);
        }
    }

    /*
      * Log4Net'i adapte etmeniz gerekmetedir. Bunun için Log4NetAdapter class'ını tasarlayalım.
        Log4NetAdapter class'ı yapısal olarak kendi sisteminizin özelliklerini taşıyacak ve Log4Net'in
        özelliklerini kendi sisteminize adapte edecek.
    */

    public class Log4NetAdapter : ILogger
    {
        public void Log(string message)
        {
            Log4Net log4net = new Log4Net();
            log4net.LogMessage(message);
        }
    }

    public class ProductManager
    {
        private ILogger _logger;

        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            /*Burada veri tabanına kaydetme kodu olduğunu farzedin.*/
            _logger.Log("User Data");
            Console.WriteLine("Saved.");
        }
    }

}
