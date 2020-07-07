/*using System.Collections.Generic;
using System.Linq;

namespace System
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var maxIteration = Console.ReadLine();
            var maxIterationNum = int.Parse(maxIteration);

            Console.WriteLine("Activate rule 1? ('Fizz' for 3*)(Y/N)");
            string fizzRule = Console.ReadLine();
            Console.WriteLine("Activate rule 2? ('Buzz' for 5*)(Y/N)");
            string buzzRule = Console.ReadLine();
            Console.WriteLine("Activate rule 3? ('Bang' for 7*)(Y/N)");
            string bangRule = Console.ReadLine();
            Console.WriteLine("Activate rule 4? ('Bong' for 11*)(Y/N)");
            string bongRule = Console.ReadLine();
            Console.WriteLine("Activate rule 5? ('Fezz' for 13*)(Y/N)");
            string fezzRule = Console.ReadLine();
            Console.WriteLine("Activate rule 6? (reverse for 17*)(Y/N)");
            string reverseRule = Console.ReadLine();

            foreach (int i in Enumerable.Range(1, maxIterationNum))
            {
                var wordList = new List <string>();
                
                if (i % 3 == 0 && fizzRule == "Y")
                {
                    wordList.Add("Fizz");
                }

                if (i % 13 == 0 && fezzRule == "Y")
                {
                    wordList.Add("Fezz");
                }
                
                if (i % 5 == 0 && buzzRule == "Y")
                {
                    wordList.Add("Buzz");
                }
                
                if (i % 7 == 0 && bangRule == "Y")
                {
                    wordList.Add("Bang");
                }

                if (i % 11 == 0 && bongRule == "Y")
                {
                    wordList = implementEleven(wordList);
                }

                if (i % 17 == 0 && reverseRule == "Y")
                {
                    wordList.Reverse();
                }

                printOutput(wordList, i);
            }
        }

        private static void printOutput(List<string> wordList, int i)
        {
            var outputString = "";
            foreach (var word in wordList)
            {
                outputString += word;
            }

            Console.WriteLine(wordList.Count == 0 ? i.ToString() : outputString);
        }


        private static List<string> implementEleven(List<string> wordList)
        {
            if (wordList.Count == 1 && wordList.Contains("Fezz"))
            {
                wordList.Add("Bong");
            }
            else
            {
                wordList = new List<string>();
                wordList.Add("Bong"); // continue from here
            }

            return wordList;
        }
    }
}*/