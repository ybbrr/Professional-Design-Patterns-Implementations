namespace DesignPatterns.ChainOfResponsibility
{
    /*
      * Chain of Responsibility Design Pattern hiyerşik nesne oluşturmak için kullanılır. Chain of Responsibility Design Pattern'i belli şarta göre,
        devreye hangi nesneyi koyacağınızı gösterir. Bu nesnelerin arasında hiyerarşik biryapılanma vardır. 
      * Örnek olarak bir şirkette olduğunuzu farzedin ve harcamalar yapmaktasınız, eğer bu harcamalar 100 liranın altındaysa
        müdürünüz harcamaya yetki verebilmektedir ama bu harcamalar 100 liranın üzerindeyse başkan yardımcısı karar verebilmektedir.
        1000 liranın üstündeki bütün harcamalra ise başkan onay verebilmektedir. 
    */

    /*Harcama bilgilerini bir arada tutan class tanımı*/
    public class Expense
    {
        public string Detail { get; set; }
        public decimal Amount { get; set; }
    }

    /*Harcamayı yönetecek kişiler için oluşuturlmuş base class*/

    public abstract class ExpenseHandlerBase
    {
        /*
          * Hiyerarşinin yönetileceği property'e ihtiyaç vardır.
        */
        protected ExpenseHandlerBase Succesor;

        public abstract void HandleExpense(Expense expense);

        /*
          * Üst yetkili kişinin olayı devralaması.
        */
        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            Succesor = successor;
        }
    }

    public class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount <= 100)
            {
                Console.WriteLine("Manager handled the expense.");
            }
            else if (Succesor != null)
            {
                Succesor.HandleExpense(expense);
            }
        }
    }

    public class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount <= 1000)
            {
                Console.WriteLine("Vice President handled the expense.");
            }
            else if (Succesor != null)
            {
                Succesor.HandleExpense(expense);
            }
        }
    }

    public class President : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 1000)
            {
                Console.WriteLine("President handled the expense.");
            }
            else if (Succesor != null)
            {
                Succesor.HandleExpense(expense);
            }
        }
    }
}
