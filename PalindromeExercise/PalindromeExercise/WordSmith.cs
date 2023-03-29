using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var len = word.Length;
            
            for (int i = 0; i < len/2; i++)
            {
                if (word[i] != word[len - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
