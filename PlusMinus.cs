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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal positive = 0;
        decimal negative = 0;
        decimal zero = 0;
       int result = 0;
       int increment = 0;
        
        decimal length = arr.Count;
        for(int i =0; i < arr.Count; i++)
        {
            if(arr[i] > 0)
            {
                positive ++;
            }
            else if(arr[i] < 0)
            {
              negative++;
            }
            else if(arr[i] == 0)
            {
                zero++;
            }
            
        }
        Console.WriteLine(positive/arr.Count);
        Console.WriteLine(negative/arr.Count);
        Console.WriteLine(zero/arr.Count);
        Console.Read();

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
