namespace DesignPatterns.SingletonDesignPattern
{
    /*
      * Buradaki Singleton Desing Pattern kodu Thread Safe olarak yazılmıştır.
      * Thread Safe kod yazmak önemlidir ve amacı şudur, bilgisayar düyasında nano saniyeler mertebesinden tek seferde tek işlem yapılır
        ama bazan iki işlem arka arkaya o kadar hızlı gelir ki bir işlem diğer işleminin okuması gerken alanı silmiş veya değiştirmiş olabilir.
        Bu tür durumların olmasını engellemek için Thread Safe kod yazarız.
      * İki kullanıcı arka arkaya Singleton Nesnesi üretmek isterse henüz biri Singleton nesnesi new'lemeye çalışırken diğer kullanıcı çoktan
        ilk kullanıcıdan birazcık sonra Singleton nesnesi new'lemeye başlayıp ilk kullanıcdan önce new'lemeyi tamamlamayabilir. 
        Bu esnada ilk kullanıcının tabii ki oluşan Singleton nesnesinden haberi olmaz ve o da new'leme işlemini tamamlayarak bir Sinleton nesnesi
        daha oluşturur. Bunu öncelemek için Thread Safe kod yazılmalırdır.
    */
    public class Singleton_ThreadSafe
    {
        /*
          * Static bir Singleton nesnesi değişkeni oluşturulur. Daha sonra bu nesne new'lenecektir.
        */
        private static Singleton_ThreadSafe singleton_ThreadSafe;

        /*
          * Thread Safe kod yazmak için Dot.Net'in Thread Kütüphanesinden yararlanılır.
          * Burada bir bilgisayar miamari bilgisi vermekte yarar vardır, Thread işlemlerine dair her şey 
            hem yazılımsal hem de donanımsal olarak tasarlanmıştır.
         */
        private static object _lockObject = new object();

        /*
          * Private bir constructor tanımlanır bu sayede constructor'a dışardan erişilemez
            Contructor'a dışarıdan erişilememesi bu nesnenin dışarıda new'lenemeyeceği anlamına gelir.
        */
        private Singleton_ThreadSafe()
        {
        }

        /*
          * Public contuructor'ı yaxdıktan sonra Singleton instance'ını oluşturacak bir static metod yazılır
          * Bu metod dönüş tipi olarak sınıfın kendisini döndürür. Burada sınıf ismi olarak "Singleton" verilmiştir
            ama tabii ki bu sınıfın ismi kullanılcağı amaca göre verilebilir.
        */
        public static Singleton_ThreadSafe CreateAsSingletonThreadSafe()
        {
            /*
              * Burada yukarıda oluşturulan Singleton nesnesi değişkeni new'lenir. 
              * New'lenmeden önce daha önce new'lenmiş mi kontrol edilir.
            */

            lock (_lockObject) 
            { 
                if (singleton_ThreadSafe == null) singleton_ThreadSafe = new Singleton_ThreadSafe();
            }

            return singleton_ThreadSafe;

            /*
              * Bu metod içindeki kod parçası aşağdaki gibi tek satırda halledilebilir.
                --> return singleton_ThreadSafe ?? ( singleton_ThreadSafe = new Singleton() );
              * Buradaki çift soru işareti (??) kendinden önce gelen değişkenin null olup olmadığına bakmak için kullanılan bir kısaltmadır.
                Çift soru işareti singleton adlı değişkenin null olup olmadığına bakar, null değilse değişkenin kendisini döndürür,
                eğer null ise parantez içine alınmış kısmı, diğer bir deyişle new'leminin yapıldığı yeri, döndürür.
            */
        }

        /*
          * Artık sınıfın gerçekleştireceği işlemler eklenebilir. 
            Aşağıdaki metodlar örnek maçlı yazılmıştır. 
        */
        public void Save()
        {
            Console.WriteLine("****Saving imitation****");
        }

        public void Update()
        {
            Console.WriteLine("****Updating imitation****");
        }

        public void Delete()
        {
            Console.WriteLine("****Deleting imitation****");
        }
    }
}
