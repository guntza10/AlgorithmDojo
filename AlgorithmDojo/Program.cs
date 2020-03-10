using System;

namespace AlgorithmDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            // var twoSum = new TwoSum();
            // var result = twoSum.FindTwoSumBasic();
            // foreach (var item in result)
            // {
            //     Console.WriteLine($"{item}");
            // }

            // var result2 = twoSum.FindTwoSum();
            // foreach (var item in result2)
            // {
            //     Console.WriteLine($"{item}");
            // }

            var addTwoSum = new AddTwoSum();
            var result = addTwoSum.AddTwoNumber();
            var count = 0;
            foreach (var item in result)
            {
                count++;
                if (count < result.Count)
                {
                    Console.Write($"{item.val} -> ");
                }
                else
                {
                    Console.WriteLine($"{item.val}");
                }
            }

            var result2 = addTwoSum.AddTwoNumberBasic();
            var count2 = 0;
            foreach (var item in result2)
            {
                count2++;
                if (count2 < result.Count)
                {
                    Console.Write($"{item} -> ");
                }
                else
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
}
