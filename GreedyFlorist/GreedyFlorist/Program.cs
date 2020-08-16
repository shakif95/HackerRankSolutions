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

    // Complete the getMinimumCost function below.
    static int getMinimumCost(int k, int[] c)
    {

        Array.Sort(c);
        int result = 0;

        if (k == c.Length) 
        {
            foreach(int num in c)
            {
                result += num;
            }
            return result;
        }
        int prePurchase = 0;
        
        for(int i=c.Length-1; i>=0; i-=k)
        {
            int m = k;
            result += (1+prePurchase) * c[i];
            m--;
            for (int j = 0; j < m; j++) 
            {
                if (i - (j+1) >= 0)
                    result += (1 + prePurchase) * c[i - (j + 1)];
            }

            prePurchase++;

        }

        return result;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int minimumCost = getMinimumCost(k, c);

        Console.WriteLine(minimumCost);
        Console.ReadKey();

        //textWriter.WriteLine(minimumCost);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
