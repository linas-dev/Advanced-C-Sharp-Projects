using System;
using System.Collections.Generic;

namespace ArraysAssignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("One Dimensional Array of Strings");
            string[] arrayOfStrings = 
            {
                "Linas",
                "Pitman Training",
                "Cars",
                "Food"
            };
            Console.WriteLine("Please enter a number from 0 to 3");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Your selection is " + arrayOfStrings[userInput]);
            Console.WriteLine("");
            
            Console.WriteLine("One Dimensional Array of Integers");
            int[] arrayOfNumbers = { 10, 5, 15, 20, 30 };
            Console.WriteLine("Please enter a number from 0 to 4");
            int userInputNumbers = Convert.ToInt32(Console.ReadLine());
            if (userInputNumbers <= 4)
            {
                Console.WriteLine($"Your selected number {userInputNumbers} at index is: " + arrayOfNumbers[userInputNumbers]);
            }
            else
            {
                Console.WriteLine($"Your selected number: {userInputNumbers} is out of range");
            }
            Console.WriteLine("");
            
            
            Console.WriteLine("One Dimensional List of Strings");
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("MSI");
            listOfStrings.Add("Apple");
            listOfStrings.Add("Samsung");
            listOfStrings.Add("Nokia");
            listOfStrings.Add("Huawei");
            
            Console.WriteLine("Please enter a number from 0 to 4");
            int userInp = Convert.ToInt32(Console.ReadLine());
            if (listOfStrings.Count > userInp )
            {
                Console.WriteLine($"Your selections is: {listOfStrings[userInp]}");
            }
            else
            {
                Console.WriteLine($"Is out of range");
            }

            Console.ReadLine();
        }
    }
}