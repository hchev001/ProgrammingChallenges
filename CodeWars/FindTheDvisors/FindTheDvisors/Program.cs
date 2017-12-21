using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace FindTheDvisors
{
    [TestFixture]
    internal class Program
    {
        public static void Main(string[] args)
        {
			//SampleTests();

			Console.WriteLine(string.Join(",", (Kata.Divisors(253))));
			Console.WriteLine(string.Join(",", (Kata.Divisors(15))));
			Console.WriteLine(string.Join(",", (Kata.Divisors(16))));
			Console.WriteLine(string.Join(",", (Kata.Divisors(24))));
        }
        
        [Test]
        public static void SampleTests()
        {
            Assert.AreEqual(new int[] {3, 5}, Kata.Divisors(15));
            Assert.AreEqual(new int[] {2, 4, 8}, Kata.Divisors(16));
            Assert.AreEqual(new int[] {11, 23}, Kata.Divisors(253));
            Assert.AreEqual(new int[] {2, 3, 4, 6, 8, 12}, Kata.Divisors(24));
        }
    }
    
    public class Kata
    {
        public static int[] Divisors(int n)
        {
            List<int> divisors = new List<int>();
            for (int i = 2; i < n; i++){
                if ( (n % i) == 0)
                    divisors.Add(i);
            }
    
            return (divisors.Count == 0) ? null : divisors.ToArray();
        }
    }
}