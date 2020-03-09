using System;

namespace AlgorithmDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoSum = new TwoSum();
            var result = twoSum.FindTwoSumBasic();
            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }

            var result2 = twoSum.FindTwoSum();
            foreach (var item in result2)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
