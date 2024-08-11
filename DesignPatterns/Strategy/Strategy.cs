namespace DesignPatterns.Strategy
{
    /*
      * Strateji belirleyip o stratejiye göre o metodun çalıştırılması sürecidir.
      * Burada bir iş katmanında belirli bir mevzuata  bir hesaplamayı gerçekleştireceğimizi farzedin.
        Bu bir bankacılık uygulaması olabilir.
        Eski müşterileriniz ile yeni müşterilerinize farklı türlerde kredi hesaplama süreçleri uyguladığınızı farzedin.
        Normal şartlarda if komutları kullanarak metodun içinde bir sürü algoritma yazmak gerekir. Bunun yerine
        Strategy Design Pattern'i kullanılabilir.
    */
    public abstract class CreditCalculatorBase
    {
        public abstract void Calculate();
    }

    /*
      * Aşağıda Base class'ın concrete class'larını tanımlanmıştır.
    */

    public class Before2010CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using Before2010CreditCalculator.");
        }
    }

    public class After2010CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using After2010CreditCalculator.");
        }
    }

    /*
      * Aşağıda işi gerçekleştirecek class tanımlanmıştır.
    */

    public class CustomerManager
    {
        public CreditCalculatorBase creditCalculatorBase { get; set; }
        public void SaveCredit()
        {
            Console.WriteLine("Customer manger business");

            /*
              * Eğer yukarda yaptığmız base ve conrate class tanımlamaları ile Strategy Design Pattern'nini kullanmaya
                çalışmasydık burada bir sürü if komutu yazarak oluşabilecek durumları denetlemek gerekecekti,
                Yukarıda tanımlanan "CreditCalculatorBase" adlı base class'ı buraya enjecte ederek
                CreditCalculator class'larını burada istediğimiz gibi new'leyerek stratejinizi if kullanmadan gerçekleştirebilirsiniz.
            */

            creditCalculatorBase.Calculate();
        }
    }
}
