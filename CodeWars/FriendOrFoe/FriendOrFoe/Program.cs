using System;
using System.Collections.Generic;
using NUnit.Framework;
namespace FriendOrFoe
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] expected = {"Ryan", "Mark"};
            string[] names = {"ryan", "Kieran", "Mark", "Jimmy"};
            CollectionAssert.AreEqual (expected, Kata.FriendOrFoe (names));
        }
    }

    public static class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> friends = new List<string>();
            foreach (string name in names)
            {
                if (name.Length == 4)
                    friends.Add(name);
            }

            return friends;
        }
    }
}