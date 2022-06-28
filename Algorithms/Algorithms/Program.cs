using System;
namespace Algorithms
{
    class program
    {
        public static void Main(String[] args)
        {
            string firstString, secondString;
            //Gets words from user.  
            Console.WriteLine("Enter first string");
            firstString = Console.ReadLine();
            Console.WriteLine("Enter second string");
            secondString = Console.ReadLine();
            Algorithms.Anagram anagram = new Algorithms.Anagram();
            //Check if words are anagram  
            if (anagram.AnagramSort(firstString, secondString) == true)
            {
                Console.WriteLine("Both string are anagram string.");

            }
            else
            {
                Console.WriteLine("Both string are not anagram string.");

            }
            Console.ReadLine();

        }
    }
}