namespace DesignPatterns.SingletonDesignPattern
{
    /*
      * Buradaki Singleton Design Pattern kodu doğru şekilde yazılmıştır ama Thread Safe değildir.
      * Thread Safe olanı başka bir class dosyası içinde yazılacaktır.
     */
    public class Singleton
    {
        /*
          * Static bir Singleton nesnesi değişkeni oluşturulur. Daha sonra bu nesne new'lenecektir.
        */
        private static Singleton singleton;

        /*
          * Private bir constructor tanımlanır bu sayede constructor'a dışardan erişilemez
            Contructor'a dışarıdan erişilememesi bu nesnenin dışarıda new'lenemeyeceği anlamına gelir.
        */
        private Singleton() 
        {
        }

        /*
          * Public contuructor'ı yaxdıktan sonra Singleton instance'ını oluşturacak bir static metod yazılır
          * Bu metod dönüş tipi olarak sınıfın kendisini döndürür. Burada sınıf ismi olarak "Singleton" verilmiştir
            ama tabii ki bu sınıfın ismi kullanılcağı amaca göre verilebilir.
        */
        public static Singleton CreateAsSingleton()
        {
            /*
              * Burada yukarıda oluşturulan Singleton nesnesi değişkeni new'lenir. 
              * New'lenmeden önce daha önce new'lenmiş mi kontrol edilir.
            */

            if (singleton == null) singleton = new Singleton();
            
            return singleton;

            /*
              * Bu metod içindeki kod parçası aşağdaki gibi tek satırda halledilebilir.
                --> return singleton ?? ( singleton = new Singleton() );
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