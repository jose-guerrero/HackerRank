using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int minimumAbsoluteDifference(int n, int[] arr) {

        Array.Sort(arr);
        int res = Math.Abs(arr[0]-arr[1]);
        for (int i=1;i<n-1;i++)
        {
            if (Math.Abs(arr[i]-arr[i+1])<res)
            {
                res = Math.Abs(arr[i]-arr[i+1]);
            }
        }
        return res;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        int result = minimumAbsoluteDifference(n, arr);
        Console.WriteLine(result);
    }
}