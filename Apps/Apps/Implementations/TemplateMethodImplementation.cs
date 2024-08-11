using DesignPatterns.TemplateMethod;

namespace Apps.Implementations
{
    public static class TemplateMethodImplementation
    {
        public static void TemplateMethod_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nTemplate Method Design Pattern\n");

            ScoringAlgorithm algorithm;
            Console.WriteLine("Men\'s");
            algorithm = new MensScoringAlgorithm();
            Console.WriteLine("Score : " + algorithm.GenerateScore(8, new TimeSpan(0, 2, 25)));

            Console.WriteLine("\nWomen\'s");
            algorithm = new WomensScoringAlgorithm();
            Console.WriteLine("Score : " + algorithm.GenerateScore(8, new TimeSpan(0, 2, 25)));

            Console.WriteLine("\nChildren\'s");
            algorithm = new ChildrensScoringAlgorithm();
            Console.WriteLine("Score : " + algorithm.GenerateScore(8, new TimeSpan(0, 2, 25)));


            Console.WriteLine("\n**************************************************");
        }
    }
}
