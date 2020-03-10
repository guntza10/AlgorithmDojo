using System;
using System.Linq;
using System.Collections.Generic;

namespace AlgorithmDojo
{
    public class TwoSum
    {
        public int Target = 22;
        public int[] arrayNumbers = new int[] { 2, 7, 11, 15 };
        public List<int> listNumbers = new List<int> { 2, 7, 11, 15 };

        public int[] FindTwoSumBasic()
        {
            int[] arrayTwoSum = new int[2];
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                for (int j = 0; j < arrayNumbers.Length; j++)
                {
                    if (j > i)
                    {
                        var result = arrayNumbers[i] + arrayNumbers[j];
                        if (result == Target)
                        {
                            arrayTwoSum[0] = i;
                            arrayTwoSum[1] = j;
                        }
                    }
                }
            }
            return arrayTwoSum;
        }

        public List<int> FindTwoSum()
        {
            var numberLst = listNumbers;
            var listResult = numberLst.Where(it => listNumbers.Any(x => x + it == Target && x != it)).ToList();

            var indexTwoSum = listResult.Select(it =>
             {
                 var index = listNumbers.FindIndex(x => x == it);
                 return index;
             })
             .ToList();
            return indexTwoSum;
        }

    }
}