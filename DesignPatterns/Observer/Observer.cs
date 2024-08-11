namespace DesignPatterns.Observer
{
    /*
      * Observer Design Pattern'i sıklıkla kullanılabilir. Observer Design Pattern'i kendisine abone olan sistemlerin, bir işlem olduğunda
        devreye girmesini sağlayan bir tasarım desenidir. Örneğin bir alışveriş sisteminde ürünün fiyatı düştüğünde haber almak isteyebilirler,
        böyle bir durum için Observer Design Pattern kullanılabilir.
    */

    public abstract class Observer
    {
        public abstract void Update();
    }

    public class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to Customer : Product price changed.");
        }
    }

    public class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to Employee : Product price changed.");
        }
    }

    public class ProductManager
    {
        /*
          * Üründe bir güncelleme olduğunda observer nesnesi bundan haberdar olacak ve kendini işleme sokacak.
          * ProductManager class'ının içinde bu class'a abone olan class'ların listesini tutmalıyız.
        */

        private List<Observer> _observers = new List<Observer>();

        public void UpdatePrice()
        {
            Console.WriteLine("Product price changed.");
            Notify();
        }

        /*
          * Bu tasarım deseninde üç tane temel operasyon vardır.
        */

        /*Abone ekleyen operasyon*/
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        /*Abone silen operasyon*/
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        /*Bütün abonelerin bilgilendirilmeisni sağlayan operasyon*/
        private void Notify()
        {
            foreach (Observer observer in _observers)
            {
                observer.Update();
            }
        }
    }

}
