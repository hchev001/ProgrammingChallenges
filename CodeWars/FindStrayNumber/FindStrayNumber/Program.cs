using System;
using System.Collections.Generic;

//You are given an odd-length array of integers, in which all of them are the same, except for one single number.

//Implement the method stray which accepts such array, and returns that single different number.

//The input array will always be valid! (odd-length >= 3)

//Examples:

//[1, 1, 2] => 2

//[17, 17, 3, 17, 17, 17, 17] => 3
namespace FindStrayNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.Stray(new int[] { 1, 1, 2 }));
            Console.WriteLine(Solution.Stray(new int[] {17, 17, 3, 17, 17, 17}));
        }
    }

    class Solution
    {
        public static int Stray(int[] numbers)
        {

            Dictionary<int, int> countDic = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++){
                if (countDic.ContainsKey(numbers[i]))
                {
                    int tempCount = countDic[numbers[i]];
                    tempCount++;
                    countDic.Remove(numbers[i]);
                    countDic.Add(numbers[i], tempCount);
                } else
                {
                    countDic.Add(numbers[i], 1);
                }
            }

            // Assumption that there the array does not contain stray counts greater than 300
			KeyValuePair<int, int> temp0 = new KeyValuePair<int, int>(0, 300);
			foreach(KeyValuePair<int, int> entry in countDic)
            {
                if (entry.Value < temp0.Value)
                    temp0 = entry;
            }
            return temp0.Key;
        }
    }
}
