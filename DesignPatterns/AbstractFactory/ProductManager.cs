namespace DesignPatterns.AbstractFactory
{
    /*
      * Normalde hiçbir sınıfın çıplak kalması diğer bir deyişle bir interface'ten veya abstract class'tan kalıtımlanmaması
        iyi değildir, bu durum gelecekte nesne yönelimli programlama zafiyatları oluşturur ama burada sadece
        Abstract Factory Design Pattern'in kullanımı anlatıldığı için aşağıdaki bu ProductManager class'ı çıplak bırakılmıştır.
      * ProductManager class'ı burada iş katmanını temsil etmektedir.
    */
    public class ProductManager
    {
        private CrossCuttingConcernsFactory crossCuttingConcernsFactory;
        private Logging logger;
        private Caching caching;

        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            this.crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            logger = this.crossCuttingConcernsFactory.CreateLogger();
            caching = this.crossCuttingConcernsFactory.CreateCaching();
        }

        public void GetAll()
        {
            /*
              * Bu metodun içinde tüm ürünleri listeleyen bir kod olduğunu farzedin.
              * Listeme hakkında Logging ve Caching işlemleri yapılacaktır.
            */
            logger.Log("Log");
            caching.Cache("Data");
            Console.WriteLine("Products Listed. (imitation)");

        }
    }
}
