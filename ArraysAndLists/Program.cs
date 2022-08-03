using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numArray[1]);

            List<int> newList = new List<Int32>();
            newList.Add(6);
            newList.Add(100);
            Console.WriteLine(newList[1]);
        }
    }
}