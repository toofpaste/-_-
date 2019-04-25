using System;

namespace Scrabble
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word :");
            string userWord = Console.ReadLine();


            Letters mikeIsABitch = new Letters(userWord);

            Console.WriteLine("Score: " + mikeIsABitch.GetScore(mikeIsABitch.GetWord()));
        }
    }
}
