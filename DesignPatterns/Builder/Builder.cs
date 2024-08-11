using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    /*
      * Builder Design Pattern'inde en temel olay bir nesnedir. Burada amaç bir model üretmek ve Üretilen modelin
        birbiri ardına gelen sıralı işlemlerle oluşturulmasını sağlamaktır.
      * Bir E-ticaret sitesi için farklı türlerde kullanıcılara farklı indirim bilgileri göstereceğinizi farzedin.
        Bunun için ProductViewModel adında bir class (nesne bile denebilir) tasarlandı. Bu class içindeki bilgiler ekran kullanıcıya
        gösterilecek bilgilerdir.
    */
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public double DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }   
    }

    /*
      * Yukarıdaki View Model'i üretecek bir iş tanımına ihtiyaç vardır. Bu iş tanımıda kendi içinde çeşitli işlemleri barındırmalıdır.
        Bu işlemlere örnek olarak temel ürün bilgilerinin çekilmesi verilebilir.
      * Aslında bu iş tanımı abstract Builder'ın kendisidir.
      * Oluşturulan bu abstract Builder üzerinden yeni Builder'lar türetilebilir çünkü abstract class olarak oluşturduk.
        Nesne yönelimli programlamanın güçülü yanıdır bu.
    */
    public abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetModel();

    }

    /*
      * Builder'ların new'lenmesini sağlayacak yapı (director) oluşturulmalıdır.
        Director new'lemenin olması gereken sıra ile gerçekleşmesini sağlayacaktır.
    */
    public class ProductDirector
    {
        /*
          * GenerateProduct() metoduna arguman tipi olarak ProductBuilder geçilmiştir.
            Bu sayede NewCustomerProductBuilder ve OldCustomerProductBuilder tipindeki nesneler 
            bu metoda parametre geçilebilecektir.
        */
        public void GenerateProduct(ProductBuilder productBuilder)
        {
            /*
              * Burada ProductBuilder içinde tanımlanan bu iki metodun her zaman bu sıra ile çalılması kesinleştirildi.
            */
            productBuilder.GetProductData();
            productBuilder.ApplyDiscount();
        }
    }
}
