/**
 * Problem Link: https://www.hackerrank.com/challenges/count-triplets-1/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
 * Author: Shakif Malek
 * Type: Data Structure
 * Date Submitted: 
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace CountTriplets
{
    class Program
    {
        static long countTriplets(List<long> arr, long r)
        {
            Dictionary<long, long> Counts = new Dictionary<long, long>();
            Dictionary<long, long> Probables = new Dictionary<long, long>();
            long count = 0;
            foreach(long item in arr)
            {
                long key = item / r;

                if(Counts.ContainsKey(key) && item % r == 0)
                {
                    count += Counts[key];
                }

                if(Probables.ContainsKey(key) && item % r==0)
                {
                    long CurrentCount = Probables[key];
                    
                    if(Counts.ContainsKey(item))
                    {
                        Counts[item] += CurrentCount;
                    }
                    else
                    {
                        Counts.Add(item, CurrentCount);
                    }
                }

                if(Probables.ContainsKey(item))
                {
                    Probables[item]++;
                }
                else
                {
                    Probables.Add(item, 1);
                }
            }
            

            return count;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.Read());
            long r = Convert.ToInt64(Console.ReadLine());

            List<long> arr = Console.ReadLine().TrimEnd().Split(' ')
                                .ToList()
                                .Select(arrTemp => Convert.ToInt64(arrTemp))
                                .ToList();

            long ans = countTriplets(arr, r);
            Console.WriteLine(ans);
            Console.ReadKey();
        }

        
    }
}
