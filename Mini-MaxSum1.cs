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
        long maxValue = 0;
        long minValue = 0;
        long sum = 0;
        minValue = arr[0];
        maxValue = minValue;
        sum = minValue;
        for(int i = 1; i < arr.Count; i++)
        {
            sum += arr[i];
            
         if(arr[i] < minValue)
         {
             minValue = arr[i];
         }
         else if(arr[i] > maxValue)
         {
             maxValue = arr[i];
         }
         
        }
        Console.WriteLine((sum - maxValue) +" "+ (sum - minValue) );
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
