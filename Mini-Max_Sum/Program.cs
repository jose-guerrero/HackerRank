using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void miniMaxSum(int[] arr) {
        int mini = arr[0], maxi=arr[0];
        long sum = arr[0];

        for (int i = 1; i< 5; i++ )
        {
            sum += arr[i];
            if (arr[i]<mini)  mini = arr[i];
            if (arr[i]>maxi)  maxi = arr[i];
        }

        Console.WriteLine((sum-maxi)+" "+(sum-mini));
    }

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        miniMaxSum(arr);
    }
}

