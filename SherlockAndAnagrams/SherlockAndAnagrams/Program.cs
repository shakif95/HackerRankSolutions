using System;
using System.Collections.Generic;
using System.Linq;

namespace SherlockAndAnagrams
{
    class Program
    {
       
        // Complete the sherlockAndAnagrams function below.
        static int SherlockAndAnagrams(string s)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>(26);

            for (int start = 0; start < s.Length; start++)
            {
                string substring = "";
                for (int end = start; end < s.Length; end++)
                {
                    string c = s[end].ToString();
                    substring += c;

                    if (substring.Length > 1)
                    {
                        char[] array = substring.ToCharArray();
                        Array.Sort(array);
                        substring = new string(array);
                    }


                    if (counts.ContainsKey(substring))
                    {
                        counts[substring]++;
                    }
                    else
                    {
                        counts.Add(substring,1);
                    }
                }
            }
            int analgrams = 0;
            foreach(int value in counts.Values)
            {
                analgrams += (value*(value-1)) / 2;
            }

            return analgrams;
        }

        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            while(i<test)
            {
                string s = Console.ReadLine();
                Console.WriteLine(SherlockAndAnagrams(s));
                i++;
            }

            

            Console.Read();
        }
    }
}
