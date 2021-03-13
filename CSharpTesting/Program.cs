using System;
using System.Linq;

namespace CSharpTesting
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Count80();
            TestDelegate();
            TestLambda();

            Console.ReadKey();
        }

        private static void Count80()
        {
            // Data source.
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // The call to Count forces iteration of the source
            int highScoreCount = scores.Where(n => n > 80).Count();

            Console.WriteLine("{0} scores are greater than 80", highScoreCount);

            // Outputs: 4 scores are greater than 80
        }

        private static void TestDelegate()
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));
        }

        private static void TestLambda()
        {
            int[] number = { 2, 3, 4, 5 };
            var squaredNumbers = number.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));
        }
    }
}
