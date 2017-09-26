using System;
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
            bool doAgain = true;
            while (doAgain == true)
            {
                Console.WriteLine("Welcome to the Pig Latin translator! Please enter a word for translation!");
                string inputWord = Console.ReadLine().ToLower();

                char[] letters = inputWord.ToCharArray(); //convert word to a character array
                if (IsVowel(letters[0])) //run the isvowel method to determine whether the first letter in the array is a vowel
                {
                    Console.WriteLine(inputWord + "-way");
                }
                else
                {
                    foreach (char l in letters) //loop through letter in the array
                    {
                        if (IsVowel(l))
                        {
                            int v = inputWord.IndexOf(l); //return the index of that vowel
                            string vowelEnd = inputWord.Substring(0, v); // create a string that takes all the letters to the vowel
                            string vowelBegin = inputWord.Substring(v); //create a string that takes all the letters from the vowel to the end of the word
                            Console.WriteLine(vowelBegin + "-" + vowelEnd + "ay");
                            break; //so that it doesn't run the preceding four lines of code for every vowel in the array
                        }
                    }
                }
                doAgain = Again();
            }
        }

        public static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            return (vowels.Contains(c)); //returns true if vowel, false if not
        }

        public static bool Again()
        {
            Console.WriteLine("Enter another word? Y/N");
            string response = Console.ReadLine();
            response = response.ToUpper();
            bool anotherWord;
            if (response == "Y")
            {
                anotherWord = true;
            }
            else if (response == "N")
            {
                anotherWord = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                anotherWord = Again();
            }

            return anotherWord;
        }
    }
}
