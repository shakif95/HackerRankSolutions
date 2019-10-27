// Date Sunmitted: 
// Problem Link: https://www.hackerrank.com/challenges/special-palindrome-again/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
//Problem Type: string
using System;

namespace SpecialPalindormeAgain
{
    class Program
    {
        static long substrCount(int n, string s)
        {
            long result = 0;
            char[] allchars = s.ToCharArray();
            char[] subChar = new char[s.Length + 1];
            int subcharlen = 0;
            char first = allchars[0];
            for(int i=1;i<allchars.Length;i++)
            {
                if(allchars[i]==first)
                {
                    subChar[subcharlen] = allchars[i];
                    subcharlen++;
                }
                else
                {
                    if (subChar == s.Substring(i, s.Length).ToCharArray())
                        return 1;
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            long result = substrCount(n, s);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
