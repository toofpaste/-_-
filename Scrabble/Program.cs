using System;

namespace Scrabble
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word :");
            string ಠ___ಠ  = Console.ReadLine();


            Letters ಠᴗಠ = new Letters(ಠ___ಠ);

            Console.WriteLine("Score: " + ಠᴗಠ.GetScore(ಠᴗಠ.GetWord()));
        }
    }
}
