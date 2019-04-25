using System;
using System.Collections.Generic;
namespace Scrabble
{
    public class Letters
    {
        private string   ಠ_ಠ ;
        private static Dictionary<char, int> ʕoᴥoʔ = new Dictionary<char, int>(){{'A', 1}, { 'E', 1 }, { 'I', 1 } ,{ 'O', 1 }, { 'U', 1 }, { 'L', 1 }, { 'N', 1 }, { 'R', 1 }, { 'S', 1 }, { 'T', 1 }, { 'D', 2 }, { 'G', 2 }, { 'B', 3 }, { 'C', 3 }, { 'M', 3 }, { 'P', 3 }, { 'F', 4 }, { 'H', 4 }, { 'V', 4 }, { 'W', 4 }, { 'Y', 4 }, { 'K', 5 }, { 'J', 8 }, { 'X', 8 }, { 'Q', 10 }, { 'Z', 10 }};
        public Letters(string ಥ_ಥ)
        {
                            ಠ_ಠ = ಥ_ಥ;
        }
        public string GetWord()
        {
            return ಠ_ಠ;
        }

        public int GetScore(string ಥ_ಥ)
        {
                                 ಥ_ಥ  = ಥ_ಥ.ToUpper();
            char[] ಠ___ಠ = ಥ_ಥ.ToCharArray();
            int ツ = 0;
            int ಠ_ರೃ = 0;
            while(ツ < ಠ___ಠ.Length)
            {
                                            ಠ_ರೃ += ʕoᴥoʔ[ಠ___ಠ[ツ]];
                ツ++;
            }
            return ಠ_ರೃ;
        }
    }
}
