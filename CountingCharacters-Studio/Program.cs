using System;
using System.Collections.Generic;
using System.IO;

namespace CountingCharacters_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for Case Sensitive
            Console.Write("Case-Sensitive? (y/N): ");
            string input = Console.ReadLine();
            bool caseSense = false;
            if(Equals(input, "Y") || Equals(input, "y") || Equals(input, "Yes") || Equals(input, "yes"))
            {
                caseSense = true;
            }

            // Ask if file to read in 
            Console.Write("Do you have a file? (Y/n): ");
            input = Console.ReadLine();
            string myString;
            if(Equals(input, "Y") || Equals(input, "y") || Equals(input, "Yes") || Equals(input, "yes") || Equals(input, ""))
            {
                Console.WriteLine("Enter full path to file: ");
                string textFilePath = Console.ReadLine();
                myString = File.ReadAllText(textFilePath);
                if (!caseSense)
                {
                    myString = myString.ToLower();
                }
            } else
            {
                Console.WriteLine("Enter text to parse:");
                myString = Console.ReadLine();
                if (!caseSense)
                {
                    myString = myString.ToLower();
                }
            }

            // Get character counts
            Console.WriteLine("Calculating character count...");
            Letters myLetters = new Letters(myString);
            myLetters.Print();
        }
    }
}
