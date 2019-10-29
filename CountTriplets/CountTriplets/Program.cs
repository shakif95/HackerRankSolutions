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
            Dictionary<long, long> tracks = new Dictionary<long, long>();
            
            foreach (long item in arr)
            {
                if (tracks.ContainsKey(item))
                    tracks[item]++;
                else
                    tracks.Add(item, 1);
            }
            long result = 0;
            foreach(long item in tracks.Keys)
            {
                if ((item%r==0 || item==1) && tracks.ContainsKey(item * r) && tracks.ContainsKey(item * r * r))
                    result += tracks[item] * tracks[item * r] * tracks[item * r * r];
            }

            return result;
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
