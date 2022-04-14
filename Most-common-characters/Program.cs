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

            //POKUS:


            //vypsání Dictionary
            foreach (KeyValuePair<char, int> kvp in allLetters)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            //Dictionary<char, int> firstLetter = getTwoMostCommonCharacters(allLetters);

            //foreach (KeyValuePair<char, int> kvp in firstLetter)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            //}
        }

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


        //public static Dictionary<char, int> getTwoMostCommonCharacters(Dictionary<char, int> input)
        //{
        //    Dictionary<char, int> output = new Dictionary<char, int> { };

        //    int valueOfMaxValue;
        //    char keyOfMaxValue = 'a';

        //    valueOfMaxValue = input.Keys.Max();

        //    foreach (var item in input)
        //    {
        //        if (item.Value == valueOfMaxValue)
        //        {
        //            keyOfMaxValue = item.Key;
        //        }
        //    }

        //    output.Add(keyOfMaxValue, valueOfMaxValue);

        //    return output;
        //}

        public static Dictionary<char, int> getTwoMostCommonCharacters(Dictionary<char, int> input)
        {
            Dictionary<char, int> output = new Dictionary<char, int> { };

            int valueOfMaxValue = 0;
            char keyOfMaxValue;
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int maxValue = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                try
                {
                    if (input[chars[i]] > valueOfMaxValue)
                    {
                        valueOfMaxValue = input[chars[i]];
                        keyOfMaxValue = chars[i];
                    }
                }
                catch
                {

                }
            }

            output.Add(keyOfMaxValue, valueOfMaxValue);

            return output;
        }
    }
}

//Write a function named getTwoMostCommonCharacters that takes a filename as a parameter, and returns the 2 most common characters and their occurrences in the file's content.

//C#: return with a Dictionary
//If the file does not exist throw an exception with the following message: "File does not exist!"