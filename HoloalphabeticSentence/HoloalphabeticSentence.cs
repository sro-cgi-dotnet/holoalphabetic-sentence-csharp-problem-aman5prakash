using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            int n = input.Length;
            input=input.ToLower();
            int alphabetFound = 0;
            for(int i=0; i<26; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if(alphabets[i]==input[j]) 
                    {
                        alphabetFound++;
                        break;
                    }
                }
            }
            if(alphabetFound == 26)
            {
                return true;
            }
            return false;
        }
    }
}
