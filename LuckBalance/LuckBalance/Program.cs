using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the luckBalance function below.
    static int luckBalance(int k, int[][] contests)
    {
        int totalLuckValues = 0;
        List<int> mandatoryContest = new List<int>();
        for (int i = 0; i < contests.GetLength(0); i++)
        {
            totalLuckValues += contests[i][0];

            if (contests[i][1] == 1)
            {
               mandatoryContest.Add(contests[i][0]);
            }
            
        }

        int minimumKContestLuck = mandatoryContest.Where(x => x > 0)
                                                    .OrderBy(x => x)
                                                    .Take(mandatoryContest.Count - k)
                                                    .Sum();

        return totalLuckValues - (2 * minimumKContestLuck);
    }

    static void Main(string[] args)
    {
        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[][] contests = new int[n][];

        for (int i = 0; i < n; i++)
        {
            contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
        }

        int result = luckBalance(k, contests);

        Console.WriteLine(result);
    }
}
