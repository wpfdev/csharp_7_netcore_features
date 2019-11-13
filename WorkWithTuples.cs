using System;
using System.Linq;

namespace csharp_7_features_notes
{
    public class WorkWithTuples : ITestableClass
    {
        public static (double average, int employeeCount, bool isBelowMROT) GetaverageAndCount(int[] salarys, double mrot)
        {
            var result = (avg: 0D, eCount: 0, blwMROT: false);
            result = (result.avg = (double)salarys.Sum() / salarys.Count(), result.eCount = salarys.Count(), result.blwMROT = result.avg.CheckIfBelowMROT(mrot));
            return result;
        }

        public void RunTest()
        {
            var salaries = new[] { 10, 12, 15, 11 };
            var mrot = 11.280;
            var (average, employeeCount, isBelowMROT) = WorkWithTuples.GetaverageAndCount(salaries, mrot);
            Console.WriteLine($"Average salary is {Math.Round(average, 2)}{(isBelowMROT ? " (Below MROT!)" : string.Empty)} across {employeeCount} employees");
        }
    }
    public static class DoubleExtensions
    {
        public static bool CheckIfBelowMROT(this double classAverage, double mrot)
        {
            return classAverage < mrot;
        }
    }

}