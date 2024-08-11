namespace DesignPatterns.Facade
{
    public interface ILogging
    {
        void Log();
    }

    public class Logging : ILogging
    {
        public void Log()
        {
            /*Burada logging yapan bir kod olduğunu farzedin.*/
            Console.WriteLine("Logged. (imitation)");
        }
    }

    public interface ICaching
    {
        void Cache();
    }

    public class Caching : ICaching
    {
        public void Cache()
        {
            /*Burada caching yapan bir kod olduğunu farzedin.*/
            Console.WriteLine("Cached. (imitation)");
        }
    }

    public interface IAuthorize
    {
        void CheckUser();
    }

    public class Authorize : IAuthorize
    {
        public void CheckUser()
        {
            /*Burada authorization yapan bir kod olduğunu farzedin.*/
            Console.WriteLine("User Checked. (imitation)");
        }
    }

    /*
      * İş katmanında Logging, Caching, Authorization özelliklerinin kullanılacağını farzedin.
      * CustomerManager iş katmanında bir iş sınıfıdır, diğer bir deyişle iş katmanını temsil etmektedir.
      * Logging, Caching, Authorize sınıflarının bir interface'i olduğu için dependecy injection
        yöntemi burada kullanılabilir.
    */
    public class CustomerManager
    {
        /*
          * Logging, Caching, Authorization işlemleri "Cross Cutting Concern" olarak ifade edilebilir.
          * "Cross Cutting Concern" uygulamanın çalışma tememllerini dikine kesen, uygulmanın çalışma temelleri ile
            ortak ve ilişkili olan işlemlere denir.
          * Logging, Caching, Authorization işlemleri için tanımladığım sınıfların birer interface'i
            olduğu için burada dependency injection yöntemi uygulanabilir.

                Bu üç class'ı Dependency Injection etseydik CustomerManager class'ı aşağıdaki gibi olurdur.
                
             """
                private ILogging _logging;
                private ICaching _caching;
                private IAuthorize _authorize;

                public CustomerManager(ILogging logging, ICaching caching, IAuthorize authorize)
                {
                    _logging = logging;
                    _caching = caching;
                    _authorize = authorize;
                }

                public void Save()
                {
                    _caching.Cache();
                    _authorize.CheckUser();
                    _logging.Log();
                    Console.WriteLine("Saved. (imitation)");
                }
            """

          * Bunun yerine Logging, Caching, Authorize class'ları başka bir class altında toplanıp new'lenecektir.
          * Oluşturulan yeni class ise CustomerManager class'ı içinde new'lenecektir.
          * Oluşturulacak yeni class'ın ismi "CrossCuttingConcernsFacade" olsun.
        */

        private CrossCuttingConcernsFacade _concerns;

        public CustomerManager()
        {
            _concerns = new CrossCuttingConcernsFacade();
        }

        public void Save()
        {
            _concerns.Caching.Cache();
            _concerns.Authorize.CheckUser();
            _concerns.Logging.Log();
            Console.WriteLine("Saved. (imitation)");
        }
    }

    /*
      * Farzedin ki daha sonradan Validation işlemine de ihtiyaç duyuldu.
        Validation işlemi için de bir interface ve class tanımlayarak aşağıdaki CrossCuttingConcernsFacade'e ekleyebilirsiniz.
    */

    public class CrossCuttingConcernsFacade
    {
        public ILogging Logging { get; set; }
        public ICaching Caching { get; set; }
        public IAuthorize Authorize { get; set; }

        public CrossCuttingConcernsFacade()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
        }
    }
}
