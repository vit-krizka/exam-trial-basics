using System;
using System.Collections.Generic;
using System.IO;

namespace MostCommonCharacters
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"../../../countchar.txt";
            string text = File.ReadAllText(path);

            Dictionary<char, int> allLetters = CountLetters(text);

            //vypsání Dictionary allLetters
            foreach (KeyValuePair<char, int> kvp in allLetters)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            //hledání nejčatějšího - zatím jen takto do konzole
            Console.WriteLine();
            Console.Write("The most common chars is ");
            getMostCommonCharacters(allLetters);
        }

        //metoda, která vytvoří list se všemi znaky a jejich počty
        public static Dictionary<char, int> CountLetters(string input)
        {
            Dictionary<char, int> output = new Dictionary<char, int> { };

            char[] charArray = new char[input.Length];

            charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (!output.ContainsKey(charArray[i]))
                {
                    output.Add(charArray[i], 1);
                }
                else
                {
                    output[charArray[i]] = output[charArray[i]] + 1;
                }
            }

            return output;
        }

        //metoda, která najde nejčastější znak
        public static void getMostCommonCharacters(Dictionary<char, int> input)
        {
            foreach (var item in input)
            {
                if (item.Value == input.Values.Max())
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}

//Write a function named getTwoMostCommonCharacters that takes a filename as a parameter, and returns the 2 most common characters and their occurrences in the file's content.

//C#: return with a Dictionary
//If the file does not exist throw an exception with the following message: "File does not exist!"