using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //Done  TODO: Create an integer Array of size 50
            var numbers = new int[50];

            //Done  TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            //Done  TODO: Print the first number of the array
            Console.WriteLine(numbers[0]);

            //Done  TODO: Print the last number of the array
            Console.WriteLine(numbers[numbers.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //Done  UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) Done  First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Array.Reverse(numbers);

            Console.WriteLine($"All Numbers Reversed:");
            NumberPrinter(numbers);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //Done  TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            //Done  TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Array.Sort(numbers);
            Console.WriteLine("Sorted numbers:");
            NumberPrinter(numbers);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Done  TODO: Create an integer List
            var numberList = new List<int>();

            //Done  TODO: Print the capacity of the list to the console
            Console.WriteLine(numberList.Capacity);

            //Done  TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numberList);

            //Done  TODO: Print the new capacity
            Console.WriteLine(numberList.Capacity);

            Console.WriteLine("---------------------");

            //Done  TODO: Create a method that prints if a user number is present in the list
            //Done  Remember: What if the user types "abc" accident your app should handle that!
            bool isAnswer = true;
            int searchNumber;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                int.TryParse(Console.ReadLine(), out searchNumber);
            } while (!isAnswer);
            
            NumberChecker(numberList, searchNumber);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Done  UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");


            //Done  TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numberList);
            Console.WriteLine("------------------");

            //Done  TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numberList.Sort();
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            //Done  TODO: Convert the list to an array and store that into a variable
            var numberListCopy = numberList.ToArray();
            

            //Done  TODO: Clear the list
            numberList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }

                Console.WriteLine(numbers[i]);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for(int i = numberList.Count -1; i >= 0; i--)
            {
                if(numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]); ;
                }
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
                if (numberList.Contains(searchNumber))
                {
                    Console.WriteLine($"You searched for number {searchNumber}. {searchNumber} was found in the numberList!");
                }
                else
                {
                    Console.WriteLine($"You searched for number {searchNumber}. I'm sorry, {searchNumber} was not found in the numberList.");
                }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                int randomListNumber = rng.Next(0, 51);
                numberList.Add(randomListNumber);
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
             int randomNumber = rng.Next(0, numbers.Length);
             numbers[i] = randomNumber;
            }

        }        

       private static void ReverseArray(int[] array)
       {
            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            { 
                int reverseNumber = array[start];
                array[start] = array[end];
                array[end] = reverseNumber;

                start++;
                end--;
            }
       }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
