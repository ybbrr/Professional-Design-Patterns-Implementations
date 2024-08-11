using System.Collections;

namespace DesignPatterns.Composite
{
    /*
      * Bir kurumdaki çalışsanların ve o çalışanların hiyerarşisinin modelleneceğini farzedin.
    */
    public class Composite
    {
    }

    /*
      * Kurum çalışanlarını programlayın. Her kurum çalışsanı aslında bir kişidir, insandır (Person).
      * IPerson interface'ine her kişinin sahip olacağı sabit bilgileri yazın.
    */
    public interface IPerson
    {
        string Name { get; set; }
    }

    public class Contractor : IPerson
    {
        public string Name { get; set; }
    }

    /*
      * Employee nesnesini foreach ile kullanabilmke için IEnumerable interface'i implemente edildi. 
    */
    public class Employee : IPerson, IEnumerable<IPerson>
    {
        /*Hiyerarşik yapıda astları tutacak liste.*/
        private List<IPerson> _subordinates = new List<IPerson>();
        public string Name { get; set; }

        public void AddSubordinates(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubordinates(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public IEnumerator<IPerson> GetEnumerator()
        {
            return _subordinates.GetEnumerator();

            //foreach (var subordinate in _subordinates)
            //{
            //    yield return subordinate;
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
