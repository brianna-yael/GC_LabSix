﻿using System;
//using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace labSix
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to the Pig Latin translator! Please enter a word for translation!");
                string inputWord = Console.ReadLine().ToLower();


                char[] letters = inputWord.ToCharArray();
                if (IsVowel(letters[0]))
                {
                    Console.WriteLine(inputWord + "-way");
                }
                else
                {
                    foreach (char l in letters)
                    {
                        bool b = IsVowel(l);
                        if (b == true)
                        {
                            int v = inputWord.IndexOf(l);
                            string vowelEnd = inputWord.Substring(0, v);
                            string vowelBegin = inputWord.Substring(v);
                            Console.WriteLine(vowelBegin + "-" + vowelEnd + "ay");
                            break;
                        }
                    }
                }
                run = Continue();
            }
        }

        public static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            if (vowels.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }

            return goOn;
        }
    }
}
