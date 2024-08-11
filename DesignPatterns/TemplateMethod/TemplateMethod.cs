namespace DesignPatterns.TemplateMethod
{
    /*
      * Template Method Design Pattern çok sık kullanılır. Bir iş katmanında iş süreçlerini kontrol adltına aldığınızı, 
        bir metod içerisinde farklı operasyonlarınızın olduğunu farzedin. Bu farklı operasyonların herbirini
        farklı metodlarla çağırabilirsiniz. Fakat bu metotların içindeki her bir işlem farklı durumlara göre farklı davranıyorsa
        bunları denetlemek için iç içe bir sürü if komutu yazmanız gerekir.
        Template Method Design Pattern ile hızlıca bir şablon oluşturup o şablonun soyutlanması ve o soyuta somutların(concrete)
        atanması şeklinde bu işlemi gerçekleştirebilirsiniz.
      * Buradaki örnek olarak bir bilgisayar oyununda kadın, erkek ve çocuk oyuncular için puanların farklı şekilde hesaplandığını farzedin.
    */
    public abstract class ScoringAlgorithm
    {
        public int GenerateScore(int hits, TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CalculateOverallScore(score, reduction);
        }

        public abstract int CalculateBaseScore(int hits);
        public abstract int CalculateReduction(TimeSpan time);
        public abstract int CalculateOverallScore(int score, int reduction);
    }

    public class MensScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }
        
        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }
    }

    public class WomensScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 130;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 4;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }
    }

    public class ChildrensScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 120;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 3;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }
    }
}
