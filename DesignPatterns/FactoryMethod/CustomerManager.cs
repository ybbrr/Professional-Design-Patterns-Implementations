namespace DesignPatterns.FactoryMethod
{
    public class CustomerManager
    {
        /*Burada bir injection yapılmaktadır.*/
        private ILoggerFactory loggerFactory;

        public CustomerManager(ILoggerFactory loggerFactory)
        {
            this.loggerFactory = loggerFactory;
        }

        public void Save()
        {
            /*
              * Şimdi burada yazılabilecek kötü türden bir kod parçasının temsilini yapayım ve açıklayayım.
              * Farz edin ki aşağıdaki gibi ihtiyacınız olan Logger türünü burada new'lediniz.
                --> ILogger logger = new My_Own_Logger();
                Bunu burada bu şekilde new'leyerek CustomerManager class'ını tamamiyle My_Own_Logger'a bağımlı hale getirirsiniz.
                Kendinize "Bunu burada gerçekten new'lemek zorundamıyım?" diye sorun.
            */

            /*
              * Aşağıdaki kod parçasına bir bakın. ILogger üzerinden LoggerFactory'nin yaratıcı metodunu diğer bir deyişle,
                Factory Method'unu çağrıldı, bunun anlamı ilgili nesneyi Fabrika türetecektir.
                Bu sayede ne My_Own_Logger'a ne de OracleLogger'a bağımlıyız. Instance üretirken ikisine de bağımlı olma sorunu çözüldü.
            */
            Console.WriteLine("Saved! (imitation)");
            ILogger logger = this.loggerFactory.CreateLogger();
            logger.Log();
        }
    }
}
