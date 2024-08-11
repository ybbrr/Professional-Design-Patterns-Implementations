using DesignPatterns.DependencyInjection;

using Ninject;

namespace Apps.Implementations
{
    public static class DependencyInjectionImplementation
    {
        public static void DependencyInjection_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nDependency Injection Design Pattern\n");

            /*
              * EfProductDal'a ve NhProductDal'a bağımlılık yok ama şu an ProductManager'a bu kod parçası
                içinde bağımlılık vardır.
                Buradaki bu bağımlılığı IoC Container ile yok edebilirsiniz.
              * IoC Container ile bir kutu tasarlayabilirsiniz ve o kutunun içine dependency'leri set edebilirsiniz.
                Aslında bunu yaparken arka planda Factory Method ve Factory Design Pattern'lerini kullanan bir yapıya sahiptir.
              * Ninject IoC Container'ı "Apps" adı ile açtığım bu proje içine NuGet paketleri aracılığıyla kurulmuştur.
            */

            IKernel kernel = new StandardKernel();
            kernel.Bind<IProductDal>().To<EfProductDal>().InSingletonScope(); /*Create an instance of EfProductDal*/
            /*Singleton nesnesi olarak da kullanabilirsiniz*/


            ProductManager productManager = new ProductManager(kernel.Get<IProductDal>()); /*Give a instance of IProductDal*/
            productManager.Save();

            productManager = new ProductManager(new NhProductDal());
            productManager.Save();

            Console.WriteLine("\n**************************************************");
        }
    }
}
