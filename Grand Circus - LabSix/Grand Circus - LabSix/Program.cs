using System;
//using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Grand_Circus___LabSix
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord, wordEnding, wordBeginning = "jane";
            Console.WriteLine("Welcome to the Pig Latin translator! Please enter a Word for translation!");

            inputWord = Console.ReadLine().ToLower();
            char[] word = inputWord.ToCharArray();
            char v = word[0];
            IsVowel(v);

            if(true)
            {
                Console.WriteLine("false");
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
    }
}