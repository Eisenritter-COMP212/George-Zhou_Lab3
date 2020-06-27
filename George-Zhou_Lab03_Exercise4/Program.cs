using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace George_Zhou_Lab03_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // create sorted dictionary based on user input
            SortedDictionary<string, int> dictionary = CollectWords();

            DisplayDictionary(dictionary); // display sorted dictionary content
        }
        private static SortedDictionary<string, int> CollectWords()
        {
            // create a new sorted dictionary
            var dictionary = new SortedDictionary<string, int>();

            Console.WriteLine("Enter a string: "); // prompt for user input
            string input = Console.ReadLine(); // get input

            // split input text into tokens
            string[] words = Regex.Split(input, @"\s+");

            // processing input words
            foreach (var word in words)
            {
                var key = word.ToLower(); // get word in lowercase

                // if the dictionary contains the word
                if (dictionary.ContainsKey(key))
                {
                    ++dictionary[key];
                }
                else
                {
                    // add new word with a count of 1 to the dictionary
                    dictionary.Add(key, 1);
                }
            }

            return dictionary;
        }

        // display dictionary content
        private static void DisplayDictionary<K, V>  (
           SortedDictionary<K, V> dictionary) 
        {
            Console.WriteLine(
               $"\nSorted dictionary contains:\n{"Key",-12}{"Value",-12}");

            // generate output for each key in the sorted dictionary
            // by iterating through the Keys property with a foreach statement
            foreach (var key in dictionary.Keys)
            {
                try { 
                if(Int32.Parse(dictionary[key].ToString()) > 1)
                Console.WriteLine($"{key,-12}{dictionary[key],-12}");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine($"\nsize: {dictionary.Count}");
        }
    }
}
