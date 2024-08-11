namespace DesignPatterns.Command
{
    /*
      * Çok kullanışlıdır. Aslında günlük hayatta yoğunlukla kullanırız. Bir metin editörü açtığınız bir şeyler yazıp
        kaydedip tekrar bir şeyler yazarsınız. Tüm bu değişiklikleri metin editörünüz aslında bir listede tutar.
        Bu sayede Ctrl+Z basarak istediğiniz değişiklikleri geri alabilmektesiniz.
        Bu durumu bir robot programlamada robotun geri adım atması, sağa sola dönmesi gibi işlemler için de düşünebilirsiniz.
        Veya bir otomasyon sisteminde kullanıcının yaptığı hemen veri tabanına göndermeyip işlemleri listeleyip
        daha sonra göndermek için de Command Design Pattern kullanılabilir.
      
      * Burada bir stock takip sistemi tasarlanacaktır.
    */
    public class StockManager
    {
        /*Bilgilerin çekileceği bir veritabanı olamdığı değerler elle girilmiştir.*/
        private string _name = "Laptop";
        int _quantity = 10;

        public void Buy()
        {
            Console.WriteLine($"Stock --> Product : {_name} - Quantity : {_quantity}, bought");
        }

        public void Sell()
        {
            Console.WriteLine($"Stock --> Product : {_name} - Quantity : {_quantity}, sold");
        }
    }

    /*
      * Komut sınıflarını tanımlayınız.
      * Komut sınıflarını tanımlamak için interface'ten veya abstract class'tan yararlanabilirsiniz. Bu size kalmıştır.
      * Aşağıda stock yönetimi için BuyStock ve SellStock komutları programlanmıştır, siz bu komutları bir
        robot progralama işi için "ileri git, geri git, sağa sola git" gibi komutlar olarak da düşünebilirisiniz.
    */

    public interface IOrder
    {
        void Execute();
    }

    public class BuyStock : IOrder
    {
        private StockManager _stockManager;

        public BuyStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public void Execute()
        {
            _stockManager.Buy();
        }
    }

    public class SellStock : IOrder
    {
        private StockManager _stockManager;

        public SellStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public void Execute()
        {
            _stockManager.Sell();
        }
    }

    /*
      * Komutlar yukarıda tanımlanmıştır.
        Artık komutların toplanacağı bir nesneye ihtiyaç vardır.
    */

    public class StockController
    {
        private List<IOrder> _orders = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            _orders.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (IOrder order in _orders)
            {
                order.Execute();
            }
            
            _orders.Clear();
        }
    }
}
