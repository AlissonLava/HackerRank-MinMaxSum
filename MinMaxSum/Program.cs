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

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long curSum = 0;
        long maxSum = 0;
        long minSum = 0;

        for (int i = 0; i < 5; i++)
        {
            curSum = 0;

            for (int j = 0; j < 5; j++)
            {
                if (j != i)
                {
                    curSum = curSum + arr[j];
                }
            }

            if (curSum > maxSum)
            {
                maxSum = curSum;
            }

            if ((curSum < minSum) | (minSum == 0))
            {
                minSum = curSum;
            }
        }

        Console.WriteLine($"{minSum} {maxSum}");
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
