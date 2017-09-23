using System;
namespace Grand_Circus___LabSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin translator! Please enter a Word for translation!");
            string inputWord = Console.ReadLine().ToLower();
            char[] WordsArray = inputWord.ToCharArray();
            string firstLetter = char.ToString(WordsArray[0]);
        }
    }
}