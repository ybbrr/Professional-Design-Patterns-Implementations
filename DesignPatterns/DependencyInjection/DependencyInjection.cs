namespace DesignPatterns.DependencyInjection
{
    /*
      * Dependency Injecton Design Pattern bir nesnenin diğer nesneye bağımlılığını minimize etmek, yok etmek için kullanılır.
        Katmanlar arası geçiş yaparken bu desenden çok yararlanılır. Örneğin iş katmanından data access katmanına geçiş yaparken
        iş katmanının data access katmanına bağımlılığının minimize edilmesi hatta yok edilmesi gerekir. 
        Öte yandan bir iş katmanı kodunun kendi içindeki bağımlılığını da minimize etmeyi önerir.
        Aynı zamanda  loglama, cacheleme, security gibi cross cutting concern'lerin de Dependency Injection ile kullanımı çok yoğundur.
    */

    /*
      * ProductDal sınıfı data access layer'ı temsil etsin. (Dal --> data access layer)
      * ProductManager sınıfı bussiness layer'ı temsil etsin.
    */

    public interface IProductDal
    {
        void Save();
    }

    public class EfProductDal : IProductDal
    {
        public void Save()
        {
            /*Burada bir EntityFramework kodu olduğunu farzedin.*/
            Console.WriteLine("Saved with EntityFrameWork. (imitaiton)");
        }
    }

    public class NhProductDal : IProductDal
    {
        public void Save()
        {
            /*Burada bir EntityFramework kodu olduğunu farzedin.*/
            Console.WriteLine("Saved with NHibernate. (imitaiton)");
        }
    }

    public class ProductManager
    {
        /*
          * IProductDal interface'i sayesinde bağımlılık minimize edilecektir.
            IProductDal interface'ni kalıtımladığınız her class'ı aşağıdaki constructor'a parametre geçebilirsiniz.
            Diğer bir deyişle IProductDal interface'i sayesinde yeni bir özellik eklemek için eklemek istediğiniz
            özellikle ilgili class'ı yazıp IProductDal'ı kalıtımlamalısınız.
        */
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Save()
        {
            /*İş kurallarına göre yazılmış bir kod olduğunu farzedin.*/
            /*
              * Şimdi burada yukarıdaki ProductDal sınıfını new'lerseniz kesinlikle işinizi görür ama
                gelecekte EntityFramework'ten başka bir framework'e geçmek isterseniz ProductManager'in içinceki
                Save() fonksiyonunu yazdığınız her yeri değiştirmeniz gerekecek. Binlerce satırı düzenlemeniz gerekebilir.
            */
            _productDal.Save();
        }
    }
}
