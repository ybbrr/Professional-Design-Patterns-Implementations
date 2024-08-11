namespace DesignPatterns.Proxy
{
    /*
      * Bir hesap yaptığınızı farzedin. O hesap daha sonra aynı parametrelerle tekrar yapılırsa yine aynı sonucu verir.
        Bu durumda hesabı tekrarlamak yerine önceki sonucunu tekrar kullanmak daha iyi olacaktır.
    */
   
    public abstract class CreditBase
    {
        public abstract int Calculate();
    }

    public class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= i;
                Thread.Sleep(1000);
            }

            return result;
        }
    }

    public class CreditManagerProxy : CreditBase
    {
        private CreditManager _creditManager;
        private int _cachedData;
        public override int Calculate()
        {
            if (_creditManager == null)
            {
                _creditManager = new CreditManager();
                _cachedData = _creditManager.Calculate();
            }

            return _cachedData;
        }
    }
}
